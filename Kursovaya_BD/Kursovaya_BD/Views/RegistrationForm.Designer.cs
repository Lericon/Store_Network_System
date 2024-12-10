namespace Kursovaya_BD.Views
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            RegistrationTopPanel = new Panel();
            VersionLabel = new Label();
            RegistrationPictureBox = new PictureBox();
            RegistrationStoreNameLabel = new Label();
            RegistrationMainPanel = new Panel();
            RegistrationBtn = new Button();
            CancelBtn = new Button();
            RepeatPasswordTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginTextBox = new TextBox();
            RepeatPasswordLabel = new Label();
            PasswordLabel = new Label();
            LoginLabel = new Label();
            RegustrationMainLabel = new Label();
            RegistrationBottomPanel = new Panel();
            CapsLockLabel = new Label();
            LanguageLabel = new Label();
            RegistrationTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RegistrationPictureBox).BeginInit();
            RegistrationMainPanel.SuspendLayout();
            RegistrationBottomPanel.SuspendLayout();
            SuspendLayout();
            // 
            // RegistrationTopPanel
            // 
            RegistrationTopPanel.BackColor = Color.DodgerBlue;
            RegistrationTopPanel.Controls.Add(VersionLabel);
            RegistrationTopPanel.Controls.Add(RegistrationPictureBox);
            RegistrationTopPanel.Controls.Add(RegistrationStoreNameLabel);
            RegistrationTopPanel.Dock = DockStyle.Top;
            RegistrationTopPanel.Location = new Point(0, 0);
            RegistrationTopPanel.Name = "RegistrationTopPanel";
            RegistrationTopPanel.Size = new Size(784, 80);
            RegistrationTopPanel.TabIndex = 0;
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
            VersionLabel.TabIndex = 5;
            VersionLabel.Text = "Версия: ";
            // 
            // RegistrationPictureBox
            // 
            RegistrationPictureBox.Image = (Image)resources.GetObject("RegistrationPictureBox.Image");
            RegistrationPictureBox.Location = new Point(14, 0);
            RegistrationPictureBox.Name = "RegistrationPictureBox";
            RegistrationPictureBox.Size = new Size(132, 80);
            RegistrationPictureBox.TabIndex = 4;
            RegistrationPictureBox.TabStop = false;
            // 
            // RegistrationStoreNameLabel
            // 
            RegistrationStoreNameLabel.Anchor = AnchorStyles.Top;
            RegistrationStoreNameLabel.AutoSize = true;
            RegistrationStoreNameLabel.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RegistrationStoreNameLabel.ForeColor = SystemColors.ControlLightLight;
            RegistrationStoreNameLabel.Location = new Point(229, 20);
            RegistrationStoreNameLabel.Name = "RegistrationStoreNameLabel";
            RegistrationStoreNameLabel.Size = new Size(326, 33);
            RegistrationStoreNameLabel.TabIndex = 1;
            RegistrationStoreNameLabel.Text = "Торговая сеть магазинов";
            RegistrationStoreNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegistrationMainPanel
            // 
            RegistrationMainPanel.BackColor = SystemColors.ButtonFace;
            RegistrationMainPanel.Controls.Add(RegistrationBtn);
            RegistrationMainPanel.Controls.Add(CancelBtn);
            RegistrationMainPanel.Controls.Add(RepeatPasswordTextBox);
            RegistrationMainPanel.Controls.Add(PasswordTextBox);
            RegistrationMainPanel.Controls.Add(LoginTextBox);
            RegistrationMainPanel.Controls.Add(RepeatPasswordLabel);
            RegistrationMainPanel.Controls.Add(PasswordLabel);
            RegistrationMainPanel.Controls.Add(LoginLabel);
            RegistrationMainPanel.Controls.Add(RegustrationMainLabel);
            RegistrationMainPanel.Dock = DockStyle.Fill;
            RegistrationMainPanel.Location = new Point(0, 80);
            RegistrationMainPanel.Name = "RegistrationMainPanel";
            RegistrationMainPanel.Size = new Size(784, 320);
            RegistrationMainPanel.TabIndex = 1;
            // 
            // RegistrationBtn
            // 
            RegistrationBtn.Anchor = AnchorStyles.Top;
            RegistrationBtn.BackColor = Color.DodgerBlue;
            RegistrationBtn.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RegistrationBtn.ForeColor = SystemColors.ControlLightLight;
            RegistrationBtn.Location = new Point(510, 254);
            RegistrationBtn.Name = "RegistrationBtn";
            RegistrationBtn.Size = new Size(190, 50);
            RegistrationBtn.TabIndex = 9;
            RegistrationBtn.Text = "Регистрация";
            RegistrationBtn.UseVisualStyleBackColor = false;
            RegistrationBtn.Click += RegistrationBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Anchor = AnchorStyles.Top;
            CancelBtn.BackColor = Color.DodgerBlue;
            CancelBtn.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CancelBtn.ForeColor = SystemColors.ControlLightLight;
            CancelBtn.Location = new Point(65, 254);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(125, 50);
            CancelBtn.TabIndex = 8;
            CancelBtn.Text = "Отмена";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // RepeatPasswordTextBox
            // 
            RepeatPasswordTextBox.Anchor = AnchorStyles.Top;
            RepeatPasswordTextBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RepeatPasswordTextBox.Location = new Point(321, 205);
            RepeatPasswordTextBox.Name = "RepeatPasswordTextBox";
            RepeatPasswordTextBox.PasswordChar = '*';
            RepeatPasswordTextBox.Size = new Size(379, 40);
            RepeatPasswordTextBox.TabIndex = 7;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.Top;
            PasswordTextBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PasswordTextBox.Location = new Point(321, 143);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(379, 40);
            PasswordTextBox.TabIndex = 6;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Anchor = AnchorStyles.Top;
            LoginTextBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginTextBox.Location = new Point(321, 81);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(379, 40);
            LoginTextBox.TabIndex = 5;
            // 
            // RepeatPasswordLabel
            // 
            RepeatPasswordLabel.Anchor = AnchorStyles.Top;
            RepeatPasswordLabel.AutoSize = true;
            RepeatPasswordLabel.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RepeatPasswordLabel.Location = new Point(69, 208);
            RepeatPasswordLabel.Name = "RepeatPasswordLabel";
            RepeatPasswordLabel.Size = new Size(246, 33);
            RepeatPasswordLabel.TabIndex = 4;
            RepeatPasswordLabel.Text = "Повторите пароль:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.Anchor = AnchorStyles.Top;
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PasswordLabel.Location = new Point(205, 146);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(110, 33);
            PasswordLabel.TabIndex = 3;
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
            LoginLabel.TabIndex = 2;
            LoginLabel.Text = "Имя пользователя:";
            // 
            // RegustrationMainLabel
            // 
            RegustrationMainLabel.Anchor = AnchorStyles.Top;
            RegustrationMainLabel.AutoSize = true;
            RegustrationMainLabel.BackColor = Color.DodgerBlue;
            RegustrationMainLabel.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RegustrationMainLabel.ForeColor = SystemColors.ControlLightLight;
            RegustrationMainLabel.Location = new Point(242, 28);
            RegustrationMainLabel.Name = "RegustrationMainLabel";
            RegustrationMainLabel.Size = new Size(300, 33);
            RegustrationMainLabel.TabIndex = 1;
            RegustrationMainLabel.Text = "Регистрация в систему";
            RegustrationMainLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegistrationBottomPanel
            // 
            RegistrationBottomPanel.BackColor = Color.DodgerBlue;
            RegistrationBottomPanel.Controls.Add(CapsLockLabel);
            RegistrationBottomPanel.Controls.Add(LanguageLabel);
            RegistrationBottomPanel.Dock = DockStyle.Bottom;
            RegistrationBottomPanel.Location = new Point(0, 400);
            RegistrationBottomPanel.Name = "RegistrationBottomPanel";
            RegistrationBottomPanel.Size = new Size(784, 50);
            RegistrationBottomPanel.TabIndex = 2;
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
            CapsLockLabel.TabIndex = 2;
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
            LanguageLabel.TabIndex = 1;
            LanguageLabel.Text = "Язык ввода: ";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 450);
            Controls.Add(RegistrationMainPanel);
            Controls.Add(RegistrationTopPanel);
            Controls.Add(RegistrationBottomPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(800, 489);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            FormClosing += RegistrationForm_FormClosing;
            InputLanguageChanged += RegistrationForm_InputLanguageChanged;
            KeyDown += RegistrationForm_KeyDown;
            RegistrationTopPanel.ResumeLayout(false);
            RegistrationTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RegistrationPictureBox).EndInit();
            RegistrationMainPanel.ResumeLayout(false);
            RegistrationMainPanel.PerformLayout();
            RegistrationBottomPanel.ResumeLayout(false);
            RegistrationBottomPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel RegistrationTopPanel;
        private Label RegistrationStoreNameLabel;
        private PictureBox RegistrationPictureBox;
        private Panel RegistrationMainPanel;
        private Panel RegistrationBottomPanel;
        private Label RegustrationMainLabel;
        private Label LoginLabel;
        private Label RepeatPasswordLabel;
        private Label PasswordLabel;
        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private TextBox RepeatPasswordTextBox;
        private Button CancelBtn;
        private Button RegistrationBtn;
        private Label LanguageLabel;
        private Label CapsLockLabel;
        private Label VersionLabel;
    }
}