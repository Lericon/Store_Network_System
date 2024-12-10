namespace Kursovaya_BD.Views
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            LoginTopPanel = new Panel();
            LoginPictureBox = new PictureBox();
            VersionLabel = new Label();
            LoginStoreNameLabel = new Label();
            LoginMainPanel = new Panel();
            LoginBtn = new Button();
            CancelBtn = new Button();
            PasswordTextBox = new TextBox();
            LoginTextBox = new TextBox();
            PasswordLabel = new Label();
            LoginLabel = new Label();
            MainLoginLabel = new Label();
            LoginBottomPanel = new Panel();
            CapsLockLabel = new Label();
            LanguageLabel = new Label();
            npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            LoginTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LoginPictureBox).BeginInit();
            LoginMainPanel.SuspendLayout();
            LoginBottomPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LoginTopPanel
            // 
            LoginTopPanel.BackColor = Color.DodgerBlue;
            LoginTopPanel.Controls.Add(LoginPictureBox);
            LoginTopPanel.Controls.Add(VersionLabel);
            LoginTopPanel.Controls.Add(LoginStoreNameLabel);
            LoginTopPanel.Dock = DockStyle.Top;
            LoginTopPanel.Location = new Point(0, 0);
            LoginTopPanel.Name = "LoginTopPanel";
            LoginTopPanel.Size = new Size(784, 80);
            LoginTopPanel.TabIndex = 0;
            // 
            // LoginPictureBox
            // 
            LoginPictureBox.Image = (Image)resources.GetObject("LoginPictureBox.Image");
            LoginPictureBox.Location = new Point(14, 0);
            LoginPictureBox.Name = "LoginPictureBox";
            LoginPictureBox.Size = new Size(132, 80);
            LoginPictureBox.TabIndex = 3;
            LoginPictureBox.TabStop = false;
            // 
            // VersionLabel
            // 
            VersionLabel.Anchor = AnchorStyles.Right;
            VersionLabel.AutoSize = true;
            VersionLabel.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            VersionLabel.ForeColor = SystemColors.ControlLightLight;
            VersionLabel.Location = new Point(680, 9);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(92, 25);
            VersionLabel.TabIndex = 2;
            VersionLabel.Text = "Версия: ";
            // 
            // LoginStoreNameLabel
            // 
            LoginStoreNameLabel.Anchor = AnchorStyles.Top;
            LoginStoreNameLabel.AutoSize = true;
            LoginStoreNameLabel.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginStoreNameLabel.ForeColor = SystemColors.ControlLightLight;
            LoginStoreNameLabel.Location = new Point(229, 20);
            LoginStoreNameLabel.Name = "LoginStoreNameLabel";
            LoginStoreNameLabel.Size = new Size(326, 33);
            LoginStoreNameLabel.TabIndex = 0;
            LoginStoreNameLabel.Text = "Торговая сеть магазинов";
            LoginStoreNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginMainPanel
            // 
            LoginMainPanel.BackColor = SystemColors.ButtonFace;
            LoginMainPanel.Controls.Add(LoginBtn);
            LoginMainPanel.Controls.Add(CancelBtn);
            LoginMainPanel.Controls.Add(PasswordTextBox);
            LoginMainPanel.Controls.Add(LoginTextBox);
            LoginMainPanel.Controls.Add(PasswordLabel);
            LoginMainPanel.Controls.Add(LoginLabel);
            LoginMainPanel.Controls.Add(MainLoginLabel);
            LoginMainPanel.Dock = DockStyle.Fill;
            LoginMainPanel.Location = new Point(0, 80);
            LoginMainPanel.Name = "LoginMainPanel";
            LoginMainPanel.Size = new Size(784, 320);
            LoginMainPanel.TabIndex = 1;
            // 
            // LoginBtn
            // 
            LoginBtn.Anchor = AnchorStyles.Top;
            LoginBtn.BackColor = Color.DodgerBlue;
            LoginBtn.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginBtn.ForeColor = SystemColors.ControlLightLight;
            LoginBtn.Location = new Point(536, 200);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(125, 50);
            LoginBtn.TabIndex = 5;
            LoginBtn.Text = "Вход";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Anchor = AnchorStyles.Top;
            CancelBtn.BackColor = Color.DodgerBlue;
            CancelBtn.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CancelBtn.ForeColor = SystemColors.ControlLightLight;
            CancelBtn.Location = new Point(125, 200);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(125, 50);
            CancelBtn.TabIndex = 6;
            CancelBtn.Text = "Отмена";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.Top;
            PasswordTextBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PasswordTextBox.Location = new Point(321, 143);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(379, 40);
            PasswordTextBox.TabIndex = 4;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Anchor = AnchorStyles.Top;
            LoginTextBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginTextBox.Location = new Point(321, 81);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(379, 40);
            LoginTextBox.TabIndex = 3;
            // 
            // PasswordLabel
            // 
            PasswordLabel.Anchor = AnchorStyles.Top;
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PasswordLabel.Location = new Point(205, 146);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(110, 33);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Пароль:";
            // 
            // LoginLabel
            // 
            LoginLabel.Anchor = AnchorStyles.Top;
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginLabel.Location = new Point(65, 84);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(250, 33);
            LoginLabel.TabIndex = 1;
            LoginLabel.Text = "Имя пользователя:";
            // 
            // MainLoginLabel
            // 
            MainLoginLabel.Anchor = AnchorStyles.Top;
            MainLoginLabel.AutoSize = true;
            MainLoginLabel.BackColor = Color.DodgerBlue;
            MainLoginLabel.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainLoginLabel.ForeColor = SystemColors.ControlLightLight;
            MainLoginLabel.Location = new Point(291, 20);
            MainLoginLabel.Name = "MainLoginLabel";
            MainLoginLabel.Size = new Size(203, 33);
            MainLoginLabel.TabIndex = 0;
            MainLoginLabel.Text = "Вход в систему";
            MainLoginLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginBottomPanel
            // 
            LoginBottomPanel.BackColor = Color.DodgerBlue;
            LoginBottomPanel.Controls.Add(CapsLockLabel);
            LoginBottomPanel.Controls.Add(LanguageLabel);
            LoginBottomPanel.Dock = DockStyle.Bottom;
            LoginBottomPanel.Location = new Point(0, 400);
            LoginBottomPanel.Name = "LoginBottomPanel";
            LoginBottomPanel.Size = new Size(784, 50);
            LoginBottomPanel.TabIndex = 2;
            // 
            // CapsLockLabel
            // 
            CapsLockLabel.Anchor = AnchorStyles.Right;
            CapsLockLabel.AutoSize = true;
            CapsLockLabel.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CapsLockLabel.ForeColor = SystemColors.ControlLightLight;
            CapsLockLabel.Location = new Point(659, 12);
            CapsLockLabel.Name = "CapsLockLabel";
            CapsLockLabel.Size = new Size(113, 25);
            CapsLockLabel.TabIndex = 1;
            CapsLockLabel.Text = "CapsLock: ";
            // 
            // LanguageLabel
            // 
            LanguageLabel.AutoSize = true;
            LanguageLabel.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LanguageLabel.ForeColor = SystemColors.ControlLightLight;
            LanguageLabel.Location = new Point(12, 12);
            LanguageLabel.Name = "LanguageLabel";
            LanguageLabel.Size = new Size(134, 25);
            LanguageLabel.TabIndex = 0;
            LanguageLabel.Text = "Язык ввода: ";
            // 
            // npgsqlCommandBuilder1
            // 
            npgsqlCommandBuilder1.QuotePrefix = "\"";
            npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 450);
            Controls.Add(LoginMainPanel);
            Controls.Add(LoginTopPanel);
            Controls.Add(LoginBottomPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(800, 489);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            FormClosing += LoginForm_FormClosing;
            InputLanguageChanged += LoginForm_InputLanguageChanged;
            KeyDown += LoginForm_KeyDown;
            LoginTopPanel.ResumeLayout(false);
            LoginTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LoginPictureBox).EndInit();
            LoginMainPanel.ResumeLayout(false);
            LoginMainPanel.PerformLayout();
            LoginBottomPanel.ResumeLayout(false);
            LoginBottomPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel LoginTopPanel;
        private Panel LoginMainPanel;
        private Label LoginStoreNameLabel;
        private Panel LoginBottomPanel;
        private Label MainLoginLabel;
        private Label PasswordLabel;
        private Label LoginLabel;
        private Button LoginBtn;
        private Button CancelBtn;
        private TextBox PasswordTextBox;
        private TextBox LoginTextBox;
        private Label CapsLockLabel;
        private Label LanguageLabel;
        private Label VersionLabel;
        private PictureBox LoginPictureBox;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
    }
}
