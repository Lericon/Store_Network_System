using Npgsql;
using SharedModels;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;

namespace Supply
{
    public partial class AddForm : Form, IConnectionStringConsumer
    {
        private string _connectionString;
        public int _currentSupplyId;
        private readonly Dictionary<string, int> _suppliers = [];
        private readonly Dictionary<string, int> _suppliersCombo = [];
        private readonly Dictionary<string, int> _goods = [];
        private readonly Dictionary<string, int> _goodsCombo = [];
        private readonly Dictionary<string, int> _goodsCheckedList = [];
        private readonly Dictionary<string, int> _remainingGoods = [];
        private Dictionary<string, int> goodsInSupply = [];
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
            LoadSuppliersComboBox();
            LoadGoodsComboBox();
        }
        public void SetOpenType(string openType, int? selectedId, bool isAdmin)
        {
            try
            {
                if (openType == "Edit" && selectedId != null)
                {
                    GoodsComboBox.Enabled = false;
                    GoodsInSupplyLB.Enabled = false;
                    using (var connection = new NpgsqlConnection(_connectionString))
                    {
                        connection.Open();
                        string query = "SELECT * FROM supply WHERE id = @SelectedId;";
                        using (var command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("SelectedId", selectedId);
                            using (var reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    _currentSupplyId = reader.GetInt32(0);
                                    DatePicker.Value = reader.GetDateTime(1);
                                    supplierComboBox.SelectedIndex = _suppliersCombo[_suppliers.FirstOrDefault(x => x.Value == reader.GetInt32(2)).Key];
                                }
                            }
                        }
                    }
                    CreateBtn.Text = "Обновить";
                    CreateBtn.Click += UpdateSupply;
                }
                else if (openType == "Delete")
                {
                    if (MessageBox.Show("Вы уверены, что хотите удалить эту поставку?", "Удаление данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (var connection = new NpgsqlConnection(_connectionString))
                        {
                            connection.Open();
                            string query = "DELETE FROM supply WHERE id = @Id;";
                            using (var command = new NpgsqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("Id", selectedId);
                                command.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Удаление поставки успешно!");
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

        private void UpdateSupply(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите обновить данные этой поставки?", "Обновление данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (supplierComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string? supplyName = supplierComboBox.SelectedItem.ToString();
                if (!_suppliers.TryGetValue(supplyName, out var supplierid))
                {
                    MessageBox.Show($"Не существует отдела с названием {supplyName}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    using (var connection = new NpgsqlConnection(_connectionString))
                    {
                        connection.Open();
                        string query = @"
                                UPDATE supply 
                                SET supply_date = @SupplyDate,
                                    supplier_id = @SupplierId,
                                WHERE id = @SelectedId;";
                        using (var command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("SupplyDate", DatePicker.Value);
                            command.Parameters.AddWithValue("SupplierId", supplierid);
                            command.Parameters.AddWithValue("SelectedId", _currentSupplyId);
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Данные о поставке изменены успешно!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private int TakeCountToSupply()
        {
            int countGood = 0;
            GoodCountAddForm form = new GoodCountAddForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                countGood = (int)form.numericUpDown1.Value;
            }
            return countGood;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int index = GoodsComboBox.SelectedIndex;
                if (GoodsComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Пожалуйста, выберите товар.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string goodName = GoodsComboBox.SelectedItem.ToString();
                int countGood = TakeCountToSupply();
                if (countGood > _remainingGoods[goodName])
                {
                    MessageBox.Show("Товара должно хватать на складе.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!goodsInSupply.ContainsKey(goodName))
                {
                    _goodsCheckedList.Add(goodName, index);
                    goodsInSupply.Add(goodName, countGood);
                    GoodsInSupplyLB.Items.Add(goodName + " | Кол-во: " + countGood);
                    _remainingGoods[goodName] += countGood;
                    RemainingNUD.Value = _remainingGoods[goodName];
                }
                else
                {
                    GoodsInSupplyLB.Items.Remove(goodName + " | Кол-во: " + goodsInSupply[goodName]);
                    goodsInSupply[goodName] += countGood;
                    _remainingGoods[goodName] += countGood;
                    GoodsInSupplyLB.Items.Add(goodName + " | Кол-во: " + goodsInSupply[goodName]);
                    RemainingNUD.Value = _remainingGoods[goodName];
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int countGood = TakeCountToSupply();
                string goodName = GoodsComboBox.SelectedItem.ToString();
                if (countGood > goodsInSupply[goodName])
                {
                    MessageBox.Show("Слишком много выбрано.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _remainingGoods[goodName] -= countGood;
                goodsInSupply[goodName] -= countGood;
                
                _goodsCheckedList.Remove(goodName);
                if (goodsInSupply[goodName] == 0)
                {
                    GoodsInSupplyLB.Items.Remove(goodName + " | Кол-во: " + (goodsInSupply[goodName] + countGood));
                    goodsInSupply.Remove(goodName);
                }
                else
                {
                    GoodsInSupplyLB.Items.Remove(goodName + " | Кол-во: " + (goodsInSupply[goodName]+countGood));
                    GoodsInSupplyLB.Items.Add(goodName + " | Кол-во: " + goodsInSupply[goodName]);
                }
                RemainingNUD.Value = _remainingGoods[goodName];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateSupply(int CountGood, int GoodId, int SupplyId)
        {
            try
            {
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = @"
                                INSERT INTO goods_in_supply 
                                (count_good, good_id, supply_id)
                                VALUES
                                (@CountGood, @GoodId, @SupplyId);";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("CountGood", CountGood);
                        command.Parameters.AddWithValue("GoodId", GoodId);
                        command.Parameters.AddWithValue("SupplyId", SupplyId);
                        command.ExecuteNonQuery();
                    }
                }
                //MessageBox.Show("Товары успешно добавлены в поставку!");
                //this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateGood(int GoodId, int RemainingStock)
        {
            try
            {
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = @"
                                UPDATE good 
                                SET remaining_stock = @RemainingStock
                                WHERE id = @SelectedId;";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("RemainingStock", RemainingStock);
                        command.Parameters.AddWithValue("SelectedId", GoodId);
                        command.ExecuteNonQuery();
                    }
                }
                //MessageBox.Show("Товары успешно обновлены!");
                //this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены в выборе товаров?", "Создание поставки", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (GoodsInSupplyLB.Items == null)
                    {
                        MessageBox.Show("Пожалуйста, выберите товары для поставки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (supplierComboBox.SelectedItem == null)
                    {
                        MessageBox.Show("Пожалуйста, заполните все данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int SupplierId = _suppliers[supplierComboBox.SelectedItem.ToString()];
                    DateTime SupplyDate = DatePicker.Value;
                    using (var connection = new NpgsqlConnection(_connectionString))
                    {
                        connection.Open();
                        string query = @"
                                INSERT INTO supply 
                                (supply_date, supplier_id)
                                VALUES
                                (@SupplyDate, @SupplierId)
                                RETURNING id;";
                        using (var command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("SupplyDate", SupplyDate);
                            command.Parameters.AddWithValue("SupplierId", SupplierId);
                            _currentSupplyId = Convert.ToInt32(command.ExecuteScalar());
                        }
                    }
                    for (int i = 0; i < goodsInSupply.Count; i++)
                    {
                        string goodName = GoodsInSupplyLB.Items[i].ToString().Split(' ')[0];
                        int countGood = goodsInSupply[goodName];
                        int goodId = _goods[goodName];
                        CreateSupply(countGood, goodId, _currentSupplyId);
                        UpdateGood(goodId, _remainingGoods[goodName]);
                    }

                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Поставка успешно создана!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                return;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadSuppliersComboBox()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                int i = 0;
                connection.Open();
                var query = @"SELECT id, CONCAT(last_name, ' ', first_name, ' ', surname) FROM supplier;";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var idName = reader.GetInt32(0);
                            var supplierName = reader.GetString(1);

                            supplierComboBox.Items.Add(supplierName);
                            _suppliers.Add(supplierName, idName);
                            _suppliersCombo.Add(supplierName, i);
                            i++;
                        }
                    }
                }
            }
        }
        private void LoadGoodsComboBox()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                int i = 0;
                connection.Open();
                var query = @"SELECT id, name, remaining_stock FROM good ORDER BY id;";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var id = reader.GetInt32(0);
                            var goodName = reader.GetString(1);
                            var remainingStock = reader.GetInt32(2);

                            GoodsComboBox.Items.Add(goodName);
                            RemainingNUD.Value = remainingStock;
                            _goods.Add(goodName, id);
                            _goodsCombo.Add(goodName, i);
                            _remainingGoods.Add(goodName, remainingStock);
                            i++;
                        }
                    }
                }
            }
            GoodsComboBox.SelectedIndex = 0;
        }

        private void GoodsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemainingNUD.Value = _remainingGoods[GoodsComboBox.SelectedItem.ToString()];
        }
    }
}

