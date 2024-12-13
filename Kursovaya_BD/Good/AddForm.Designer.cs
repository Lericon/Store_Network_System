namespace Good
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TopPanel = new Panel();
            label2 = new Label();
            label1 = new Label();
            GoodNameLabel = new Label();
            NameTextBox = new TextBox();
            CreateBtn = new Button();
            CancelBtn = new Button();
            unitComboBox = new ComboBox();
            RemainingStockLabel = new Label();
            PurPriceLabel = new Label();
            RemainingStockNUD = new NumericUpDown();
            PurPriceNUD = new NumericUpDown();
            PriceNUD = new NumericUpDown();
            PriceLabel = new Label();
            UnitLabel = new Label();
            TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RemainingStockNUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PurPriceNUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PriceNUD).BeginInit();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.DodgerBlue;
            TopPanel.Controls.Add(label2);
            TopPanel.Controls.Add(label1);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(784, 80);
            TopPanel.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 42);
            label2.Name = "label2";
            label2.Size = new Size(105, 33);
            label2.TabIndex = 1;
            label2.Text = "Товары";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(326, 33);
            label1.TabIndex = 0;
            label1.Text = "Торговая сеть магазинов";
            // 
            // GoodNameLabel
            // 
            GoodNameLabel.AutoSize = true;
            GoodNameLabel.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            GoodNameLabel.Location = new Point(53, 94);
            GoodNameLabel.Name = "GoodNameLabel";
            GoodNameLabel.Size = new Size(233, 33);
            GoodNameLabel.TabIndex = 2;
            GoodNameLabel.Text = "Название товара:";
            // 
            // NameTextBox
            // 
            NameTextBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameTextBox.Location = new Point(292, 91);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(480, 40);
            NameTextBox.TabIndex = 3;
            // 
            // CreateBtn
            // 
            CreateBtn.BackColor = Color.DodgerBlue;
            CreateBtn.Font = new Font("Bahnschrift", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CreateBtn.Location = new Point(12, 489);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(140, 60);
            CreateBtn.TabIndex = 4;
            CreateBtn.Text = "OK";
            CreateBtn.UseVisualStyleBackColor = false;
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = Color.DodgerBlue;
            CancelBtn.Font = new Font("Bahnschrift", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CancelBtn.Location = new Point(632, 489);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(140, 60);
            CancelBtn.TabIndex = 5;
            CancelBtn.Text = "Отмена";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // unitComboBox
            // 
            unitComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            unitComboBox.FlatStyle = FlatStyle.Popup;
            unitComboBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            unitComboBox.FormattingEnabled = true;
            unitComboBox.Location = new Point(292, 275);
            unitComboBox.Name = "unitComboBox";
            unitComboBox.Size = new Size(480, 41);
            unitComboBox.TabIndex = 6;
            // 
            // RemainingStockLabel
            // 
            RemainingStockLabel.AutoSize = true;
            RemainingStockLabel.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RemainingStockLabel.Location = new Point(37, 139);
            RemainingStockLabel.Name = "RemainingStockLabel";
            RemainingStockLabel.Size = new Size(249, 33);
            RemainingStockLabel.TabIndex = 8;
            RemainingStockLabel.Text = "Остаток на складе:";
            // 
            // PurPriceLabel
            // 
            PurPriceLabel.AutoSize = true;
            PurPriceLabel.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PurPriceLabel.Location = new Point(49, 185);
            PurPriceLabel.Name = "PurPriceLabel";
            PurPriceLabel.Size = new Size(237, 33);
            PurPriceLabel.TabIndex = 9;
            PurPriceLabel.Text = "Закупочная цена:";
            // 
            // RemainingStockNUD
            // 
            RemainingStockNUD.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RemainingStockNUD.Location = new Point(292, 137);
            RemainingStockNUD.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            RemainingStockNUD.Name = "RemainingStockNUD";
            RemainingStockNUD.Size = new Size(480, 40);
            RemainingStockNUD.TabIndex = 10;
            // 
            // PurPriceNUD
            // 
            PurPriceNUD.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PurPriceNUD.Location = new Point(292, 183);
            PurPriceNUD.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            PurPriceNUD.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            PurPriceNUD.Name = "PurPriceNUD";
            PurPriceNUD.Size = new Size(480, 40);
            PurPriceNUD.TabIndex = 11;
            PurPriceNUD.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // PriceNUD
            // 
            PriceNUD.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PriceNUD.Location = new Point(292, 229);
            PriceNUD.Maximum = new decimal(new int[] { 1500, 0, 0, 0 });
            PriceNUD.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            PriceNUD.Name = "PriceNUD";
            PriceNUD.Size = new Size(480, 40);
            PriceNUD.TabIndex = 12;
            PriceNUD.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PriceLabel.Location = new Point(108, 231);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(178, 33);
            PriceLabel.TabIndex = 13;
            PriceLabel.Text = "Цена товара:";
            // 
            // UnitLabel
            // 
            UnitLabel.AutoSize = true;
            UnitLabel.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UnitLabel.Location = new Point(14, 278);
            UnitLabel.Name = "UnitLabel";
            UnitLabel.Size = new Size(272, 33);
            UnitLabel.TabIndex = 14;
            UnitLabel.Text = "Единица измерения:";
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            ControlBox = false;
            Controls.Add(UnitLabel);
            Controls.Add(PriceLabel);
            Controls.Add(PriceNUD);
            Controls.Add(PurPriceNUD);
            Controls.Add(RemainingStockNUD);
            Controls.Add(PurPriceLabel);
            Controls.Add(RemainingStockLabel);
            Controls.Add(unitComboBox);
            Controls.Add(CancelBtn);
            Controls.Add(CreateBtn);
            Controls.Add(NameTextBox);
            Controls.Add(GoodNameLabel);
            Controls.Add(TopPanel);
            Name = "AddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Работа с товарами";
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RemainingStockNUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)PurPriceNUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)PriceNUD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TopPanel;
        private Label label2;
        private Label label1;
        private Label GoodNameLabel;
        private TextBox NameTextBox;
        private Button CreateBtn;
        private Button CancelBtn;
        private ComboBox unitComboBox;
        private ComboBox streetComboBox;
        private Label RemainingStockLabel;
        private Label PurPriceLabel;
        private NumericUpDown RemainingStockNUD;
        private NumericUpDown PurPriceNUD;
        private NumericUpDown PriceNUD;
        private Label PriceLabel;
        private Label UnitLabel;
    }
}