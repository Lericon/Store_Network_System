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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            LoginPictureBox = new PictureBox();
            VersionLabel = new Label();
            LoginStoreNameLabel = new Label();
            LanguageLabel = new Label();
            npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            LoginMainPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            LoginBtn = new Guna.UI2.WinForms.Guna2Button();
            CancelBtn = new Guna.UI2.WinForms.Guna2Button();
            PasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            LoginTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            LoginBottomPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            LoginTopPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            ((System.ComponentModel.ISupportInitialize)LoginPictureBox).BeginInit();
            LoginMainPanel.SuspendLayout();
            LoginBottomPanel.SuspendLayout();
            LoginTopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LoginPictureBox
            // 
            LoginPictureBox.BackColor = Color.Transparent;
            LoginPictureBox.Image = (Image)resources.GetObject("LoginPictureBox.Image");
            LoginPictureBox.Location = new Point(14, -3);
            LoginPictureBox.Name = "LoginPictureBox";
            LoginPictureBox.Size = new Size(132, 80);
            LoginPictureBox.TabIndex = 3;
            LoginPictureBox.TabStop = false;
            // 
            // VersionLabel
            // 
            VersionLabel.Anchor = AnchorStyles.Right;
            VersionLabel.AutoSize = true;
            VersionLabel.BackColor = Color.Transparent;
            VersionLabel.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            VersionLabel.ForeColor = SystemColors.ControlLightLight;
            VersionLabel.Location = new Point(496, 9);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(92, 25);
            VersionLabel.TabIndex = 2;
            VersionLabel.Text = "Версия: ";
            // 
            // LoginStoreNameLabel
            // 
            LoginStoreNameLabel.Anchor = AnchorStyles.Top;
            LoginStoreNameLabel.AutoSize = true;
            LoginStoreNameLabel.BackColor = Color.Transparent;
            LoginStoreNameLabel.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginStoreNameLabel.ForeColor = SystemColors.ControlLightLight;
            LoginStoreNameLabel.Location = new Point(152, 44);
            LoginStoreNameLabel.Name = "LoginStoreNameLabel";
            LoginStoreNameLabel.Size = new Size(326, 33);
            LoginStoreNameLabel.TabIndex = 0;
            LoginStoreNameLabel.Text = "Торговая сеть магазинов";
            LoginStoreNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LanguageLabel
            // 
            LanguageLabel.AutoSize = true;
            LanguageLabel.BackColor = Color.Transparent;
            LanguageLabel.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LanguageLabel.ForeColor = SystemColors.ControlLightLight;
            LanguageLabel.Location = new Point(12, 16);
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
            // LoginMainPanel
            // 
            LoginMainPanel.Controls.Add(LoginBtn);
            LoginMainPanel.Controls.Add(CancelBtn);
            LoginMainPanel.Controls.Add(PasswordTextBox);
            LoginMainPanel.Controls.Add(LoginTextBox);
            LoginMainPanel.Controls.Add(LoginBottomPanel);
            LoginMainPanel.Controls.Add(LoginTopPanel);
            LoginMainPanel.CustomizableEdges = customizableEdges13;
            LoginMainPanel.Dock = DockStyle.Fill;
            LoginMainPanel.FillColor = Color.DodgerBlue;
            LoginMainPanel.FillColor2 = Color.DodgerBlue;
            LoginMainPanel.FillColor3 = Color.DodgerBlue;
            LoginMainPanel.FillColor4 = Color.DodgerBlue;
            LoginMainPanel.Location = new Point(0, 0);
            LoginMainPanel.Name = "LoginMainPanel";
            LoginMainPanel.ShadowDecoration.CustomizableEdges = customizableEdges14;
            LoginMainPanel.Size = new Size(600, 420);
            LoginMainPanel.TabIndex = 7;
            // 
            // LoginBtn
            // 
            LoginBtn.AutoRoundedCorners = true;
            LoginBtn.BackColor = Color.Transparent;
            LoginBtn.BorderColor = Color.Silver;
            LoginBtn.BorderRadius = 24;
            LoginBtn.BorderThickness = 2;
            LoginBtn.CustomizableEdges = customizableEdges1;
            LoginBtn.DisabledState.BorderColor = Color.DarkGray;
            LoginBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            LoginBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            LoginBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            LoginBtn.FillColor = Color.Transparent;
            LoginBtn.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(370, 263);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            LoginBtn.Size = new Size(130, 50);
            LoginBtn.TabIndex = 12;
            LoginBtn.Text = "Вход";
            LoginBtn.Click += LoginBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.AutoRoundedCorners = true;
            CancelBtn.BackColor = Color.Transparent;
            CancelBtn.BorderColor = Color.Silver;
            CancelBtn.BorderRadius = 24;
            CancelBtn.BorderThickness = 2;
            CancelBtn.CustomizableEdges = customizableEdges3;
            CancelBtn.DisabledState.BorderColor = Color.DarkGray;
            CancelBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            CancelBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            CancelBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            CancelBtn.FillColor = Color.Transparent;
            CancelBtn.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CancelBtn.ForeColor = Color.White;
            CancelBtn.Location = new Point(100, 263);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            CancelBtn.Size = new Size(130, 50);
            CancelBtn.TabIndex = 11;
            CancelBtn.Text = "Отмена";
            CancelBtn.Click += CancelBtn_Click;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Animated = true;
            PasswordTextBox.AutoRoundedCorners = true;
            PasswordTextBox.BackColor = Color.Transparent;
            PasswordTextBox.BorderRadius = 24;
            PasswordTextBox.CustomizableEdges = customizableEdges5;
            PasswordTextBox.DefaultText = "";
            PasswordTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PasswordTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PasswordTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PasswordTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PasswordTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            PasswordTextBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PasswordTextBox.ForeColor = Color.Black;
            PasswordTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            PasswordTextBox.IconLeft = (Image)resources.GetObject("PasswordTextBox.IconLeft");
            PasswordTextBox.Location = new Point(100, 200);
            PasswordTextBox.Margin = new Padding(6, 7, 6, 7);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.PlaceholderForeColor = Color.DarkSlateGray;
            PasswordTextBox.PlaceholderText = "Пароль";
            PasswordTextBox.SelectedText = "";
            PasswordTextBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            PasswordTextBox.Size = new Size(400, 50);
            PasswordTextBox.TabIndex = 9;
            // 
            // LoginTextBox
            // 
            LoginTextBox.AutoRoundedCorners = true;
            LoginTextBox.BackColor = Color.Transparent;
            LoginTextBox.BorderRadius = 24;
            LoginTextBox.CustomizableEdges = customizableEdges7;
            LoginTextBox.DefaultText = "";
            LoginTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            LoginTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            LoginTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            LoginTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            LoginTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            LoginTextBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginTextBox.ForeColor = Color.Black;
            LoginTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            LoginTextBox.IconLeft = (Image)resources.GetObject("LoginTextBox.IconLeft");
            LoginTextBox.Location = new Point(100, 140);
            LoginTextBox.Margin = new Padding(6, 7, 6, 7);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.PasswordChar = '\0';
            LoginTextBox.PlaceholderForeColor = Color.DarkSlateGray;
            LoginTextBox.PlaceholderText = "Имя пользователя";
            LoginTextBox.SelectedText = "";
            LoginTextBox.ShadowDecoration.CustomizableEdges = customizableEdges8;
            LoginTextBox.Size = new Size(400, 50);
            LoginTextBox.TabIndex = 8;
            // 
            // LoginBottomPanel
            // 
            LoginBottomPanel.Controls.Add(LanguageLabel);
            LoginBottomPanel.CustomizableEdges = customizableEdges9;
            LoginBottomPanel.Dock = DockStyle.Bottom;
            LoginBottomPanel.FillColor = Color.DodgerBlue;
            LoginBottomPanel.FillColor2 = Color.Black;
            LoginBottomPanel.FillColor3 = Color.DodgerBlue;
            LoginBottomPanel.FillColor4 = Color.DodgerBlue;
            LoginBottomPanel.Location = new Point(0, 370);
            LoginBottomPanel.Name = "LoginBottomPanel";
            LoginBottomPanel.Quality = 100;
            LoginBottomPanel.ShadowDecoration.CustomizableEdges = customizableEdges10;
            LoginBottomPanel.Size = new Size(600, 50);
            LoginBottomPanel.TabIndex = 7;
            // 
            // LoginTopPanel
            // 
            LoginTopPanel.Controls.Add(VersionLabel);
            LoginTopPanel.Controls.Add(LoginStoreNameLabel);
            LoginTopPanel.Controls.Add(LoginPictureBox);
            LoginTopPanel.CustomizableEdges = customizableEdges11;
            LoginTopPanel.Dock = DockStyle.Top;
            LoginTopPanel.FillColor = Color.DodgerBlue;
            LoginTopPanel.FillColor2 = Color.DodgerBlue;
            LoginTopPanel.FillColor3 = Color.Black;
            LoginTopPanel.FillColor4 = Color.DodgerBlue;
            LoginTopPanel.Location = new Point(0, 0);
            LoginTopPanel.Name = "LoginTopPanel";
            LoginTopPanel.Quality = 100;
            LoginTopPanel.ShadowDecoration.CustomizableEdges = customizableEdges12;
            LoginTopPanel.Size = new Size(600, 80);
            LoginTopPanel.TabIndex = 10;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 18;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 420);
            Controls.Add(LoginMainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(600, 420);
            Name = "LoginForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            FormClosing += LoginForm_FormClosing;
            InputLanguageChanged += LoginForm_InputLanguageChanged;
            ((System.ComponentModel.ISupportInitialize)LoginPictureBox).EndInit();
            LoginMainPanel.ResumeLayout(false);
            LoginBottomPanel.ResumeLayout(false);
            LoginBottomPanel.PerformLayout();
            LoginTopPanel.ResumeLayout(false);
            LoginTopPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label LoginStoreNameLabel;
        private Label LanguageLabel;
        private Label VersionLabel;
        private PictureBox LoginPictureBox;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel LoginMainPanel;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel LoginBottomPanel;
        private Guna.UI2.WinForms.Guna2TextBox LoginTextBox;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTextBox;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel LoginTopPanel;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button CancelBtn;
        private Guna.UI2.WinForms.Guna2Button LoginBtn;
    }
}
