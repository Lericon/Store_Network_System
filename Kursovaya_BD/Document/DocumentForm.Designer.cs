namespace Document
{
    partial class DocumentForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            TopPanel = new Panel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            LabelPanel = new Panel();
            BottomPanel = new Panel();
            DoBtn = new Button();
            CancelBtn = new Button();
            CancelSaveBtn = new Button();
            SaveBtn = new Button();
            DocumentDGV = new DataGridView();
            TopPanel.SuspendLayout();
            LabelPanel.SuspendLayout();
            BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DocumentDGV).BeginInit();
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
            TopPanel.Size = new Size(784, 80);
            TopPanel.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(294, 33);
            label2.TabIndex = 2;
            label2.Text = "Работа с документами";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(326, 33);
            label1.TabIndex = 1;
            label1.Text = "Торговая сеть магазинов";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(201, 5);
            label3.Name = "label3";
            label3.Size = new Size(382, 33);
            label3.TabIndex = 3;
            label3.Text = "Окно для ввода SQL-запроса";
            // 
            // richTextBox1
            // 
            richTextBox1.AcceptsTab = true;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBox1.Location = new Point(0, 130);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(784, 381);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // LabelPanel
            // 
            LabelPanel.Controls.Add(label3);
            LabelPanel.Dock = DockStyle.Top;
            LabelPanel.Location = new Point(0, 80);
            LabelPanel.Name = "LabelPanel";
            LabelPanel.Size = new Size(784, 50);
            LabelPanel.TabIndex = 5;
            // 
            // BottomPanel
            // 
            BottomPanel.BackColor = Color.DodgerBlue;
            BottomPanel.Controls.Add(DoBtn);
            BottomPanel.Controls.Add(CancelBtn);
            BottomPanel.Controls.Add(CancelSaveBtn);
            BottomPanel.Controls.Add(SaveBtn);
            BottomPanel.Dock = DockStyle.Bottom;
            BottomPanel.Location = new Point(0, 511);
            BottomPanel.Name = "BottomPanel";
            BottomPanel.Size = new Size(784, 50);
            BottomPanel.TabIndex = 6;
            // 
            // DoBtn
            // 
            DoBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DoBtn.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DoBtn.Location = new Point(522, 4);
            DoBtn.Name = "DoBtn";
            DoBtn.Size = new Size(250, 42);
            DoBtn.TabIndex = 3;
            DoBtn.Text = "Выполнить";
            DoBtn.UseVisualStyleBackColor = true;
            DoBtn.Click += DoBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CancelBtn.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CancelBtn.Location = new Point(12, 4);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(250, 42);
            CancelBtn.TabIndex = 2;
            CancelBtn.Text = "Отмена";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // CancelSaveBtn
            // 
            CancelSaveBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CancelSaveBtn.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CancelSaveBtn.Location = new Point(12, 4);
            CancelSaveBtn.Name = "CancelSaveBtn";
            CancelSaveBtn.Size = new Size(250, 42);
            CancelSaveBtn.TabIndex = 0;
            CancelSaveBtn.Text = "Назад";
            CancelSaveBtn.UseVisualStyleBackColor = true;
            CancelSaveBtn.Visible = false;
            CancelSaveBtn.Click += CancelSaveBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveBtn.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SaveBtn.Location = new Point(522, 4);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(250, 42);
            SaveBtn.TabIndex = 1;
            SaveBtn.Text = "Сохранить в файл";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Visible = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // DocumentDGV
            // 
            DocumentDGV.AllowUserToAddRows = false;
            DocumentDGV.AllowUserToDeleteRows = false;
            DocumentDGV.AllowUserToResizeColumns = false;
            DocumentDGV.AllowUserToResizeRows = false;
            DocumentDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DocumentDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DocumentDGV.BackgroundColor = SystemColors.GradientInactiveCaption;
            DocumentDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Bahnschrift", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DocumentDGV.DefaultCellStyle = dataGridViewCellStyle2;
            DocumentDGV.Dock = DockStyle.Fill;
            DocumentDGV.GridColor = Color.DodgerBlue;
            DocumentDGV.Location = new Point(0, 130);
            DocumentDGV.MultiSelect = false;
            DocumentDGV.Name = "DocumentDGV";
            DocumentDGV.ReadOnly = true;
            DocumentDGV.Size = new Size(784, 381);
            DocumentDGV.TabIndex = 7;
            DocumentDGV.Visible = false;
            // 
            // DocumentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(784, 561);
            Controls.Add(DocumentDGV);
            Controls.Add(richTextBox1);
            Controls.Add(BottomPanel);
            Controls.Add(LabelPanel);
            Controls.Add(TopPanel);
            Name = "DocumentForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Документы";
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            LabelPanel.ResumeLayout(false);
            LabelPanel.PerformLayout();
            BottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DocumentDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private Label label2;
        private Label label1;
        private Label label3;
        private RichTextBox richTextBox1;
        private Panel LabelPanel;
        private Panel BottomPanel;
        private Button CancelSaveBtn;
        private Button SaveBtn;
        private Button DoBtn;
        private Button CancelBtn;
        private DataGridView DocumentDGV;
    }
}