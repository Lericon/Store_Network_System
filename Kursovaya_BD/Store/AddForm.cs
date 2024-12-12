using Npgsql;
using SharedModels;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;

namespace Store
{
    public partial class AddForm : Form, IConnectionStringConsumer
    {
        private string _connectionString;
        public int _currentStoreId;
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
                        string query = "SELECT * FROM store WHERE id = @SelectedId;";
                        using (var command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("SelectedId", selectedId);
                            using (var reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    _currentStoreId = reader.GetInt32(0);
                                    NameTextBox.Text = reader.GetString(1);
                                    cityComboBox.SelectedIndex = reader.GetInt32(2) - 1;
                                    streetComboBox.SelectedIndex = reader.GetInt32(3) - 1;
                                }
                            }
                        }
                    }
                    CreateBtn.Click += UpdateStore;
                }
                else if (openType == "Delete")
                {
                    if (MessageBox.Show("Вы уверены, что хотите удалить этот магазин?", "Удаление данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (var connection = new NpgsqlConnection(_connectionString))
                        {
                            connection.Open();
                            string query = "DELETE FROM store WHERE id = @Id;";
                            using (var command = new NpgsqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("Id", selectedId);
                                command.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Удаление магазина успешно!");
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

        private void UpdateStore(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите обновить данные этого магазина?", "Обновление данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(NameTextBox.Text) || cityComboBox.SelectedItem == null || streetComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string? cityName = cityComboBox.SelectedItem.ToString();
                string? streetName = streetComboBox.SelectedItem.ToString();
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
                                UPDATE store 
                                SET store_name = @StoreName,
                                    city_id = @CityId,
                                    street_id = @StreetId,
                                WHERE id = @SelectedId;";
                        using (var command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("StoreName", NameTextBox.Text);
                            command.Parameters.AddWithValue("SelectedId", _currentStoreId);
                            command.Parameters.AddWithValue("CityId", cityid);
                            command.Parameters.AddWithValue("StreetId", streetid);
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Данные о магазине изменены успешно!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void SaveStore(string StoreName, int cityid, int streetid)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                string query = @"
                        INSERT INTO store (store_name, city_id, street_id) 
                        VALUES (@StoreName, @CityId, @StreetId);";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("StoreName", StoreName);
                    command.Parameters.AddWithValue("CityId", cityid);
                    command.Parameters.AddWithValue("StreetId", streetid);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string StoreName = NameTextBox.Text;
                if (string.IsNullOrEmpty(NameTextBox.Text) || cityComboBox.SelectedItem == null || streetComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string? cityName = cityComboBox.SelectedItem.ToString();
                string? streetName = streetComboBox.SelectedItem.ToString();
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
                SaveStore(StoreName, cityid, streetid);
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Магазин успешно добавлен!");
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
