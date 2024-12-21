using Npgsql;
using SharedModels;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;
using System.Xml.Linq;

namespace Revenue
{
    public partial class AddForm : Form, IConnectionStringConsumer
    {
        private string _connectionString;
        public int _currentRevenueId;
        private readonly Dictionary<string, int> _sellers = [];
        private readonly Dictionary<string, int> _sellersCombo = [];
        private readonly Dictionary<string, int> _stores = [];
        private readonly Dictionary<string, int> _storesCombo = [];
        private readonly Dictionary<string, int> _goods = [];
        private readonly Dictionary<string, int> _goodsCombo = [];
        private readonly Dictionary<string, int> _goodsId = [];
        private readonly Dictionary<string, int> _goodsPrice = [];
        private readonly Dictionary<string, int> _goodsCheckedList = [];
        private readonly Dictionary<string, int> _remainingGoods = [];
        private readonly List<List<int>> _goodsInStore = [[]];
        private Dictionary<string, int> goodsOnSale = [];
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
            LoadStoresComboBox();
        }
        public void SetOpenType(string openType, int? selectedId, bool isAdmin)
        {
            try
            {
                if (openType == "Edit" && selectedId != null)
                {
                    GoodsComboBox.Enabled = false;
                    GoodsOnSaleLB.Enabled = false;
                    sellerComboBox.Enabled = false;
                    storesComboBox.Enabled = false;
                    using (var connection = new NpgsqlConnection(_connectionString))
                    {
                        connection.Open();
                        string query = "SELECT id, revenue_date FROM revenue WHERE id = @SelectedId;";
                        using (var command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("SelectedId", selectedId);
                            using (var reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    _currentRevenueId = reader.GetInt32(0);
                                    DatePicker.Value = reader.GetDateTime(1);
                                }
                            }
                        }
                    }
                    CreateBtn.Text = "Обновить";
                    CreateBtn.Click += UpdateRevenue;
                }
                else if (openType == "Delete")
                {
                    if (MessageBox.Show("Вы уверены, что хотите удалить эту выручку?", "Удаление данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (var connection = new NpgsqlConnection(_connectionString))
                        {
                            connection.Open();
                            string query = "DELETE FROM revenue WHERE id = @Id;";
                            using (var command = new NpgsqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("Id", selectedId);
                                command.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Удаление выручки успешно!");
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

        private void UpdateRevenue(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите обновить данные этой выручки?", "Обновление данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (var connection = new NpgsqlConnection(_connectionString))
                    {
                        connection.Open();
                        string query = @"
                                UPDATE revenue 
                                SET revenue_date = @RevenueDate
                                WHERE id = @SelectedId;";
                        using (var command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("RevenueDate", DatePicker.Value);
                            command.Parameters.AddWithValue("SelectedId", _currentRevenueId);
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Данные о выручке изменены успешно!");
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
                if (countGood <= 0)
                {
                    MessageBox.Show("Невозможно добавить 0 товаров!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (countGood > _remainingGoods[goodName])
                {
                    MessageBox.Show("Товара должно хватать в магазине.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!goodsOnSale.ContainsKey(goodName))
                {
                    _goodsCheckedList.Add(goodName, index);
                    goodsOnSale.Add(goodName, countGood);
                    GoodsOnSaleLB.Items.Add(goodName + " | Кол-во: " + countGood);
                    _remainingGoods[goodName] -= countGood;
                    RemainingNUD.Value = _remainingGoods[goodName];
                }
                else
                {
                    GoodsOnSaleLB.Items.Remove(goodName + " | Кол-во: " + goodsOnSale[goodName]);
                    goodsOnSale[goodName] += countGood;
                    _remainingGoods[goodName] -= countGood;
                    GoodsOnSaleLB.Items.Add(goodName + " | Кол-во: " + goodsOnSale[goodName]);
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
                if (countGood > goodsOnSale[goodName])
                {
                    MessageBox.Show("Слишком много выбрано.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _remainingGoods[goodName] += countGood;
                goodsOnSale[goodName] -= countGood;

                _goodsCheckedList.Remove(goodName);
                if (goodsOnSale[goodName] == 0)
                {
                    GoodsOnSaleLB.Items.Remove(goodName + " | Кол-во: " + (goodsOnSale[goodName] + countGood));
                    goodsOnSale.Remove(goodName);
                }
                else
                {
                    GoodsOnSaleLB.Items.Remove(goodName + " | Кол-во: " + (goodsOnSale[goodName] + countGood));
                    GoodsOnSaleLB.Items.Add(goodName + " | Кол-во: " + goodsOnSale[goodName]);
                }
                RemainingNUD.Value = _remainingGoods[goodName];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateRevenue(int CountGood, int GoodId, int RevenueId)
        {
            try
            {
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = @"
                                INSERT INTO goods_in_revenue 
                                (good_count, good_id, revenue_id)
                                VALUES
                                (@CountGood, @GoodId, @RevenueId);";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("CountGood", CountGood);
                        command.Parameters.AddWithValue("GoodId", GoodId);
                        command.Parameters.AddWithValue("RevenueId", RevenueId);
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

        private void UpdateGood(int GoodInStoreId, int RemainingStock)
        {
            try
            {
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = @"
                                UPDATE goods_in_store
                                SET count_goods = @RemainingStock
                                WHERE id = @SelectedId;";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("RemainingStock", RemainingStock);
                        command.Parameters.AddWithValue("SelectedId", GoodInStoreId);
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
            if (MessageBox.Show("Вы уверены в выборе товаров?", "Создание выручки", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (GoodsOnSaleLB.Items == null)
                    {
                        MessageBox.Show("Пожалуйста, выберите товары для выручки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (sellerComboBox.SelectedItem == null)
                    {
                        MessageBox.Show("Пожалуйста, заполните все данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int SellerId = _sellers[sellerComboBox.SelectedItem.ToString()];
                    DateTime RevenueDate = DatePicker.Value;
                    int RevenueCount = 0;
                    for (int i = 0; i < goodsOnSale.Count; i++)
                    {
                        string itemText = GoodsOnSaleLB.Items[i].ToString();
                        string goodName = itemText.Substring(0, itemText.IndexOf(" | Кол-во:")).Trim();
                        int countGood = goodsOnSale[goodName];
                        RevenueCount += _goodsPrice[goodName] * countGood;
                    }
                    using (var connection = new NpgsqlConnection(_connectionString))
                    {
                        connection.Open();
                        string query = @"
                                INSERT INTO revenue 
                                (revenue_date, seller_id, revenue_count)
                                VALUES
                                (@RevenueDate, @SellerId, @RevenueCount)
                                RETURNING id;";
                        using (var command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("RevenueDate", RevenueDate);
                            command.Parameters.AddWithValue("SellerId", SellerId);
                            command.Parameters.AddWithValue("RevenueCount", RevenueCount);
                            _currentRevenueId = Convert.ToInt32(command.ExecuteScalar());
                        }
                    }
                    for (int i = 0; i < goodsOnSale.Count; i++)
                    {
                        string itemText = GoodsOnSaleLB.Items[i].ToString();
                        string goodName = itemText.Substring(0, itemText.IndexOf(" | Кол-во:")).Trim();
                        int countGood = goodsOnSale[goodName];
                        int goodInStoreId = _goods[goodName];
                        int GoodId = _goodsId[goodName];
                        CreateRevenue(countGood, GoodId, _currentRevenueId);
                        UpdateGood(goodInStoreId, _remainingGoods[goodName]);
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

        private void LoadSellersComboBox(int store_id)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                int i = 0;
                connection.Open();
                var query = @"SELECT id, CONCAT(last_name, ' ', first_name, ' ', surname) FROM seller WHERE store_id = @store_id;";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@store_id", store_id);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var idName = reader.GetInt32(0);
                            var sellerName = reader.GetString(1);

                            sellerComboBox.Items.Add(sellerName);
                            _sellers.Add(sellerName, idName);
                            _sellersCombo.Add(sellerName, i);
                            i++;
                        }
                    }
                }
            }
            if (sellerComboBox.Items.Count != 0) {
                sellerComboBox.SelectedIndex = 0;
            }
        }

        private void LoadStoresComboBox()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                int i = 0;
                connection.Open();
                var query = @"SELECT id, store_name FROM store;";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var idName = reader.GetInt32(0);
                            var storeName = reader.GetString(1);

                            storesComboBox.Items.Add(storeName);
                            _stores.Add(storeName, idName);
                            _storesCombo.Add(storeName, i);
                            i++;

                        }
                    }
                }
            }
        }


        private void LoadGoodsComboBox(int store_id)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                int i = 0;
                connection.Open();
                var query = @"
                            SELECT gs.id, gs.count_goods, gs.good_id, g.name, g.price
                            FROM goods_in_store gs
                            LEFT JOIN good g ON g.id = gs.good_id
                            WHERE gs.store_id = @store_id
                            ORDER BY gs.good_id;";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@store_id", store_id);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var id = reader.GetInt32(0);
                            var count_goods = reader.GetInt32(1);
                            var goodId = reader.GetInt32(2);
                            var goodName = reader.GetString(3);
                            var goodPrice = reader.GetInt32(4);

                            GoodsComboBox.Items.Add(goodName);
                            _goods.Add(goodName, id);
                            _goodsCombo.Add(goodName, i);
                            _goodsId.Add(goodName, goodId);
                            _goodsPrice.Add(goodName, goodPrice);
                            _remainingGoods.Add(goodName, count_goods);
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

        private void storesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void storesComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _sellers.Clear();
            _sellersCombo.Clear();
            _goods.Clear();
            _goodsCombo.Clear();
            _goodsId.Clear();
            _goodsPrice.Clear();
            _goodsCheckedList.Clear();
            _remainingGoods.Clear();
            _goodsInStore.Clear();
            goodsOnSale.Clear();
            GoodsComboBox.Items.Clear();
            sellerComboBox.Items.Clear();
            GoodsOnSaleLB.Items.Clear();
            
            LoadSellersComboBox(_stores[storesComboBox.Text.ToString()]);
            LoadGoodsComboBox(_stores[storesComboBox.Text.ToString()]);
        }
    }
}

