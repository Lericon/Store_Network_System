using Npgsql;
using SharedModels;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Seller
{
    public partial class AddForm : Form, IConnectionStringConsumer
    {
        private string _connectionString;
        public int _currentSellerId;
        private readonly Dictionary<string, int> _stores = [];
        private readonly Dictionary<string, int> _storesCombo = [];
        private readonly Dictionary<string, int> _departments = [];
        private readonly Dictionary<string, int> _departmentsCombo = [];
        private readonly Dictionary<string, int> _qualifications = [];
        private readonly Dictionary<string, int> _qualificationsCombo = [];
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
            LoadStoreComboBox();
            LoadDepartmentComboBox();
            LoadQualificationComboBox();
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
                        string query = "SELECT * FROM seller WHERE id = @SelectedId;";
                        using (var command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("SelectedId", selectedId);
                            using (var reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    _currentSellerId = reader.GetInt32(0);
                                    LastNameTextBox.Text = reader.GetString(1);
                                    FirstNameTextBox.Text = reader.GetString(2);
                                    SurnameTextBox.Text = reader.GetString(3);
                                    bool gender = reader.GetBoolean(4);
                                    if (gender == false)
                                    {
                                        GenderComboBox.SelectedIndex = 0;
                                    }
                                    else
                                    {
                                        GenderComboBox.SelectedIndex = 1;
                                    }
                                    AgeNumUpDown.Value = reader.GetInt32(5);
                                    WorkExpTextBox.Text = reader.GetString(6);
                                    storeComboBox.SelectedIndex = _storesCombo[_stores.FirstOrDefault(x => x.Value == reader.GetInt32(7)).Key];
                                    departmentComboBox.SelectedIndex = _departmentsCombo[_departments.FirstOrDefault(x => x.Value == reader.GetInt32(8)).Key];
                                    qualificationComboBox.SelectedIndex = _qualificationsCombo[_qualifications.FirstOrDefault(x => x.Value == reader.GetInt32(9)).Key];
                                }
                            }
                        }
                    }
                    CreateBtn.Click += UpdateSeller;
                }
                else if (openType == "Delete")
                {
                    if (MessageBox.Show("Вы уверены, что хотите удалить этого продавца?", "Удаление данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (var connection = new NpgsqlConnection(_connectionString))
                        {
                            connection.Open();
                            string query = "DELETE FROM seller WHERE id = @Id;";
                            using (var command = new NpgsqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("Id", selectedId);
                                command.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Удаление продавца успешно!");
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

        private void UpdateSeller(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите обновить данные этого продавца?", "Обновление данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(LastNameTextBox.Text) || string.IsNullOrEmpty(FirstNameTextBox.Text) || string.IsNullOrEmpty(SurnameTextBox.Text) || string.IsNullOrEmpty(WorkExpTextBox.Text))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (storeComboBox.SelectedItem == null || departmentComboBox.SelectedItem == null || qualificationComboBox.SelectedItem == null || GenderComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string storeName = storeComboBox.SelectedItem.ToString().Split(' ')[0];
                string departmentName = departmentComboBox.Text;
                string qualificationName = qualificationComboBox.Text;
                if (!_stores.TryGetValue(storeName, out var storeid))
                {
                    MessageBox.Show($"Не существует магазина с названием {storeName}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!_departments.TryGetValue(departmentName, out var departmentid))
                {
                    MessageBox.Show($"Не существует отдела с названием {departmentName}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!_qualifications.TryGetValue(qualificationName, out var qualificationid))
                {
                    MessageBox.Show($"Не существует квалификации с названием {qualificationName}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    using (var connection = new NpgsqlConnection(_connectionString))
                    {
                        connection.Open();
                        string query = @"
                                UPDATE seller 
                                SET last_name = @LastName,
                                    first_name = @FirstName,
                                    surname = @Surname,
                                    gender = @Gender,
                                    age = @Age,
                                    work_exp = @WorkExp,
                                    store_id = @StoreId,
                                    department_id = @DepartmentId,
                                    qualification_id = @QualificationId
                                WHERE id = @SelectedId;";
                        using (var command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("LastName", LastNameTextBox.Text);
                            command.Parameters.AddWithValue("FirstName", FirstNameTextBox.Text);
                            command.Parameters.AddWithValue("Surname", SurnameTextBox.Text);
                            string SellerGenderString = GenderComboBox.SelectedItem.ToString();
                            bool SellerGender = (SellerGenderString == "Мужской") ? false : true;
                            command.Parameters.AddWithValue("Gender", SellerGender);
                            command.Parameters.AddWithValue("Age", AgeNumUpDown.Value);
                            command.Parameters.AddWithValue("WorkExp", WorkExpTextBox.Text);
                            command.Parameters.AddWithValue("StoreId", storeid);
                            command.Parameters.AddWithValue("DepartmentId", departmentid);
                            command.Parameters.AddWithValue("QualificationId", qualificationid);
                            command.Parameters.AddWithValue("SelectedId", _currentSellerId);
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Данные о продавце изменены успешно!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void SaveSeller(string SellerLastName, string SellerFirstName, string SellerSurname, bool SellerGender, int SellerAge, string SellerWorkExp, int storeid, int departmentid, int qualificationid)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();

                string query = "INSERT INTO seller (last_name, first_name, surname, gender, age, work_exp, store_id, department_id, qualification_id) VALUES (@SellerLastName, @SellerFirstName, @SellerSurname, @SellerGender, @SellerAge, @SellerWorkExp, @storeid, @departmentid, @qualificationid);";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("SellerLastName", SellerLastName);
                    command.Parameters.AddWithValue("SellerFirstName", SellerFirstName);
                    command.Parameters.AddWithValue("SellerSurname", SellerSurname);
                    command.Parameters.AddWithValue("SellerGender", SellerGender);
                    command.Parameters.AddWithValue("SellerAge", SellerAge);
                    command.Parameters.AddWithValue("SellerWorkExp", SellerWorkExp);
                    command.Parameters.AddWithValue("storeid", storeid);
                    command.Parameters.AddWithValue("departmentid", departmentid);
                    command.Parameters.AddWithValue("qualificationid", qualificationid);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string SellerLastName = LastNameTextBox.Text;
                string SellerFirstName = FirstNameTextBox.Text;
                string SellerSurname = SurnameTextBox.Text;
                int SellerAge = (int)AgeNumUpDown.Value;
                string SellerWorkExp = WorkExpTextBox.Text;
                if 
                (
                    string.IsNullOrEmpty(SellerLastName) || 
                    string.IsNullOrEmpty(SellerFirstName) || 
                    string.IsNullOrEmpty(SellerSurname) || 
                    string.IsNullOrEmpty(SellerWorkExp) ||
                    storeComboBox.SelectedItem == null ||
                    departmentComboBox.SelectedItem == null ||
                    qualificationComboBox.SelectedItem == null ||
                    GenderComboBox.SelectedItem == null
                )
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string? SellerGenderString = GenderComboBox.SelectedItem.ToString();
                bool SellerGender = (SellerGenderString == "Мужской") ? false : true;
                string storeName = storeComboBox.SelectedItem.ToString().Split(' ')[0];
                string departmentName = departmentComboBox.Text;
                string qualificationName = qualificationComboBox.Text;
                if (!_stores.TryGetValue(storeName, out var storeid))
                {
                    MessageBox.Show($"Не существует магазина с названием {storeName}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!_departments.TryGetValue(departmentName, out var departmentid))
                {
                    MessageBox.Show($"Не существует отдела с названием {departmentName}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!_qualifications.TryGetValue(qualificationName, out var qualificationid))
                {
                    MessageBox.Show($"Не существует квалификации с названием {qualificationName}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SaveSeller(SellerLastName, SellerFirstName, SellerSurname, SellerGender, SellerAge, SellerWorkExp, storeid, departmentid, qualificationid);
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Продавец успешно добавлен!");
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

        private void LoadStoreComboBox()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                int i = 0;
                connection.Open();
                var query = @"
                    SELECT s.id, s.store_name, c.city_name, st.street_name 
                    FROM store s
                    LEFT JOIN city c ON s.city_id = c.id
                    LEFT JOIN street st ON s.street_id = st.id
                    ORDER BY s.id;";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var storeName = reader.GetString(1);
                            var idName = reader.GetInt32(0);
                            string? cityName = reader.IsDBNull(2) ? null : reader.GetString(2);
                            string? streetName = reader.IsDBNull(3) ? null : reader.GetString(3);

                            storeComboBox.Items.Add(storeName + " " + cityName + " " + streetName);
                            _stores.Add(storeName, idName);
                            _storesCombo.Add(storeName, i);
                            i++;
                        }
                    }
                }
            }
        }

        private void LoadDepartmentComboBox()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                int i = 0;
                connection.Open();
                var query = @"SELECT id, department_name FROM department;";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var idName = reader.GetInt32(0);
                            var departmentName = reader.GetString(1);

                            departmentComboBox.Items.Add(departmentName);
                            _departments.Add(departmentName, idName);
                            _departmentsCombo.Add(departmentName, i);
                            i++;
                        }
                    }
                }
            }
        }

        private void LoadQualificationComboBox()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                int i = 0;
                connection.Open();
                var query = @"SELECT id, qualification_name FROM qualification;";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var idName = reader.GetInt32(0);
                            var qualificationName = reader.GetString(1);

                            qualificationComboBox.Items.Add(qualificationName);
                            _qualifications.Add(qualificationName, idName);
                            _qualificationsCombo.Add(qualificationName, i);
                            i++;
                        }
                    }
                }
            }
        }
    }
}
