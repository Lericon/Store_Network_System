using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kursovaya_BD.Presenters;
using SharedModels;
using Kursovaya_BD.Models.DataHelpers;
using Kursovaya_BD.Models.Interfaces;

namespace Kursovaya_BD.Views
{
    public partial class MainForm : Form, IMain, ISettingsChanger
    {
        private readonly MainPresenter _presenter;
        private string _connection;
        private string _currentDLL;
        private string _currentNottakeableDLL;
        private string _currentMethod;
        private User _currentUser;
        private float FontSize;
        public string CurrentDLL
        {
            get => _currentDLL;
            private set => _currentDLL = value;
        }
        public MainForm(User user)
        {
            InitializeComponent();
            FontSize = 20.25f;
            _presenter = new MainPresenter(this, user);
            _currentUser = user;
            if (user.IsAdmin == true)
            {
                FullGrant?.Invoke(this, new EventArgs());
            }
            else
            {
                AccessGrant?.Invoke(this, new EventArgs());
            }
        }
        public void ChangeFontSizeInForm(Control? parent, float newSize)
        {
            FontSize = newSize;
            if (parent == null)
            {
                parent = this;
            }
            foreach (Control control in parent.Controls)
            {
                control.Font = new Font(control.Font.FontFamily, newSize, control.Font.Style);
                if (control is Label || control is Button || control is CheckBox || control is ToolStripMenuItem || control is Panel)
                {
                    control.AutoSize = false;
                }
                if (control.HasChildren)
                {
                    ChangeFontSizeInForm(control, newSize);
                }
            }
            this.Refresh();
        }

        public event EventHandler FullGrant;
        public event EventHandler AccessGrant;
        public event EventHandler GetConnection;
        public event EventHandler<string> AddClick;
        public event EventHandler<string> UpdateClick;
        public event EventHandler<string> DeleteClick;

