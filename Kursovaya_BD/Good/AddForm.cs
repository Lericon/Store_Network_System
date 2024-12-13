using Npgsql;
using SharedModels;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;
using System.Diagnostics;

namespace Good
{
    public partial class AddForm : Form, IConnectionStringConsumer
    {
        private string _connectionString;
        public int _currentGoodId;
        private readonly Dictionary<string, int> _units = [];
        private readonly Dictionary<string, int> _unitsCombo = [];
        private readonly Dictionary<string, int> _stores = [];
        public AddForm(float fontSize)
        {
            InitializeComponent();
            ChangeFontSizeInForm(this, fontSize);
        }
        public void ChangeFontSizeInForm(Control? parent, float newSize)
        {
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
        public void SetConnectionString(string connectionString)
        {
            _connectionString = connectionString;
            LoadUnitsComboBox();
        }
        public void SetOpenType(string openType, int? selectedId, bool isAdmin)
        {
            try
            {
                if (openType == "Edit" && selectedId != null)
                {
                    using (var connection = new NpgsqlConnection(_connectionString))
                    {
                        connection.Open();
                        string query = "SELECT * FROM good WHERE id = @SelectedId;";
                        using (var command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("SelectedId", selectedId);
                            using (var reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    _currentGoodId = reader.GetInt32(0);
                                    RemainingStockNUD.Value = reader.GetInt32(1);
                                    PurPriceNUD.Value = reader.GetInt32(2);
                                    PriceNUD.Value = reader.GetInt32(3);
                                    unitComboBox.SelectedIndex = _unitsCombo[_units.FirstOrDefault(x => x.Value == reader.GetInt32(4)).Key];
                                    NameTextBox.Text = reader.GetString(5);
                                }
                            }
                        }
                    }
                    CreateBtn.Click += UpdateGood;
                }
                else if (openType == "Delete")
                {
                    if (MessageBox.Show("Вы уверены, что хотите удалить этот товар?", "Удаление данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (var connection = new NpgsqlConnection(_connectionString))
                        {
                            connection.Open();
                            string query = "DELETE FROM good WHERE id = @Id;";
                            using (var command = new NpgsqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("Id", selectedId);
                                command.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Удаление товара успешно!");
                        this.Close();
                    }
                    else
                    {
                        this.Close();
                    }

                }
                else if (openType == "Add")
                {
                    CreateBtn.Click += CreateBtn_Click;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateGood(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите обновить данные этого товара?", "Обновление данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(NameTextBox.Text) || unitComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string? unitName = unitComboBox.SelectedItem.ToString();
                if (!_units.TryGetValue(unitName, out var unitid))
                {
                    MessageBox.Show($"Не существует отдела с названием {unitName}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    using (var connection = new NpgsqlConnection(_connectionString))
                    {
                        connection.Open();
                        string query = @"
                                UPDATE good 
                                SET name = @GoodName,
                                    remaining_stock = @RemainingStock,
                                    purchase_price = @PurchasePrice,
                                    price = @Price,
                                    unit_id = @UnitId
                                WHERE id = @SelectedId;";
                        using (var command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("GoodName", NameTextBox.Text);
                            command.Parameters.AddWithValue("RemainingStock", RemainingStockNUD.Value);
                            command.Parameters.AddWithValue("PurchasePrice", PurPriceNUD.Value);
                            command.Parameters.AddWithValue("Price", PriceNUD.Value);
                            command.Parameters.AddWithValue("UnitId", unitid);
                            command.Parameters.AddWithValue("SelectedId", _currentGoodId);
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Данные о товаре изменены успешно!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void SaveGood(string GoodName, int RemainingStock, int PurchasePrice, int Price, int unitid)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                string query = @"
                        INSERT INTO good (name, remaining_stock, purchase_price, price, unit_id) 
                        VALUES (@GoodName, @RemainingStock, @PurchasePrice, @Price, @UnitId);";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("GoodName", GoodName);
                    command.Parameters.AddWithValue("RemainingStock", RemainingStock);
                    command.Parameters.AddWithValue("PurchasePrice", PurchasePrice);
                    command.Parameters.AddWithValue("Price", Price);
                    command.Parameters.AddWithValue("UnitId", unitid);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(NameTextBox.Text) || unitComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string GoodName = NameTextBox.Text;
                int RemainingStock = (int)RemainingStockNUD.Value;
                int PurchasePrice = (int)PurPriceNUD.Value;
                int Price = (int)PriceNUD.Value;
                string? unitName = unitComboBox.SelectedItem.ToString();
                if (!_units.TryGetValue(unitName, out var unitid))
                {
                    MessageBox.Show($"Не существует отдела с названием {unitName}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SaveGood(GoodName, RemainingStock, PurchasePrice, Price, unitid);
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Товар успешно добавлен!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadUnitsComboBox()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                int i = 0;
                connection.Open();
                var query = @"SELECT * FROM unit_of_measurements;";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var idName = reader.GetInt32(0);
                            var unitName = reader.GetString(1);

                            unitComboBox.Items.Add(unitName);
                            _units.Add(unitName, idName);
                            _unitsCombo.Add(unitName, i);
                            i++;
                        }
                    }
                }
            }
        }
    }
}
