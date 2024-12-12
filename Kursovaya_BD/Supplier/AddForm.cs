using Npgsql;
using SharedModels;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Supplier
{
    public partial class AddForm : Form, IConnectionStringConsumer
    {
        private string _connectionString;
        public int _currentSupplierId;
        private readonly Dictionary<string, int> _banks = [];
        private readonly Dictionary<string, int> _cities = [];
        private readonly Dictionary<string, int> _streets = [];
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
            LoadBankComboBox();
            LoadCitiesComboBox();
            LoadStreetsComboBox();
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
                        string query = "SELECT * FROM supplier WHERE id = @SelectedId;";
                        using (var command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("SelectedId", selectedId);
                            using (var reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    _currentSupplierId = reader.GetInt32(0);
                                    LastNameTextBox.Text = reader.GetString(1);
                                    FirstNameTextBox.Text = reader.GetString(2);
                                    SurnameTextBox.Text = reader.GetString(3);
                                    PhoneNumberTextBox.Text = reader.GetString(4);
                                    BankAccountTextBox.Text = reader.GetString(5);
                                    TINTextBox.Text = reader.GetString(6);
                                    if (reader.IsDBNull(7))
                                    {
                                        bankComboBox.Text = "";
                                    }
                                    else
                                    {
                                        bankComboBox.SelectedIndex = reader.GetInt32(7) - 1;
                                    }
                                    if (reader.IsDBNull(8))
                                    {
                                        cityComboBox.Text = "";
                                    }
                                    else
                                    {
                                        cityComboBox.SelectedIndex = reader.GetInt32(8) - 1;
                                    }
                                    if (reader.IsDBNull(9))
                                    {
                                        streetComboBox.Text = "";
                                    }
                                    else
                                    {
                                        streetComboBox.SelectedIndex = reader.GetInt32(9) - 1;
                                    }
                                }
                            }
                        }
                    }
                    CreateBtn.Click += UpdateSupplier;
                }
                else if (openType == "Delete")
                {
                    if (MessageBox.Show("Вы уверены, что хотите удалить этого поставщика?", "Удаление данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (var connection = new NpgsqlConnection(_connectionString))
                        {
                            connection.Open();
                            string query = "DELETE FROM supplier WHERE id = @Id;";
                            using (var command = new NpgsqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("Id", selectedId);
                                command.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Удаление поставщика успешно!");
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

        private void UpdateSupplier(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите обновить данные этого поставщика?", "Обновление данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if
                (
                    string.IsNullOrEmpty(LastNameTextBox.Text) ||
                    string.IsNullOrEmpty(FirstNameTextBox.Text) ||
                    string.IsNullOrEmpty(SurnameTextBox.Text) ||
                    string.IsNullOrEmpty(PhoneNumberTextBox.Text) ||
                    string.IsNullOrEmpty(BankAccountTextBox.Text) ||
                    string.IsNullOrEmpty(TINTextBox.Text) ||
                    bankComboBox.SelectedItem == null ||
                    cityComboBox.SelectedItem == null ||
                    streetComboBox.SelectedItem == null
                )
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string? bankName = bankComboBox.SelectedItem.ToString();
                string? cityName = cityComboBox.SelectedItem.ToString();
                string? streetName = streetComboBox.SelectedItem.ToString();
                if (!_banks.TryGetValue(bankName, out var bankid))
                {
                    MessageBox.Show($"Не существует банка с названием {bankName}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!_cities.TryGetValue(cityName, out var cityid))
                {
                    MessageBox.Show($"Не существует отдела с названием {cityName}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!_streets.TryGetValue(streetName, out var streetid))
                {
                    MessageBox.Show($"Не существует квалификации с названием {streetName}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    using (var connection = new NpgsqlConnection(_connectionString))
                    {
                        connection.Open();
                        string query = @"
                                UPDATE supplier 
                                SET last_name = @LastName,
                                    first_name = @FirstName,
                                    surname = @Surname,
                                    phone_number = @PhoneNumber,
                                    bank_account = @BankAccount,
                                    tin = @TIN,
                                    bank_id = @BankId,
                                    city_id = @CityId,
                                    street_id = @StreetId
                                WHERE id = @SelectedId;";
                        using (var command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("LastName", LastNameTextBox.Text);
                            command.Parameters.AddWithValue("FirstName", FirstNameTextBox.Text);
                            command.Parameters.AddWithValue("Surname", SurnameTextBox.Text);
                            command.Parameters.AddWithValue("PhoneNumber", PhoneNumberTextBox.Text);
                            command.Parameters.AddWithValue("BankAccount", BankAccountTextBox.Text);
                            command.Parameters.AddWithValue("TIN", TINTextBox.Text);
                            command.Parameters.AddWithValue("BankId", bankid);
                            command.Parameters.AddWithValue("CityId", cityid);
                            command.Parameters.AddWithValue("StreetId", streetid);
                            command.Parameters.AddWithValue("SelectedId", _currentSupplierId);
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Данные о поставщике изменены успешно!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void SaveSupplier
        (
            string LastName, 
            string FirstName, 
            string Surname, 
            string PhoneNumber, 
            string BankAccount, 
            string TIN, 
            int bankid, 
            int cityid, 
            int streetid
        )
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"
                        INSERT INTO supplier 
                        (
                        last_name, first_name, surname, phone_number, 
                        bank_account, tin, bank_id, city_id, street_id
                        ) 
                        VALUES 
                        (
                        @LastName, @FirstName, @Surname, @PhoneNumber, 
                        @BankAccount, @TIN, @bankid, @cityid, @streetid
                        );";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("LastName", LastName);
                    command.Parameters.AddWithValue("FirstName", FirstName);
                    command.Parameters.AddWithValue("Surname", Surname);
                    command.Parameters.AddWithValue("PhoneNumber", PhoneNumber);
                    command.Parameters.AddWithValue("BankAccount", BankAccount);
                    command.Parameters.AddWithValue("TIN", TIN);
                    command.Parameters.AddWithValue("bankid", bankid);
                    command.Parameters.AddWithValue("cityid", cityid);
                    command.Parameters.AddWithValue("streetid", streetid);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string LastName = LastNameTextBox.Text;
                string FirstName = FirstNameTextBox.Text;
                string Surname = SurnameTextBox.Text;
                string PhoneNumber = PhoneNumberTextBox.Text;
                string BankAccount = BankAccountTextBox.Text;
                string TIN = TINTextBox.Text;
                if 
                (
                    string.IsNullOrEmpty(LastName) || 
                    string.IsNullOrEmpty(FirstName) || 
                    string.IsNullOrEmpty(Surname) || 
                    string.IsNullOrEmpty(PhoneNumber) ||
                    string.IsNullOrEmpty(BankAccount) ||
                    string.IsNullOrEmpty(TIN) ||
                    bankComboBox.SelectedItem == null ||
                    cityComboBox.SelectedItem == null ||
                    streetComboBox.SelectedItem == null
                )
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string? bankName = bankComboBox.SelectedItem.ToString();
                string? cityName = cityComboBox.SelectedItem.ToString();
                string? streetName = streetComboBox.SelectedItem.ToString();
                if (!_banks.TryGetValue(bankName, out var bankid))
                {
                    MessageBox.Show($"Не существует банка с названием {bankName}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!_cities.TryGetValue(cityName, out var cityid))
                {
                    MessageBox.Show($"Не существует отдела с названием {cityName}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!_streets.TryGetValue(streetName, out var streetid))
                {
                    MessageBox.Show($"Не существует квалификации с названием {streetName}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SaveSupplier
                (
                    LastName, 
                    FirstName, 
                    Surname, 
                    PhoneNumber, 
                    BankAccount, 
                    TIN, bankid, 
                    cityid, 
                    streetid
                );
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Поставщик успешно добавлен!");
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

        private void LoadBankComboBox()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"SELECT id, bank_name FROM bank;";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var idName = reader.GetInt32(0);
                            var bankName = reader.GetString(1);

                            bankComboBox.Items.Add(bankName);
                            _banks.Add(bankName, idName);
                        }
                    }
                }
            }
        }

        private void LoadCitiesComboBox()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"SELECT id, city_name FROM city;";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var idName = reader.GetInt32(0);
                            var cityName = reader.GetString(1);

                            cityComboBox.Items.Add(cityName);
                            _cities.Add(cityName, idName);
                        }
                    }
                }
            }
        }

        private void LoadStreetsComboBox()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"SELECT id, street_name FROM street;";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var idName = reader.GetInt32(0);
                            var streetName = reader.GetString(1);

                            streetComboBox.Items.Add(streetName);
                            _streets.Add(streetName, idName);
                        }
                    }
                }
            }
        }
    }
}
