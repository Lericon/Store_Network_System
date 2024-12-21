namespace Kursovaya_BD.Views
{
    partial class Message
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            MainRTB = new RichTextBox();
            ExitBtn = new Button();
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            guna2CustomGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // MainRTB
            // 
            MainRTB.Dock = DockStyle.Fill;
            MainRTB.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainRTB.Location = new Point(0, 0);
            MainRTB.Name = "MainRTB";
            MainRTB.ReadOnly = true;
            MainRTB.Size = new Size(454, 311);
            MainRTB.TabIndex = 0;
            MainRTB.TabStop = false;
            MainRTB.Text = "";
            // 
            // ExitBtn
            // 
            ExitBtn.Anchor = AnchorStyles.Bottom;
            ExitBtn.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ExitBtn.Location = new Point(165, 5);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(124, 40);
            ExitBtn.TabIndex = 0;
            ExitBtn.Text = "Ок";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.Controls.Add(ExitBtn);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges1;
            guna2CustomGradientPanel1.Dock = DockStyle.Bottom;
            guna2CustomGradientPanel1.FillColor = Color.DodgerBlue;
            guna2CustomGradientPanel1.FillColor2 = Color.Black;
            guna2CustomGradientPanel1.FillColor3 = Color.DodgerBlue;
            guna2CustomGradientPanel1.FillColor4 = Color.DodgerBlue;
            guna2CustomGradientPanel1.Location = new Point(0, 261);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CustomGradientPanel1.Size = new Size(454, 50);
            guna2CustomGradientPanel1.TabIndex = 2;
            // 
            // Message
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 311);
            Controls.Add(guna2CustomGradientPanel1);
            Controls.Add(MainRTB);
            Name = "Message";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сообщение";
            guna2CustomGradientPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox MainRTB;
        private Button ExitBtn;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
    }
}