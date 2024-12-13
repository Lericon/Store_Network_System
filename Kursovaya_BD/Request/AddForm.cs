using Npgsql;
using SharedModels;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;

namespace Request
{
    public partial class AddForm : Form, IConnectionStringConsumer
    {
        private string _connectionString;
        public int _currentSupplyId;
        private readonly Dictionary<string, int> _stores = [];
        private readonly Dictionary<string, int> _storesCombo = [];
        private readonly Dictionary<string, int> _goods = [];
        private readonly Dictionary<string, int> _goodsCombo = [];
        private readonly Dictionary<string, int> _goodsCheckedList = [];
        private readonly Dictionary<string, int> _remainingGoods = [];
        private Dictionary<string, int> goodsInStore = [];
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
            LoadGoodsComboBox();
        }
        public void SetOpenType(string openType, int? selectedId, bool isAdmin)
        {
            try
            {
                if (openType == "Edit" && selectedId != null)
                {
                    GoodsComboBox.Enabled = false;
                    GoodsInRequestLB.Enabled = false;
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
                                    _currentSupplyId = reader.GetInt32(0);
                                    DatePicker.Value = reader.GetDateTime(1);
                                    storeComboBox.SelectedIndex = _storesCombo[_stores.FirstOrDefault(x => x.Value == reader.GetInt32(2)).Key];
                                }
                            }
                        }
                    }
                    CreateBtn.Text = "Обновить";
                    CreateBtn.Click += UpdateRequest;
                }
                else if (openType == "Delete")
                {
                    if (MessageBox.Show("Вы уверены, что хотите удалить эту заявку?", "Удаление данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (var connection = new NpgsqlConnection(_connectionString))
                        {
                            connection.Open();
                            string query = "DELETE FROM request WHERE id = @Id;";
                            using (var command = new NpgsqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("Id", selectedId);
                                command.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Удаление заявки успешно!");
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

        private void UpdateRequest(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите обновить данные этой заявки?", "Обновление данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (storeComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string? storeName = storeComboBox.SelectedItem.ToString();
                if (!_stores.TryGetValue(storeName, out var storeid))
                {
                    MessageBox.Show($"Не существует отдела с названием {storeName}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    using (var connection = new NpgsqlConnection(_connectionString))
                    {
                        connection.Open();
                        string query = @"
                                UPDATE request 
                                SET request_date = @RequestDate,
                                    store_id = @StoreId,
                                WHERE id = @SelectedId;";
                        using (var command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("RequestDate", DatePicker.Value);
                            command.Parameters.AddWithValue("StoreId", storeid);
                            command.Parameters.AddWithValue("SelectedId", _currentSupplyId);
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Данные о заявке изменены успешно!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private int TakeCountToRequest()
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
                int countGood = TakeCountToRequest();
                if (countGood > _remainingGoods[goodName])
                {
                    MessageBox.Show("Товара должно хватать на складе.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!goodsInStore.ContainsKey(goodName))
                {
                    _goodsCheckedList.Add(goodName, index);
                    goodsInStore.Add(goodName, countGood);
                    GoodsInRequestLB.Items.Add(goodName + " | Кол-во: " + countGood);
                    _remainingGoods[goodName] -= countGood;
                    RemainingNUD.Value = _remainingGoods[goodName];
                }
                else
                {
                    GoodsInRequestLB.Items.Remove(goodName + " | Кол-во: " + goodsInStore[goodName]);
                    goodsInStore[goodName] += countGood;
                    _remainingGoods[goodName] -= countGood;
                    GoodsInRequestLB.Items.Add(goodName + " | Кол-во: " + goodsInStore[goodName]);
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
                int countGood = TakeCountToRequest();
                string goodName = GoodsComboBox.SelectedItem.ToString();
                if (countGood > goodsInStore[goodName])
                {
                    MessageBox.Show("Слишком много выбрано.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _remainingGoods[goodName] += countGood;
                goodsInStore[goodName] -= countGood;
                
                _goodsCheckedList.Remove(goodName);
                if (goodsInStore[goodName] == 0)
                {
                    GoodsInRequestLB.Items.Remove(goodName + " | Кол-во: " + (goodsInStore[goodName] + countGood));
                    goodsInStore.Remove(goodName);
                }
                else
                {
                    GoodsInRequestLB.Items.Remove(goodName + " | Кол-во: " + (goodsInStore[goodName]+countGood));
                    GoodsInRequestLB.Items.Add(goodName + " | Кол-во: " + goodsInStore[goodName]);
                }
                RemainingNUD.Value = _remainingGoods[goodName];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateRequest(int CountGood, int GoodId, int RequestId)
        {
            try
            {
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = @"
                                INSERT INTO goods_in_request 
                                (count_goods, good_id, request_id)
                                VALUES
                                (@CountGood, @GoodId, @RequestId);";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("CountGood", CountGood);
                        command.Parameters.AddWithValue("GoodId", GoodId);
                        command.Parameters.AddWithValue("RequestId", RequestId);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateGoodsRemainingStock(int GoodId, int RemainingStock)
        {
            try
            {
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = @"
                                UPDATE good 
                                SET remaining_stock = @RemainingStock
                                WHERE id = @GoodId";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("RemainingStock", RemainingStock);
                        command.Parameters.AddWithValue("GoodId", GoodId);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateGoodsInStore(int GoodId, int RemainingStock, int StoreId)
        {
            try
            {
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = @"
                                UPDATE goods_in_store 
                                SET count_goods = @RemainingStock
                                WHERE good_id = @GoodId AND store_id = @StoreId;";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("RemainingStock", RemainingStock);
                        command.Parameters.AddWithValue("GoodId", GoodId);
                        command.Parameters.AddWithValue("StoreId", StoreId);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены в выборе товаров?", "Создание заявки", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (GoodsInRequestLB.Items == null)
                    {
                        MessageBox.Show("Пожалуйста, выберите товары для заявки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (storeComboBox.SelectedItem == null)
                    {
                        MessageBox.Show("Пожалуйста, заполните все данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int StoreId = _stores[storeComboBox.SelectedItem.ToString()];
                    DateTime RequestDate = DatePicker.Value;
                    using (var connection = new NpgsqlConnection(_connectionString))
                    {
                        connection.Open();
                        string query = @"
                                INSERT INTO request 
                                (request_date, store_id)
                                VALUES
                                (@RequestDate, @StoreId)
                                RETURNING id;";
                        using (var command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("RequestDate", RequestDate);
                            command.Parameters.AddWithValue("StoreId", StoreId);
                            _currentSupplyId = Convert.ToInt32(command.ExecuteScalar());
                        }
                    }
                    for (int i = 0; i < goodsInStore.Count; i++)
                    {
                        string itemText = GoodsInRequestLB.Items[i].ToString();
                        string goodName = itemText.Substring(0, itemText.IndexOf(" | Кол-во:")).Trim();

                        int countGood = goodsInStore[goodName];
                        int goodId = _goods[goodName];
                        CreateRequest(countGood, goodId, _currentSupplyId);
                        UpdateGoodsInStore(goodId, countGood, StoreId);
                        UpdateGoodsRemainingStock(goodId, _remainingGoods[goodName]);
                    }
                    

                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Заявка успешно создана!");
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

                            storeComboBox.Items.Add(storeName);
                            _stores.Add(storeName, idName);
                            _storesCombo.Add(storeName, i);
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

