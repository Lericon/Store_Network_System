namespace Kursovaya_BD.Views
{
    partial class MainForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MainMenu = new MenuStrip();
            MainDataGridView = new DataGridView();
            MainBottomPanel = new Panel();
            SearchTextBox = new TextBox();
            SearchBtn = new Button();
            AddBtn = new Button();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)MainDataGridView).BeginInit();
            MainBottomPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainMenu
            // 
            MainMenu.BackColor = Color.DodgerBlue;
            MainMenu.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainMenu.Location = new Point(0, 0);
            MainMenu.Name = "MainMenu";
            MainMenu.Size = new Size(800, 24);
            MainMenu.TabIndex = 0;
            MainMenu.Text = "Главное меню";
            // 
            // MainDataGridView
            // 
            MainDataGridView.AllowUserToAddRows = false;
            MainDataGridView.AllowUserToDeleteRows = false;
            MainDataGridView.AllowUserToResizeColumns = false;
            MainDataGridView.AllowUserToResizeRows = false;
            MainDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            MainDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            MainDataGridView.BackgroundColor = SystemColors.GradientInactiveCaption;
            MainDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Bahnschrift", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            MainDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            MainDataGridView.Dock = DockStyle.Fill;
            MainDataGridView.GridColor = Color.Firebrick;
            MainDataGridView.Location = new Point(0, 24);
            MainDataGridView.MultiSelect = false;
            MainDataGridView.Name = "MainDataGridView";
            MainDataGridView.ReadOnly = true;
            MainDataGridView.Size = new Size(800, 371);
            MainDataGridView.TabIndex = 0;
            // 
            // MainBottomPanel
            // 
            MainBottomPanel.BackColor = Color.DodgerBlue;
            MainBottomPanel.Controls.Add(SearchTextBox);
            MainBottomPanel.Controls.Add(SearchBtn);
            MainBottomPanel.Controls.Add(AddBtn);
            MainBottomPanel.Controls.Add(UpdateBtn);
            MainBottomPanel.Controls.Add(DeleteBtn);
            MainBottomPanel.Dock = DockStyle.Bottom;
            MainBottomPanel.Location = new Point(0, 395);
            MainBottomPanel.Name = "MainBottomPanel";
            MainBottomPanel.Size = new Size(800, 55);
            MainBottomPanel.TabIndex = 1;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SearchTextBox.Location = new Point(133, 8);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(298, 40);
            SearchTextBox.TabIndex = 4;
            // 
            // SearchBtn
            // 
            SearchBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SearchBtn.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SearchBtn.Location = new Point(12, 8);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(115, 40);
            SearchBtn.TabIndex = 3;
            SearchBtn.Text = "Искать";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddBtn.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddBtn.Location = new Point(437, 8);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(115, 40);
            AddBtn.TabIndex = 2;
            AddBtn.Text = "Добавить";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            UpdateBtn.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UpdateBtn.Location = new Point(558, 8);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(115, 40);
            UpdateBtn.TabIndex = 1;
            UpdateBtn.Text = "Изменить";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DeleteBtn.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DeleteBtn.Location = new Point(679, 8);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(115, 40);
            DeleteBtn.TabIndex = 0;
            DeleteBtn.Text = "Удалить";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(MainDataGridView);
            Controls.Add(MainBottomPanel);
            Controls.Add(MainMenu);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = MainMenu;
            MinimumSize = new Size(816, 489);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Торговая сеть магазинов";
            ((System.ComponentModel.ISupportInitialize)MainDataGridView).EndInit();
            MainBottomPanel.ResumeLayout(false);
            MainBottomPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MainMenu;
        private DataGridView MainDataGridView;
        private Panel MainBottomPanel;
        private Button DeleteBtn;
        private Button AddBtn;
        private Button UpdateBtn;
        private TextBox SearchTextBox;
        private Button SearchBtn;
    }
}