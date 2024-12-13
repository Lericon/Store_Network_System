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
            MainRTB = new RichTextBox();
            MessageBottomPanel = new Panel();
            ExitBtn = new Button();
            MessageBottomPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainRTB
            // 
            MainRTB.Dock = DockStyle.Fill;
            MainRTB.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainRTB.Location = new Point(0, 0);
            MainRTB.Name = "MainRTB";
            MainRTB.ReadOnly = true;
            MainRTB.Size = new Size(454, 261);
            MainRTB.TabIndex = 0;
            MainRTB.TabStop = false;
            MainRTB.Text = "";
            // 
            // MessageBottomPanel
            // 
            MessageBottomPanel.BackColor = Color.DodgerBlue;
            MessageBottomPanel.Controls.Add(ExitBtn);
            MessageBottomPanel.Dock = DockStyle.Bottom;
            MessageBottomPanel.Location = new Point(0, 261);
            MessageBottomPanel.Name = "MessageBottomPanel";
            MessageBottomPanel.Size = new Size(454, 50);
            MessageBottomPanel.TabIndex = 1;
            // 
            // ExitBtn
            // 
            ExitBtn.Anchor = AnchorStyles.Bottom;
            ExitBtn.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ExitBtn.Location = new Point(172, 6);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(125, 40);
            ExitBtn.TabIndex = 0;
            ExitBtn.Text = "Ок";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // Message
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 311);
            Controls.Add(MainRTB);
            Controls.Add(MessageBottomPanel);
            Name = "Message";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сообщение";
            MessageBottomPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox MainRTB;
        private Panel MessageBottomPanel;
        private Button ExitBtn;
    }
}