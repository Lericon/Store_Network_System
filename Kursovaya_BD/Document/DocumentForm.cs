using Npgsql;
using SharedModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Document
{
    public partial class DocumentForm : Form, IConnectionStringConsumer
    {
        private string _connectionString;
        public DocumentForm()
        {
            InitializeComponent();
        }

        public void SetConnectionString(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void SetOpenType(string openType, int? selectedId, bool isAdmin) { }

        private void DoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = richTextBox1.Text;
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    connection.Open();
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        using (var adapter = new NpgsqlDataAdapter(command))
                        {
                            var dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            richTextBox1.Visible = false;
                            DoBtn.Visible = false;
                            CancelBtn.Visible = false;

                            DocumentDGV.Visible = true;
                            DocumentDGV.DataSource = dataTable;
                            DocumentDGV.AutoSize = true;
                            CancelSaveBtn.Visible = true;
                            SaveBtn.Visible = true;
                            CenterToScreen();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка! " + ex.Message);

            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                saveFileDialog.Title = "Сохранить данные в CSV";
                saveFileDialog.FileName = "SQL_Query.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    try
                    {
                        using (var writer = new StreamWriter(filePath, false, Encoding.UTF8))
                        {
                            // Запись заголовков
                            for (int i = 0; i < DocumentDGV.Columns.Count; i++)
                            {
                                writer.Write(DocumentDGV.Columns[i].HeaderText);
                                if (i < DocumentDGV.Columns.Count - 1)
                                    writer.Write(";");
                            }
                            writer.WriteLine();

                            // Запись строк данных
                            foreach (DataGridViewRow row in DocumentDGV.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    for (int i = 0; i < DocumentDGV.Columns.Count; i++)
                                    {
                                        writer.Write(row.Cells[i].Value?.ToString());
                                        if (i < DocumentDGV.Columns.Count - 1)
                                            writer.Write(";");
                                    }
                                    writer.WriteLine();
                                }
                            }
                        }
                        MessageBox.Show($"Данные успешно сохранены в файл:\n{filePath}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CancelSaveBtn.Click += CancelSaveBtn_Click;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void CancelSaveBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            DoBtn.Visible = true;
            CancelBtn.Visible = true;

            DocumentDGV.Visible = false;
            CancelSaveBtn.Visible = false;
            SaveBtn.Visible = false;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
