namespace Supplier
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
            components = new System.ComponentModel.Container();
            TopPanel = new Panel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            LastNameTextBox = new TextBox();
            CreateBtn = new Button();
            CancelBtn = new Button();
            label4 = new Label();
            FirstNameTextBox = new TextBox();
            label5 = new Label();
            SurnameTextBox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            bankComboBox = new ComboBox();
            storeBindingSource = new BindingSource(components);
            cityComboBox = new ComboBox();
            streetComboBox = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            PhoneNumberTextBox = new TextBox();
            BankAccountTextBox = new TextBox();
            label6 = new Label();
            TINTextBox = new TextBox();
            TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)storeBindingSource).BeginInit();
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
            TopPanel.Size = new Size(784, 87);
            TopPanel.TabIndex = 100;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 42);
            label2.Name = "label2";
            label2.Size = new Size(169, 33);
            label2.TabIndex = 100;
            label2.Text = "Поставщики";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(326, 33);
            label1.TabIndex = 100;
            label1.Text = "Торговая сеть магазинов";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 20F);
            label3.Location = new Point(15, 116);
            label3.Name = "label3";
            label3.Size = new Size(291, 33);
            label3.TabIndex = 2;
            label3.Text = "Фамилия поставщика:";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Anchor = AnchorStyles.Top;
            LastNameTextBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LastNameTextBox.Location = new Point(312, 113);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(460, 40);
            LastNameTextBox.TabIndex = 0;
            // 
            // CreateBtn
            // 
            CreateBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CreateBtn.BackColor = Color.DodgerBlue;
            CreateBtn.Font = new Font("Bahnschrift", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CreateBtn.Location = new Point(12, 532);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(140, 60);
            CreateBtn.TabIndex = 9;
            CreateBtn.Text = "OK";
            CreateBtn.UseVisualStyleBackColor = false;
            // 
            // CancelBtn
            // 
            CancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelBtn.BackColor = Color.DodgerBlue;
            CancelBtn.Font = new Font("Bahnschrift", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CancelBtn.Location = new Point(632, 532);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(140, 60);
            CancelBtn.TabIndex = 10;
            CancelBtn.Text = "Отмена";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 20F);
            label4.Location = new Point(76, 162);
            label4.Name = "label4";
            label4.Size = new Size(230, 33);
            label4.TabIndex = 6;
            label4.Text = "Имя поставщика:";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Anchor = AnchorStyles.Top;
            FirstNameTextBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FirstNameTextBox.Location = new Point(312, 159);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(460, 40);
            FirstNameTextBox.TabIndex = 1;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 20F);
            label5.Location = new Point(11, 208);
            label5.Name = "label5";
            label5.Size = new Size(295, 33);
            label5.TabIndex = 8;
            label5.Text = "Отчество поставщика:";
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.Anchor = AnchorStyles.Top;
            SurnameTextBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SurnameTextBox.Location = new Point(312, 205);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new Size(460, 40);
            SurnameTextBox.TabIndex = 2;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift", 20F);
            label7.Location = new Point(23, 256);
            label7.Name = "label7";
            label7.Size = new Size(283, 33);
            label7.TabIndex = 12;
            label7.Text = "Телефон поставщика:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift", 20F);
            label8.Location = new Point(72, 348);
            label8.Name = "label8";
            label8.Size = new Size(234, 33);
            label8.TabIndex = 15;
            label8.Text = "ИНН поставщика:";
            // 
            // bankComboBox
            // 
            bankComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            bankComboBox.DropDownWidth = 500;
            bankComboBox.FlatStyle = FlatStyle.Popup;
            bankComboBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            bankComboBox.FormattingEnabled = true;
            bankComboBox.Location = new Point(312, 391);
            bankComboBox.MaxDropDownItems = 20;
            bankComboBox.Name = "bankComboBox";
            bankComboBox.Size = new Size(460, 41);
            bankComboBox.TabIndex = 6;
            // 
            // storeBindingSource
            // 
            storeBindingSource.DataSource = typeof(SharedModels.Store);
            // 
            // cityComboBox
            // 
            cityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cityComboBox.DropDownWidth = 500;
            cityComboBox.FlatStyle = FlatStyle.Popup;
            cityComboBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cityComboBox.FormattingEnabled = true;
            cityComboBox.Location = new Point(312, 438);
            cityComboBox.Name = "cityComboBox";
            cityComboBox.Size = new Size(460, 41);
            cityComboBox.TabIndex = 7;
            // 
            // streetComboBox
            // 
            streetComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            streetComboBox.FlatStyle = FlatStyle.Popup;
            streetComboBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            streetComboBox.FormattingEnabled = true;
            streetComboBox.Location = new Point(312, 485);
            streetComboBox.Name = "streetComboBox";
            streetComboBox.Size = new Size(460, 41);
            streetComboBox.TabIndex = 8;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Bahnschrift", 20F);
            label9.Location = new Point(66, 394);
            label9.Name = "label9";
            label9.Size = new Size(240, 33);
            label9.TabIndex = 19;
            label9.Text = "Банк поставщика:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("Bahnschrift", 20F);
            label10.Location = new Point(54, 441);
            label10.Name = "label10";
            label10.Size = new Size(252, 33);
            label10.TabIndex = 20;
            label10.Text = "Город поставщика:";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new Font("Bahnschrift", 20F);
            label11.Location = new Point(50, 488);
            label11.Name = "label11";
            label11.Size = new Size(256, 33);
            label11.TabIndex = 21;
            label11.Text = "Улица поставщика:";
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Anchor = AnchorStyles.Top;
            PhoneNumberTextBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PhoneNumberTextBox.Location = new Point(312, 253);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(460, 40);
            PhoneNumberTextBox.TabIndex = 101;
            // 
            // BankAccountTextBox
            // 
            BankAccountTextBox.Anchor = AnchorStyles.Top;
            BankAccountTextBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BankAccountTextBox.Location = new Point(312, 299);
            BankAccountTextBox.Name = "BankAccountTextBox";
            BankAccountTextBox.Size = new Size(460, 40);
            BankAccountTextBox.TabIndex = 102;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 20F);
            label6.Location = new Point(75, 302);
            label6.Name = "label6";
            label6.Size = new Size(231, 33);
            label6.TabIndex = 103;
            label6.Text = "Банковский счёт:";
            // 
            // TINTextBox
            // 
            TINTextBox.Anchor = AnchorStyles.Top;
            TINTextBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TINTextBox.Location = new Point(312, 345);
            TINTextBox.Name = "TINTextBox";
            TINTextBox.Size = new Size(460, 40);
            TINTextBox.TabIndex = 104;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 611);
            ControlBox = false;
            Controls.Add(TINTextBox);
            Controls.Add(label6);
            Controls.Add(BankAccountTextBox);
            Controls.Add(PhoneNumberTextBox);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(streetComboBox);
            Controls.Add(cityComboBox);
            Controls.Add(bankComboBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(SurnameTextBox);
            Controls.Add(label5);
            Controls.Add(FirstNameTextBox);
            Controls.Add(label4);
            Controls.Add(CancelBtn);
            Controls.Add(CreateBtn);
            Controls.Add(LastNameTextBox);
            Controls.Add(label3);
            Controls.Add(TopPanel);
            Name = "AddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Продавцы";
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)storeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TopPanel;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox LastNameTextBox;
        private Button CreateBtn;
        private Button CancelBtn;
        private Label label4;
        private TextBox FirstNameTextBox;
        private Label label5;
        private TextBox SurnameTextBox;
        private ComboBox GenderComboBox;
        private Label label7;
        private NumericUpDown AgeNumUpDown;
        private TextBox WorkExpTextBox;
        private Label label8;
        private ComboBox bankComboBox;
        private BindingSource storeBindingSource;
        private ComboBox cityComboBox;
        private ComboBox streetComboBox;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox PhoneNumberTextBox;
        private TextBox BankAccountTextBox;
        private Label label6;
        private TextBox TINTextBox;
    }
}