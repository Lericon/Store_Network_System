namespace AboutProgram
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            CloseBtn = new Button();
            AboutRTB = new RichTextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 80);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(174, 33);
            label2.TabIndex = 1;
            label2.Text = "О программе";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(326, 33);
            label1.TabIndex = 0;
            label1.Text = "Торговая сеть магазинов";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(CloseBtn);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 311);
            panel2.Name = "panel2";
            panel2.Size = new Size(584, 50);
            panel2.TabIndex = 1;
            // 
            // CloseBtn
            // 
            CloseBtn.Anchor = AnchorStyles.Bottom;
            CloseBtn.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CloseBtn.Location = new Point(222, 3);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(140, 44);
            CloseBtn.TabIndex = 0;
            CloseBtn.Text = "Закрыть";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // AboutRTB
            // 
            AboutRTB.Dock = DockStyle.Fill;
            AboutRTB.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AboutRTB.Location = new Point(0, 80);
            AboutRTB.Name = "AboutRTB";
            AboutRTB.Size = new Size(584, 231);
            AboutRTB.TabIndex = 2;
            AboutRTB.Text = resources.GetString("AboutRTB.Text");
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(AboutRTB);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AboutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button CloseBtn;
        private RichTextBox AboutRTB;
    }
}