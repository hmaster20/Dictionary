namespace Dictionary
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьБазуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.объединитьБазыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Edit = new System.Windows.Forms.Button();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.colWordEn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWordRu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.настройкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(930, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьБазуToolStripMenuItem,
            this.объединитьБазыToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьБазуToolStripMenuItem
            // 
            this.создатьБазуToolStripMenuItem.Name = "создатьБазуToolStripMenuItem";
            this.создатьБазуToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.создатьБазуToolStripMenuItem.Text = "Создать базу";
            // 
            // объединитьБазыToolStripMenuItem
            // 
            this.объединитьБазыToolStripMenuItem.Name = "объединитьБазыToolStripMenuItem";
            this.объединитьБазыToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.объединитьБазыToolStripMenuItem.Text = "Объединить базы";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // настройкаToolStripMenuItem
            // 
            this.настройкаToolStripMenuItem.Name = "настройкаToolStripMenuItem";
            this.настройкаToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.настройкаToolStripMenuItem.Text = "Настройка";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(930, 462);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.Edit);
            this.tabPage1.Controls.Add(this.dgvTable);
            this.tabPage1.Controls.Add(this.Delete);
            this.tabPage1.Controls.Add(this.Add);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(922, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Словарь";
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(683, 54);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 23);
            this.Edit.TabIndex = 3;
            this.Edit.Text = "Изменить";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToAddRows = false;
            this.dgvTable.AllowUserToDeleteRows = false;
            this.dgvTable.AllowUserToResizeRows = false;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colWordEn,
            this.colWordRu,
            this.colType});
            this.dgvTable.Location = new System.Drawing.Point(34, 31);
            this.dgvTable.MultiSelect = false;
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.ReadOnly = true;
            this.dgvTable.RowHeadersVisible = false;
            this.dgvTable.Size = new System.Drawing.Size(487, 360);
            this.dgvTable.TabIndex = 2;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(764, 54);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(602, 54);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 0;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(922, 436);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Проверка знаний";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 464);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(930, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssLabel
            // 
            this.tssLabel.Name = "tssLabel";
            this.tssLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // colWordEn
            // 
            this.colWordEn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colWordEn.DataPropertyName = "WordEn";
            this.colWordEn.HeaderText = "Слово";
            this.colWordEn.Name = "colWordEn";
            this.colWordEn.ReadOnly = true;
            // 
            // colWordRu
            // 
            this.colWordRu.DataPropertyName = "WordRu";
            this.colWordRu.HeaderText = "Перевод";
            this.colWordRu.Name = "colWordRu";
            this.colWordRu.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.DataPropertyName = "Type";
            this.colType.HeaderText = "Тип";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 486);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Словарь";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.ToolStripMenuItem создатьБазуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem объединитьБазыToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tssLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWordEn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWordRu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
    }
}

