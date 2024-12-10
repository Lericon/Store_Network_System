namespace Employees
{
    partial class ChangePasswordForm
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
            ChangePasswordLabel = new Label();
            MainLabel = new Label();
            PasswordLabel = new Label();
            PasswordCheckLabel = new Label();
            PasswordTextBox = new TextBox();
            PasswordCheckTextBox = new TextBox();
            ChangeBtn = new Button();
            CancelBtn = new Button();
            TopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.DodgerBlue;
            TopPanel.Controls.Add(ChangePasswordLabel);
            TopPanel.Controls.Add(MainLabel);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(604, 80);
            TopPanel.TabIndex = 0;
            // 
            // ChangePasswordLabel
            // 
            ChangePasswordLabel.AutoSize = true;
            ChangePasswordLabel.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ChangePasswordLabel.Location = new Point(12, 42);
            ChangePasswordLabel.Name = "ChangePasswordLabel";
            ChangePasswordLabel.Size = new Size(145, 25);
            ChangePasswordLabel.TabIndex = 1;
            ChangePasswordLabel.Text = "Смена пароля";
            // 
            // MainLabel
            // 
            MainLabel.AutoSize = true;
            MainLabel.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainLabel.Location = new Point(12, 9);
            MainLabel.Name = "MainLabel";
            MainLabel.Size = new Size(326, 33);
            MainLabel.TabIndex = 0;
            MainLabel.Text = "Торговая сеть магазинов";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PasswordLabel.Location = new Point(28, 98);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(197, 33);
            PasswordLabel.TabIndex = 1;
            PasswordLabel.Text = "Новый пароль:";
            // 
            // PasswordCheckLabel
            // 
            PasswordCheckLabel.AutoSize = true;
            PasswordCheckLabel.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PasswordCheckLabel.Location = new Point(28, 159);
            PasswordCheckLabel.Name = "PasswordCheckLabel";
            PasswordCheckLabel.Size = new Size(278, 33);
            PasswordCheckLabel.TabIndex = 2;
            PasswordCheckLabel.Text = "Подтвердите пароль:";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PasswordTextBox.Location = new Point(231, 95);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(351, 40);
            PasswordTextBox.TabIndex = 3;
            // 
            // PasswordCheckTextBox
            // 
            PasswordCheckTextBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PasswordCheckTextBox.Location = new Point(312, 156);
            PasswordCheckTextBox.Name = "PasswordCheckTextBox";
            PasswordCheckTextBox.Size = new Size(270, 40);
            PasswordCheckTextBox.TabIndex = 4;
            // 
            // ChangeBtn
            // 
            ChangeBtn.Anchor = AnchorStyles.Bottom;
            ChangeBtn.BackColor = Color.DodgerBlue;
            ChangeBtn.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ChangeBtn.ForeColor = SystemColors.ControlText;
            ChangeBtn.Location = new Point(12, 217);
            ChangeBtn.Name = "ChangeBtn";
            ChangeBtn.Size = new Size(130, 50);
            ChangeBtn.TabIndex = 5;
            ChangeBtn.Text = "Сменить";
            ChangeBtn.UseVisualStyleBackColor = false;
            ChangeBtn.Click += ChangeBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Anchor = AnchorStyles.Bottom;
            CancelBtn.BackColor = Color.DodgerBlue;
            CancelBtn.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CancelBtn.ForeColor = SystemColors.ControlText;
            CancelBtn.Location = new Point(462, 217);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(130, 50);
            CancelBtn.TabIndex = 6;
            CancelBtn.Text = "Отмена";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 279);
            Controls.Add(CancelBtn);
            Controls.Add(ChangeBtn);
            Controls.Add(PasswordCheckTextBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(PasswordCheckLabel);
            Controls.Add(PasswordLabel);
            Controls.Add(TopPanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ChangePasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Смена пароля";
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TopPanel;
        private Label ChangePasswordLabel;
        private Label MainLabel;
        private Label PasswordLabel;
        private Label PasswordCheckLabel;
        public TextBox PasswordTextBox;
        public TextBox PasswordCheckTextBox;
        private Button ChangeBtn;
        private Button CancelBtn;
    }
}