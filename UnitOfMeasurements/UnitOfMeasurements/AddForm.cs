﻿using Npgsql;
using SharedModels;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;

namespace UnitOfMeasurements
{
    public partial class AddForm : Form, IConnectionStringConsumer
    {
        private string _connectionString;
        public int _currentUnitId;
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
                        string query = "SELECT * FROM unit_of_measurements WHERE id = @SelectedId;";
                        using (var command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("SelectedId", selectedId);
                            using (var reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    _currentUnitId = reader.GetInt32(0);
                                    NameTextBox.Text = reader.GetString(1);
                                }
                            }
                        }
                    }
                    CreateBtn.Click += UpdateUnit;
                }
                else if (openType == "Delete")
                {
                    if (MessageBox.Show("Вы уверены, что хотите удалить эту единицу измерения?", "Удаление данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (var connection = new NpgsqlConnection(_connectionString))
                        {
                            connection.Open();
                            string query = "DELETE FROM unit_of_measurements WHERE id = @Id;";
                            using (var command = new NpgsqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("Id", selectedId);
                                command.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Удаление единицы измерения успешно!");
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

        private void UpdateUnit(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите обновить данные этой единицы измерения?", "Обновление данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(NameTextBox.Text))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    using (var connection = new NpgsqlConnection(_connectionString))
                    {
                        connection.Open();
                        string query = "UPDATE unit_of_measurements SET unit_name = @UnitName WHERE id = @SelectedId;";
                        using (var command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("UnitName", NameTextBox.Text);
                            command.Parameters.AddWithValue("SelectedId", _currentUnitId);
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Данные об единице измерения изменены успешно!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void SaveUnit(string unitName)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                string query = "INSERT INTO unit_of_measurements (unit_name) VALUES (@UnitName);";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("UnitName", unitName);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string accountingUnitName = NameTextBox.Text;
                if (string.IsNullOrEmpty(accountingUnitName))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SaveUnit(accountingUnitName);
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Единица измерения добавлена успешно!");
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
    }
}
