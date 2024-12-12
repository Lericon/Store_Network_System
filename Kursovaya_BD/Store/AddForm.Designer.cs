namespace Store
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
            StoreNameLabel = new Label();
            NameTextBox = new TextBox();
            CreateBtn = new Button();
            CancelBtn = new Button();
            cityComboBox = new ComboBox();
            streetComboBox = new ComboBox();
            CityLabel = new Label();
            StreetLabel = new Label();
            TopPanel.SuspendLayout();
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
            label2.Size = new Size(139, 33);
            label2.TabIndex = 1;
            label2.Text = "Магазины";
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
            // StoreNameLabel
            // 
            StoreNameLabel.AutoSize = true;
            StoreNameLabel.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            StoreNameLabel.Location = new Point(24, 94);
            StoreNameLabel.Name = "StoreNameLabel";
            StoreNameLabel.Size = new Size(262, 33);
            StoreNameLabel.TabIndex = 2;
            StoreNameLabel.Text = "Название магазина:";
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
            CreateBtn.Location = new Point(12, 289);
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
            CancelBtn.Location = new Point(632, 289);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(140, 60);
            CancelBtn.TabIndex = 5;
            CancelBtn.Text = "Отмена";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // cityComboBox
            // 
            cityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cityComboBox.FlatStyle = FlatStyle.Popup;
            cityComboBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cityComboBox.FormattingEnabled = true;
            cityComboBox.Location = new Point(292, 137);
            cityComboBox.Name = "cityComboBox";
            cityComboBox.Size = new Size(480, 41);
            cityComboBox.TabIndex = 6;
            // 
            // streetComboBox
            // 
            streetComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            streetComboBox.FlatStyle = FlatStyle.Popup;
            streetComboBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            streetComboBox.FormattingEnabled = true;
            streetComboBox.Location = new Point(292, 184);
            streetComboBox.Name = "streetComboBox";
            streetComboBox.Size = new Size(480, 41);
            streetComboBox.TabIndex = 7;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CityLabel.Location = new Point(53, 140);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(233, 33);
            CityLabel.TabIndex = 8;
            CityLabel.Text = "Название города:";
            // 
            // StreetLabel
            // 
            StreetLabel.AutoSize = true;
            StreetLabel.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            StreetLabel.Location = new Point(61, 187);
            StreetLabel.Name = "StreetLabel";
            StreetLabel.Size = new Size(225, 33);
            StreetLabel.TabIndex = 9;
            StreetLabel.Text = "Название улицы:";
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 361);
            ControlBox = false;
            Controls.Add(StreetLabel);
            Controls.Add(CityLabel);
            Controls.Add(streetComboBox);
            Controls.Add(cityComboBox);
            Controls.Add(CancelBtn);
            Controls.Add(CreateBtn);
            Controls.Add(NameTextBox);
            Controls.Add(StoreNameLabel);
            Controls.Add(TopPanel);
            Name = "AddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Магазины";
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TopPanel;
        private Label label2;
        private Label label1;
        private Label StoreNameLabel;
        private TextBox NameTextBox;
        private Button CreateBtn;
        private Button CancelBtn;
        private ComboBox cityComboBox;
        private ComboBox streetComboBox;
        private Label CityLabel;
        private Label StreetLabel;
    }
}