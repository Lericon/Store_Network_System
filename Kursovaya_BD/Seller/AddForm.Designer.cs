namespace Seller
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
            label6 = new Label();
            GenderComboBox = new ComboBox();
            label7 = new Label();
            AgeNumUpDown = new NumericUpDown();
            WorkExpTextBox = new TextBox();
            label8 = new Label();
            storeComboBox = new ComboBox();
            storeBindingSource = new BindingSource(components);
            departmentComboBox = new ComboBox();
            qualificationComboBox = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AgeNumUpDown).BeginInit();
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
            label2.Size = new Size(144, 33);
            label2.TabIndex = 100;
            label2.Text = "Продавцы";
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
            label3.Location = new Point(24, 115);
            label3.Name = "label3";
            label3.Size = new Size(262, 33);
            label3.TabIndex = 2;
            label3.Text = "Фамилия продавца:";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Anchor = AnchorStyles.Top;
            LastNameTextBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LastNameTextBox.Location = new Point(292, 112);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(480, 40);
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
            label4.Location = new Point(85, 162);
            label4.Name = "label4";
            label4.Size = new Size(201, 33);
            label4.TabIndex = 6;
            label4.Text = "Имя продавца:";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Anchor = AnchorStyles.Top;
            FirstNameTextBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FirstNameTextBox.Location = new Point(292, 159);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(480, 40);
            FirstNameTextBox.TabIndex = 1;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 20F);
            label5.Location = new Point(20, 208);
            label5.Name = "label5";
            label5.Size = new Size(266, 33);
            label5.TabIndex = 8;
            label5.Text = "Отчество продавца:";
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.Anchor = AnchorStyles.Top;
            SurnameTextBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SurnameTextBox.Location = new Point(292, 205);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new Size(480, 40);
            SurnameTextBox.TabIndex = 2;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 20F);
            label6.Location = new Point(89, 254);
            label6.Name = "label6";
            label6.Size = new Size(197, 33);
            label6.TabIndex = 10;
            label6.Text = "Пол продавца:";
            // 
            // GenderComboBox
            // 
            GenderComboBox.Anchor = AnchorStyles.Top;
            GenderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GenderComboBox.FlatStyle = FlatStyle.Popup;
            GenderComboBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            GenderComboBox.FormattingEnabled = true;
            GenderComboBox.Items.AddRange(new object[] { "Мужской", "Женский" });
            GenderComboBox.Location = new Point(292, 251);
            GenderComboBox.Name = "GenderComboBox";
            GenderComboBox.Size = new Size(480, 41);
            GenderComboBox.TabIndex = 3;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift", 20F);
            label7.Location = new Point(36, 300);
            label7.Name = "label7";
            label7.Size = new Size(250, 33);
            label7.TabIndex = 12;
            label7.Text = "Возраст продавца:";
            // 
            // AgeNumUpDown
            // 
            AgeNumUpDown.Anchor = AnchorStyles.Top;
            AgeNumUpDown.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AgeNumUpDown.Location = new Point(292, 298);
            AgeNumUpDown.Name = "AgeNumUpDown";
            AgeNumUpDown.Size = new Size(480, 40);
            AgeNumUpDown.TabIndex = 4;
            AgeNumUpDown.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // WorkExpTextBox
            // 
            WorkExpTextBox.Anchor = AnchorStyles.Top;
            WorkExpTextBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WorkExpTextBox.Location = new Point(292, 344);
            WorkExpTextBox.Name = "WorkExpTextBox";
            WorkExpTextBox.Size = new Size(480, 40);
            WorkExpTextBox.TabIndex = 5;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift", 20F);
            label8.Location = new Point(72, 347);
            label8.Name = "label8";
            label8.Size = new Size(214, 33);
            label8.TabIndex = 15;
            label8.Text = "Стаж продавца:";
            // 
            // storeComboBox
            // 
            storeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            storeComboBox.DropDownWidth = 500;
            storeComboBox.FlatStyle = FlatStyle.Popup;
            storeComboBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            storeComboBox.FormattingEnabled = true;
            storeComboBox.Location = new Point(352, 390);
            storeComboBox.MaxDropDownItems = 20;
            storeComboBox.Name = "storeComboBox";
            storeComboBox.Size = new Size(420, 41);
            storeComboBox.TabIndex = 6;
            // 
            // storeBindingSource
            // 
            storeBindingSource.DataSource = typeof(SharedModels.Store);
            // 
            // departmentComboBox
            // 
            departmentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            departmentComboBox.DropDownWidth = 500;
            departmentComboBox.FlatStyle = FlatStyle.Popup;
            departmentComboBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            departmentComboBox.FormattingEnabled = true;
            departmentComboBox.Location = new Point(352, 437);
            departmentComboBox.Name = "departmentComboBox";
            departmentComboBox.Size = new Size(420, 41);
            departmentComboBox.TabIndex = 7;
            // 
            // qualificationComboBox
            // 
            qualificationComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            qualificationComboBox.FlatStyle = FlatStyle.Popup;
            qualificationComboBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            qualificationComboBox.FormattingEnabled = true;
            qualificationComboBox.Location = new Point(352, 484);
            qualificationComboBox.Name = "qualificationComboBox";
            qualificationComboBox.Size = new Size(420, 41);
            qualificationComboBox.TabIndex = 8;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Bahnschrift", 20F);
            label9.Location = new Point(91, 393);
            label9.Name = "label9";
            label9.Size = new Size(255, 33);
            label9.TabIndex = 19;
            label9.Text = "Магазин продавца:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("Bahnschrift", 20F);
            label10.Location = new Point(120, 440);
            label10.Name = "label10";
            label10.Size = new Size(226, 33);
            label10.TabIndex = 20;
            label10.Text = "Отдел продавца:";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new Font("Bahnschrift", 20F);
            label11.Location = new Point(11, 487);
            label11.Name = "label11";
            label11.Size = new Size(335, 33);
            label11.TabIndex = 21;
            label11.Text = "Квалификация продавца:";
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 611);
            ControlBox = false;
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(qualificationComboBox);
            Controls.Add(departmentComboBox);
            Controls.Add(storeComboBox);
            Controls.Add(label8);
            Controls.Add(WorkExpTextBox);
            Controls.Add(AgeNumUpDown);
            Controls.Add(label7);
            Controls.Add(GenderComboBox);
            Controls.Add(label6);
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
            ((System.ComponentModel.ISupportInitialize)AgeNumUpDown).EndInit();
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
        private Label label6;
        private ComboBox GenderComboBox;
        private Label label7;
        private NumericUpDown AgeNumUpDown;
        private TextBox WorkExpTextBox;
        private Label label8;
        private ComboBox storeComboBox;
        private BindingSource storeBindingSource;
        private ComboBox departmentComboBox;
        private ComboBox qualificationComboBox;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}