        public void SendConnection(string connection)
        {
            _connection = connection;
        }
        public void Message(string message)
        {
            Message form = new Message(message);
            form.ShowDialog();
        }
        public bool FirstUserForm(string message)
        {
            FirstUserForm form = new FirstUserForm(message);
            if (form.ShowDialog() == DialogResult.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void BuildMenu(List<SharedModels.Module> modules)
        {
            var menuItems = new Dictionary<long, ToolStripMenuItem>();

            foreach (var module in modules)
            {
                var menuItem = new ToolStripMenuItem(module.MenuItemName);
                menuItem.Tag = module;

                if (module.DllName != null && module.FunctionName != null)
                {
                    menuItem.Click += (s, e) =>
                    {
                        try
                        {
                            if (module.IsMethodTakeable == true)
                            {
                                _currentDLL = module.DllName;
                            }
                            else
                            {
                                _currentNottakeableDLL = module.DllName;
                            }
                            string dllPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, module.DllName);
                            var assembly = Assembly.LoadFrom(dllPath);

                            var type = assembly.GetTypes().FirstOrDefault(t => t.GetMethod(module.FunctionName) != null);
                            if (type != null)
                            {
                                GetConnection?.Invoke(this, EventArgs.Empty);
                                var instance = Activator.CreateInstance(type, new object[] { _connection, _currentUser, this });
                                var method = type.GetMethod(module.FunctionName);
                                if (method != null)
                                {
                                    if (module.IsMethodTakeable == true)
                                    {
                                        _currentMethod = module.FunctionName;
                                    }
                                    var result = method.Invoke(instance, null);
                                    if (result != null && result is IEnumerable<object>)
                                    {
                                        var dataTable = DataTableAdapter.AdaptToDataTable(result as IEnumerable<object>);
                                        ShowDataInGrid(dataTable);
                                    }
                                }
                                else
                                {
                                    throw new Exception($"Метод {module.FunctionName} не найден в классе UserService.");
                                }
                            }
                            else
                            {
                                throw new Exception($"Класс {module.FunctionName} не найден в DLL {module.DllName}.");
                            }
                        }
                        catch (Exception ex)
                        {
                            Message("Ошибка вызова функции: " + ex.ToString());
                        }
                    };
                }
                menuItems[module.Id] = menuItem;
                if (module.IdParent == 0)
                {
                    menuItem.ForeColor = Color.Black;
                    MainMenu.Items.Add(menuItem);
                }
                else if (menuItems.TryGetValue(module.IdParent, out var parentMenuItem))
                {
                    parentMenuItem.DropDownItems.Add(menuItem);
                }
            }
        }

        private void ShowDataInGrid(DataTable dataTable)
        {
            MainDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            MainDataGridView.AutoSize = true;
            MainDataGridView.DataSource = dataTable;
            MainDataGridView.Refresh();
            CenterToScreen();
        }

        public void BuildMenu(List<SharedModels.Module> modules, List<Role> userRoles)
        {
            var menuItems = new Dictionary<long, ToolStripMenuItem>();
            var rolesDict = userRoles.ToDictionary(r => r.MenuItemId);
            var moduleDict = modules.ToDictionary(m => m.Id);
            foreach (var module in modules)
            {
                module.IsNecessary = InheritIsNecessary(module, moduleDict);
                var menuItem = new ToolStripMenuItem(module.MenuItemName);
                menuItem.Tag = module;

                if (module.IsNecessary)
                {
                    AddMenuItem(menuItems, module, menuItem, null);
                    continue;
                }

                var parentRole = module.IdParent != 0 && rolesDict.TryGetValue(module.IdParent, out var parent)
                    ? parent
                    : null;
                var moduleRole = rolesDict.TryGetValue(module.Id, out var role) ? role : null;

                if (parentRole != null)
                {
                    moduleRole = new Role
                    {
                        AllowRead = parentRole.AllowRead,
                        AllowWrite = parentRole.AllowWrite,
                        AllowEdit = parentRole.AllowEdit,
                        AllowDelete = parentRole.AllowDelete,
                    };
                }

                if (moduleRole == null || !moduleRole.AllowRead) continue;

                AddMenuItem(menuItems, module, menuItem, moduleRole);
            }
        }
        private bool InheritIsNecessary(SharedModels.Module module, Dictionary<long, SharedModels.Module> moduleDict)
        {
            if (module.IsNecessary) return true;

            // проверка родительского модуля
            if (module.IdParent != 0 && moduleDict.TryGetValue(module.IdParent, out var parentModule))
            {
                return InheritIsNecessary(parentModule, moduleDict);
            }

            return false;
        }
        private void AddMenuItem(Dictionary<long, ToolStripMenuItem> menuItems, SharedModels.Module module, ToolStripMenuItem menuItem, Role moduleRole)
        {
            if (module.DllName != null && module.FunctionName != null)
            {
                menuItem.Click += (s, e) =>
                {
                    // вызов метода из dll
                    try
                    {
                        if (module.IsMethodTakeable == true)
                        {
                            _currentDLL = module.DllName;
                        }
                        else
                        {
                            _currentNottakeableDLL = module.DllName;
                        }
                        string dllPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, module.DllName);
                        var assembly = Assembly.LoadFrom(dllPath);

                        var type = assembly.GetTypes().FirstOrDefault(t => t.GetMethod(module.FunctionName) != null);
                        if (type != null)
                        {
                            GetConnection?.Invoke(this, EventArgs.Empty);
                            var instance = Activator.CreateInstance(type, new object[] { _connection, _currentUser, this });
                            var method = type.GetMethod(module.FunctionName);
                            if (method != null)
                            {
                                if (module.IsMethodTakeable == true)
                                {
                                    _currentMethod = module.FunctionName;
                                }
                                var result = method.Invoke(instance, null);
                                if (result != null && result is IEnumerable<object>)
                                {
                                    var dataTable = DataTableAdapter.AdaptToDataTable(result as IEnumerable<object>);
                                    if (moduleRole != null)
                                    {
                                        AddBtn.Enabled = moduleRole.AllowWrite;
                                        UpdateBtn.Enabled = moduleRole.AllowEdit;
                                        DeleteBtn.Enabled = moduleRole.AllowDelete;
                                    }
                                    ShowDataInGrid(dataTable);
                                }
                            }
                            else
                            {
                                throw new Exception($"Метод {module.FunctionName} не найден в DLL {module.DllName}.");
                            }
                        }
                        else
                        {
                            throw new Exception($"Метод {module.FunctionName} не найден в DLL {module.DllName}.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Message("Ошибка вызова функции: " + ex.ToString());
                    }
                };
            }

            menuItems[module.Id] = menuItem;

            // добавление в глав. меню или вложение в родительский элемент
            if (module.IdParent == 0) // высшая иерархия элемент
            {
                menuItem.ForeColor = Color.Black;
                MainMenu.Items.Add(menuItem);
            }
            else if (menuItems.TryGetValue(module.IdParent, out var parentMenuItem))
            {
                parentMenuItem.DropDownItems.Add(menuItem);
            }
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_currentDLL))
            {
                Message("Не выбран пункт меню для добавления записи.");
                return;
            }
            AddClick?.Invoke(this, _currentDLL);
            MainDataGridView.Refresh();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_currentDLL))
            {
                Message("Не выбран пункт меню для изменения записи.");
                return;
            }
            UpdateClick?.Invoke(this, _currentDLL);
            MainDataGridView.Refresh();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_currentDLL))
            {
                Message("Не выбран пункт меню для удаления записи.");
                return;
            }

            if (MainDataGridView.SelectedCells.Count > 0)
            {
                DeleteClick?.Invoke(this, _currentDLL);
                MainDataGridView.Refresh();
            }
        }

        private void RefreshData()
        {
            string dllPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _currentDLL);
            var assembly = Assembly.LoadFrom(dllPath);
            var type = assembly.GetTypes().FirstOrDefault(t => t.GetMethod(_currentMethod) != null);
            if (type != null)
            {
                GetConnection?.Invoke(this, EventArgs.Empty);
                var instance = Activator.CreateInstance(type, new object[] { _connection, _currentUser, this });
                var method = type.GetMethod(_currentMethod);
                if (method != null)
                {
                    var result = method.Invoke(instance, null);
                    if (result != null && result is IEnumerable<object>)
                    {
                        var dataTable = DataTableAdapter.AdaptToDataTable(result as IEnumerable<object>);
                        ShowDataInGrid(dataTable);
                    }
                }
                else
                {
                    throw new Exception($"Метод {_currentMethod} не найден в DLL {_currentDLL}.");
                }
            }
        }
        public void OpenForm(string currentDLL, string typeOfOpen)
        {
            try
            {
                if (_currentNottakeableDLL != null)
                {
                    currentDLL = _currentDLL;
                }
                string dllPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, currentDLL);

                var assembly = Assembly.LoadFrom(dllPath);

                var formType = assembly.GetTypes().FirstOrDefault(t => t.IsSubclassOf(typeof(Form)));
                if (formType == null)
                {
                    throw new Exception($"В DLL {currentDLL} не найден класс, унаследованный от Form.");
                }
                // экземпляр
                var formInstance = Activator.CreateInstance(formType, new object[] { FontSize });
                //закинули строку подключения
                if (formInstance is IConnectionStringConsumer consumer && formInstance is Form form)
                {
                    consumer.SetConnectionString(_connection);
                    if (MainDataGridView.SelectedCells.Count > 0)
                    {
                        var cellValue = MainDataGridView.Rows[MainDataGridView.SelectedCells[0].RowIndex].Cells[0].Value;

                        if (cellValue != null && !string.IsNullOrEmpty(cellValue.ToString()))
                        {
                            consumer.SetOpenType(typeOfOpen, int.Parse(cellValue.ToString()), _currentUser.IsAdmin);
                            if (typeOfOpen == "Delete")
                            {
                                _currentNottakeableDLL = null;
                                RefreshData();
                                return;
                            }
                            form.ShowDialog();
                            _currentNottakeableDLL = null;
                        }
                        RefreshData();
                        _currentNottakeableDLL = null;
                    }
                    else if (typeOfOpen == "Add")
                    {
                        consumer.SetOpenType(typeOfOpen, null, _currentUser.IsAdmin);
                        form.ShowDialog();
                        RefreshData();
                        _currentNottakeableDLL = null;
                    }
                    else
                    {
                        MessageBox.Show("Пожалуйста, выберите ячейку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    throw new Exception($"Класс {formType.Name} не является допустимой формой.");
                }
            }
            catch (Exception ex)
            {
                Message($"Ошибка открытия формы: {ex.Message}");
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            RefreshData();
            string searchText = SearchTextBox.Text.Trim().ToLower(); // Текст для поиска

            DataTable originalDataTable = MainDataGridView.DataSource as DataTable; // Получаем DataTable
            if (originalDataTable == null) return; // Проверяем наличие данных

            if (string.IsNullOrEmpty(searchText))
            {
                RefreshData();
                return;
            }

            // Создаем новый DataTable для фильтрованных данных
            DataTable filteredTable = originalDataTable.Clone(); // Копируем структуру таблицы

            // Перебираем строки и ищем совпадения
            foreach (DataRow row in originalDataTable.Rows)
            {
                // Проверяем каждую ячейку строки на наличие текста
                foreach (var item in row.ItemArray)
                {
                    if (item != null && item.ToString().ToLower().Contains(searchText))
                    {
                        filteredTable.ImportRow(row); // Добавляем строку в результат
                        break; // Достаточно одного совпадения
                    }
                }
            }

            // Отображаем фильтрованную таблицу
            MainDataGridView.DataSource = filteredTable;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FirstUserForm form = new FirstUserForm("Вы уверены, что хотите выйти?");
            if (form.ShowDialog() == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
