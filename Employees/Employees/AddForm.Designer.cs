namespace Employees
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
            AddTopPanel = new Panel();
            label2 = new Label();
            label1 = new Label();
            LoginLabel = new Label();
            PasswordLabel = new Label();
            PasswordCheckLabel = new Label();
            label6 = new Label();
            RoleLabel = new Label();
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            PasswordCheckTextBox = new TextBox();
            RoleTextBox = new TextBox();
            AdminCheckBox = new CheckBox();
            ChangePasswordBtn = new Button();
            AddBtn = new Button();
            BottomPanel = new Panel();
            LevelsLabel = new Label();
            TreeView = new TreeView();
            CancelBtn = new Button();
            AddTopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AddTopPanel
            // 
            AddTopPanel.BackColor = Color.DodgerBlue;
            AddTopPanel.Controls.Add(label2);
            AddTopPanel.Controls.Add(label1);
            AddTopPanel.Dock = DockStyle.Top;
            AddTopPanel.Location = new Point(0, 0);
            AddTopPanel.Name = "AddTopPanel";
            AddTopPanel.Size = new Size(1076, 80);
            AddTopPanel.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 42);
            label2.Name = "label2";
            label2.Size = new Size(247, 25);
            label2.TabIndex = 1;
            label2.Text = "Добавление сотрудника";
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
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginLabel.Location = new Point(10, 92);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(250, 33);
            LoginLabel.TabIndex = 1;
            LoginLabel.Text = "Имя пользователя:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PasswordLabel.Location = new Point(12, 152);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(110, 33);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Пароль:";
            // 
            // PasswordCheckLabel
            // 
            PasswordCheckLabel.AutoSize = true;
            PasswordCheckLabel.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PasswordCheckLabel.Location = new Point(12, 213);
            PasswordCheckLabel.Name = "PasswordCheckLabel";
            PasswordCheckLabel.Size = new Size(278, 33);
            PasswordCheckLabel.TabIndex = 3;
            PasswordCheckLabel.Text = "Подтвердите пароль:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(12, 271);
            label6.Name = "label6";
            label6.Size = new Size(188, 33);
            label6.TabIndex = 4;
            label6.Text = "Введите роль:";
            // 
            // RoleLabel
            // 
            RoleLabel.AutoSize = true;
            RoleLabel.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RoleLabel.Location = new Point(12, 271);
            RoleLabel.Name = "RoleLabel";
            RoleLabel.Size = new Size(188, 33);
            RoleLabel.TabIndex = 5;
            RoleLabel.Text = "Введите роль:";
            // 
            // LoginTextBox
            // 
            LoginTextBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginTextBox.Location = new Point(266, 89);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(300, 40);
            LoginTextBox.TabIndex = 6;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PasswordTextBox.Location = new Point(128, 149);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(438, 40);
            PasswordTextBox.TabIndex = 7;
            // 
            // PasswordCheckTextBox
            // 
            PasswordCheckTextBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PasswordCheckTextBox.Location = new Point(296, 210);
            PasswordCheckTextBox.Name = "PasswordCheckTextBox";
            PasswordCheckTextBox.Size = new Size(270, 40);
            PasswordCheckTextBox.TabIndex = 8;
            // 
            // RoleTextBox
            // 
            RoleTextBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RoleTextBox.Location = new Point(206, 268);
            RoleTextBox.Name = "RoleTextBox";
            RoleTextBox.Size = new Size(360, 40);
            RoleTextBox.TabIndex = 9;
            // 
            // AdminCheckBox
            // 
            AdminCheckBox.AutoSize = true;
            AdminCheckBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AdminCheckBox.Location = new Point(12, 324);
            AdminCheckBox.Name = "AdminCheckBox";
            AdminCheckBox.RightToLeft = RightToLeft.Yes;
            AdminCheckBox.Size = new Size(322, 37);
            AdminCheckBox.TabIndex = 10;
            AdminCheckBox.Text = "Права администратора";
            AdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // ChangePasswordBtn
            // 
            ChangePasswordBtn.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ChangePasswordBtn.Location = new Point(12, 367);
            ChangePasswordBtn.Name = "ChangePasswordBtn";
            ChangePasswordBtn.Size = new Size(260, 50);
            ChangePasswordBtn.TabIndex = 11;
            ChangePasswordBtn.Text = "Сменить пароль";
            ChangePasswordBtn.UseVisualStyleBackColor = true;
            ChangePasswordBtn.Click += ChangePasswordBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddBtn.Location = new Point(12, 494);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(130, 50);
            AddBtn.TabIndex = 12;
            AddBtn.Text = "Создать";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click_1;
            // 
            // BottomPanel
            // 
            BottomPanel.BackColor = Color.DodgerBlue;
            BottomPanel.Dock = DockStyle.Bottom;
            BottomPanel.Location = new Point(0, 550);
            BottomPanel.Name = "BottomPanel";
            BottomPanel.Size = new Size(1076, 46);
            BottomPanel.TabIndex = 13;
            // 
            // LevelsLabel
            // 
            LevelsLabel.AutoSize = true;
            LevelsLabel.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LevelsLabel.Location = new Point(572, 92);
            LevelsLabel.Name = "LevelsLabel";
            LevelsLabel.Size = new Size(221, 33);
            LevelsLabel.TabIndex = 14;
            LevelsLabel.Text = "Уровни доступа:";
            // 
            // TreeView
            // 
            TreeView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TreeView.CheckBoxes = true;
            TreeView.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TreeView.Location = new Point(580, 128);
            TreeView.Name = "TreeView";
            TreeView.Size = new Size(484, 309);
            TreeView.TabIndex = 15;
            // 
            // CancelBtn
            // 
            CancelBtn.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CancelBtn.Location = new Point(934, 494);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(130, 50);
            CancelBtn.TabIndex = 16;
            CancelBtn.Text = "Отмена";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 596);
            Controls.Add(CancelBtn);
            Controls.Add(TreeView);
            Controls.Add(LevelsLabel);
            Controls.Add(BottomPanel);
            Controls.Add(AddBtn);
            Controls.Add(ChangePasswordBtn);
            Controls.Add(AdminCheckBox);
            Controls.Add(RoleTextBox);
            Controls.Add(PasswordCheckTextBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Controls.Add(RoleLabel);
            Controls.Add(label6);
            Controls.Add(PasswordCheckLabel);
            Controls.Add(PasswordLabel);
            Controls.Add(LoginLabel);
            Controls.Add(AddTopPanel);
            MinimumSize = new Size(1092, 635);
            Name = "AddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление сотрудника";
            AddTopPanel.ResumeLayout(false);
            AddTopPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel AddTopPanel;
        private Label label1;
        private Label label2;
        private Label label6;
        public CheckBox AdminCheckBox;
        private Button ChangePasswordBtn;
        private Panel BottomPanel;
        private Label LevelsLabel;
        public TextBox LoginTextBox;
        public TextBox PasswordTextBox;
        public TextBox PasswordCheckTextBox;
        public TextBox RoleTextBox;
        public TreeView TreeView;
        public Label LoginLabel;
        public Label PasswordLabel;
        public Label PasswordCheckLabel;
        public Label RoleLabel;
        public Button AddBtn;
        public Button CancelBtn;
    }
}