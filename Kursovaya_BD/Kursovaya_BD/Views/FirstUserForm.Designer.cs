namespace Kursovaya_BD.Views
{
    partial class FirstUserForm
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
            panel1 = new Panel();
            FirstFormMessage = new Label();
            FirstUserBottomPanel = new Panel();
            NoButton = new Button();
            YesButton = new Button();
            FirstUserRTBox = new RichTextBox();
            panel1.SuspendLayout();
            FirstUserBottomPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(FirstFormMessage);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 50);
            panel1.TabIndex = 0;
            // 
            // FirstFormMessage
            // 
            FirstFormMessage.AutoSize = true;
            FirstFormMessage.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FirstFormMessage.Location = new Point(25, 9);
            FirstFormMessage.Name = "FirstFormMessage";
            FirstFormMessage.Size = new Size(403, 33);
            FirstFormMessage.TabIndex = 0;
            FirstFormMessage.Text = "Подтверждение о регистрации";
            // 
            // FirstUserBottomPanel
            // 
            FirstUserBottomPanel.BackColor = Color.DodgerBlue;
            FirstUserBottomPanel.Controls.Add(NoButton);
            FirstUserBottomPanel.Controls.Add(YesButton);
            FirstUserBottomPanel.Dock = DockStyle.Bottom;
            FirstUserBottomPanel.Location = new Point(0, 256);
            FirstUserBottomPanel.Name = "FirstUserBottomPanel";
            FirstUserBottomPanel.Size = new Size(454, 55);
            FirstUserBottomPanel.TabIndex = 1;
            // 
            // NoButton
            // 
            NoButton.FlatAppearance.BorderColor = Color.White;
            NoButton.FlatAppearance.BorderSize = 2;
            NoButton.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NoButton.Location = new Point(317, 7);
            NoButton.Name = "NoButton";
            NoButton.Size = new Size(125, 40);
            NoButton.TabIndex = 1;
            NoButton.Text = "Нет";
            NoButton.UseVisualStyleBackColor = true;
            NoButton.Click += NoButton_Click;
            // 
            // YesButton
            // 
            YesButton.FlatAppearance.BorderColor = Color.White;
            YesButton.FlatAppearance.BorderSize = 2;
            YesButton.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            YesButton.Location = new Point(12, 7);
            YesButton.Name = "YesButton";
            YesButton.Size = new Size(125, 40);
            YesButton.TabIndex = 0;
            YesButton.Text = "Да";
            YesButton.UseVisualStyleBackColor = true;
            YesButton.Click += YesButton_Click;
            // 
            // FirstUserRTBox
            // 
            FirstUserRTBox.Dock = DockStyle.Fill;
            FirstUserRTBox.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FirstUserRTBox.Location = new Point(0, 50);
            FirstUserRTBox.Name = "FirstUserRTBox";
            FirstUserRTBox.RightToLeft = RightToLeft.No;
            FirstUserRTBox.Size = new Size(454, 206);
            FirstUserRTBox.TabIndex = 2;
            FirstUserRTBox.Text = "";
            // 
            // FirstUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 311);
            Controls.Add(FirstUserRTBox);
            Controls.Add(panel1);
            Controls.Add(FirstUserBottomPanel);
            Name = "FirstUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Подтверждение";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            FirstUserBottomPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label FirstFormMessage;
        private Panel FirstUserBottomPanel;
        private RichTextBox FirstUserRTBox;
        private Button YesButton;
        private Button NoButton;
    }
}