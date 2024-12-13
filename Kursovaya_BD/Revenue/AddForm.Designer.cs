namespace Revenue
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
            CreateBtn = new Button();
            CancelBtn = new Button();
            supplierComboBox = new ComboBox();
            UnitLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            GoodsInSupplyLB = new ListBox();
            label5 = new Label();
            GoodsComboBox = new ComboBox();
            AddBtn = new Button();
            DeleteBtn = new Button();
            RemainingNUD = new NumericUpDown();
            DatePicker = new DateTimePicker();
            TopPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RemainingNUD).BeginInit();
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
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(131, 33);
            label2.TabIndex = 1;
            label2.Text = "Поставка";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(326, 33);
            label1.TabIndex = 0;
            label1.Text = "Торговая сеть магазинов";
            // 
            // CreateBtn
            // 
            CreateBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CreateBtn.BackColor = Color.DodgerBlue;
            CreateBtn.Font = new Font("Bahnschrift", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CreateBtn.Location = new Point(12, 589);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(160, 60);
            CreateBtn.TabIndex = 4;
            CreateBtn.Text = "Создать";
            CreateBtn.UseVisualStyleBackColor = false;
            // 
            // CancelBtn
            // 
            CancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelBtn.BackColor = Color.DodgerBlue;
            CancelBtn.Font = new Font("Bahnschrift", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CancelBtn.Location = new Point(612, 589);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(160, 60);
            CancelBtn.TabIndex = 5;
            CancelBtn.Text = "Отмена";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // supplierComboBox
            // 
            supplierComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            supplierComboBox.FlatStyle = FlatStyle.Popup;
            supplierComboBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            supplierComboBox.FormattingEnabled = true;
            supplierComboBox.Location = new Point(222, 90);
            supplierComboBox.Name = "supplierComboBox";
            supplierComboBox.Size = new Size(550, 41);
            supplierComboBox.TabIndex = 6;
            // 
            // UnitLabel
            // 
            UnitLabel.AutoSize = true;
            UnitLabel.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UnitLabel.Location = new Point(56, 93);
            UnitLabel.Name = "UnitLabel";
            UnitLabel.Size = new Size(160, 33);
            UnitLabel.TabIndex = 14;
            UnitLabel.Text = "Поставщик:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 137);
            label3.Name = "label3";
            label3.Size = new Size(204, 33);
            label3.TabIndex = 15;
            label3.Text = "Дата поставки:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(71, 221);
            label4.Name = "label4";
            label4.Size = new Size(241, 33);
            label4.TabIndex = 18;
            label4.Text = "Товары на складе:";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.AutoSize = true;
            panel2.Controls.Add(GoodsInSupplyLB);
            panel2.Location = new Point(412, 257);
            panel2.Name = "panel2";
            panel2.Size = new Size(360, 250);
            panel2.TabIndex = 20;
            // 
            // GoodsInSupplyLB
            // 
            GoodsInSupplyLB.Dock = DockStyle.Fill;
            GoodsInSupplyLB.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            GoodsInSupplyLB.FormattingEnabled = true;
            GoodsInSupplyLB.ItemHeight = 19;
            GoodsInSupplyLB.Location = new Point(0, 0);
            GoodsInSupplyLB.Name = "GoodsInSupplyLB";
            GoodsInSupplyLB.Size = new Size(360, 250);
            GoodsInSupplyLB.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(465, 221);
            label5.Name = "label5";
            label5.Size = new Size(253, 33);
            label5.TabIndex = 21;
            label5.Text = "Товары в поставке:";
            // 
            // GoodsComboBox
            // 
            GoodsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GoodsComboBox.DropDownWidth = 400;
            GoodsComboBox.FlatStyle = FlatStyle.Popup;
            GoodsComboBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            GoodsComboBox.FormattingEnabled = true;
            GoodsComboBox.Location = new Point(12, 257);
            GoodsComboBox.Name = "GoodsComboBox";
            GoodsComboBox.Size = new Size(240, 41);
            GoodsComboBox.TabIndex = 22;
            GoodsComboBox.SelectedIndexChanged += GoodsComboBox_SelectedIndexChanged;
            // 
            // AddBtn
            // 
            AddBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddBtn.BackColor = Color.DodgerBlue;
            AddBtn.Font = new Font("Bahnschrift", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddBtn.Location = new Point(12, 304);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(170, 60);
            AddBtn.TabIndex = 23;
            AddBtn.Text = "Добавить";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DeleteBtn.BackColor = Color.DodgerBlue;
            DeleteBtn.Font = new Font("Bahnschrift", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DeleteBtn.Location = new Point(202, 304);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(170, 60);
            DeleteBtn.TabIndex = 24;
            DeleteBtn.Text = "Удалить";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // RemainingNUD
            // 
            RemainingNUD.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RemainingNUD.Location = new Point(258, 258);
            RemainingNUD.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            RemainingNUD.Name = "RemainingNUD";
            RemainingNUD.ReadOnly = true;
            RemainingNUD.Size = new Size(120, 40);
            RemainingNUD.TabIndex = 26;
            // 
            // DatePicker
            // 
            DatePicker.CalendarFont = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DatePicker.CustomFormat = "d.M.y";
            DatePicker.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DatePicker.Format = DateTimePickerFormat.Short;
            DatePicker.Location = new Point(222, 137);
            DatePicker.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            DatePicker.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            DatePicker.Name = "DatePicker";
            DatePicker.Size = new Size(550, 40);
            DatePicker.TabIndex = 27;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 661);
            ControlBox = false;
            Controls.Add(DatePicker);
            Controls.Add(RemainingNUD);
            Controls.Add(DeleteBtn);
            Controls.Add(AddBtn);
            Controls.Add(GoodsComboBox);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(UnitLabel);
            Controls.Add(supplierComboBox);
            Controls.Add(CancelBtn);
            Controls.Add(CreateBtn);
            Controls.Add(TopPanel);
            Name = "AddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Управление поставками";
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)RemainingNUD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TopPanel;
        private Label label2;
        private Label label1;
        private Button CreateBtn;
        private Button CancelBtn;
        private ComboBox supplierComboBox;
        private ComboBox streetComboBox;
        private Label UnitLabel;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private ListBox GoodsInSupplyLB;
        private Label label5;
        private ComboBox GoodsComboBox;
        private Button AddBtn;
        private Button DeleteBtn;
        private NumericUpDown RemainingNUD;
        private DateTimePicker DatePicker;
    }
}