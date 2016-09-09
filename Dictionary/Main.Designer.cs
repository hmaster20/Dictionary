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
            this.components = new System.ComponentModel.Container();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьБазуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.объединитьБазыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tControl = new System.Windows.Forms.TabControl();
            this.tpExam = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.timeLabelName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSelect = new System.Windows.Forms.RadioButton();
            this.rbInsert = new System.Windows.Forms.RadioButton();
            this.startButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbDic = new System.Windows.Forms.TabPage();
            this.Edit = new System.Windows.Forms.Button();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.colWordEn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWordRu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qwe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainMenu.SuspendLayout();
            this.tControl.SuspendLayout();
            this.tpExam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbDic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.настройкаToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(845, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
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
            // tControl
            // 
            this.tControl.Controls.Add(this.tpExam);
            this.tControl.Controls.Add(this.tbDic);
            this.tControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tControl.Location = new System.Drawing.Point(0, 24);
            this.tControl.Name = "tControl";
            this.tControl.SelectedIndex = 0;
            this.tControl.Size = new System.Drawing.Size(845, 462);
            this.tControl.TabIndex = 1;
            // 
            // tpExam
            // 
            this.tpExam.BackColor = System.Drawing.SystemColors.Control;
            this.tpExam.Controls.Add(this.label2);
            this.tpExam.Controls.Add(this.numericUpDown1);
            this.tpExam.Controls.Add(this.label1);
            this.tpExam.Controls.Add(this.timeLabelName);
            this.tpExam.Controls.Add(this.groupBox2);
            this.tpExam.Controls.Add(this.groupBox1);
            this.tpExam.Controls.Add(this.startButton);
            this.tpExam.Controls.Add(this.timeLabel);
            this.tpExam.Controls.Add(this.textBox2);
            this.tpExam.Controls.Add(this.textBox1);
            this.tpExam.Location = new System.Drawing.Point(4, 22);
            this.tpExam.Name = "tpExam";
            this.tpExam.Padding = new System.Windows.Forms.Padding(3);
            this.tpExam.Size = new System.Drawing.Size(837, 436);
            this.tpExam.TabIndex = 1;
            this.tpExam.Text = "Проверка знаний";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(83, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 14);
            this.label2.TabIndex = 10;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(523, 227);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(676, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // timeLabelName
            // 
            this.timeLabelName.AutoSize = true;
            this.timeLabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabelName.Location = new System.Drawing.Point(409, 88);
            this.timeLabelName.Name = "timeLabelName";
            this.timeLabelName.Size = new System.Drawing.Size(108, 13);
            this.timeLabelName.TabIndex = 7;
            this.timeLabelName.Text = "Оставшееся время:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(80, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 92);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выбери правильный ответ:";
            // 
            // radioButton3
            // 
            this.radioButton3.Location = new System.Drawing.Point(6, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(158, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(158, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(158, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSelect);
            this.groupBox1.Controls.Add(this.rbInsert);
            this.groupBox1.Location = new System.Drawing.Point(638, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 67);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Режим ответов";
            // 
            // rbSelect
            // 
            this.rbSelect.AutoSize = true;
            this.rbSelect.Location = new System.Drawing.Point(17, 19);
            this.rbSelect.Name = "rbSelect";
            this.rbSelect.Size = new System.Drawing.Size(121, 17);
            this.rbSelect.TabIndex = 5;
            this.rbSelect.TabStop = true;
            this.rbSelect.Text = "Угадывание слова";
            this.rbSelect.UseVisualStyleBackColor = true;
            // 
            // rbInsert
            // 
            this.rbInsert.AutoSize = true;
            this.rbInsert.Location = new System.Drawing.Point(17, 42);
            this.rbInsert.Name = "rbInsert";
            this.rbInsert.Size = new System.Drawing.Size(83, 17);
            this.rbInsert.TabIndex = 5;
            this.rbInsert.TabStop = true;
            this.rbInsert.Text = "Ввод слова";
            this.rbInsert.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(523, 116);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "startButton";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Location = new System.Drawing.Point(523, 87);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(75, 16);
            this.timeLabel.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(523, 192);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(523, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 2;
            // 
            // tbDic
            // 
            this.tbDic.BackColor = System.Drawing.SystemColors.Control;
            this.tbDic.Controls.Add(this.Edit);
            this.tbDic.Controls.Add(this.dgvTable);
            this.tbDic.Controls.Add(this.Delete);
            this.tbDic.Controls.Add(this.Add);
            this.tbDic.Location = new System.Drawing.Point(4, 22);
            this.tbDic.Name = "tbDic";
            this.tbDic.Padding = new System.Windows.Forms.Padding(3);
            this.tbDic.Size = new System.Drawing.Size(837, 436);
            this.tbDic.TabIndex = 0;
            this.tbDic.Text = "Словарь";
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(582, 29);
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
            this.dgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTable.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colWordEn,
            this.colWordRu,
            this.qwe});
            this.dgvTable.Location = new System.Drawing.Point(8, 6);
            this.dgvTable.MultiSelect = false;
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.ReadOnly = true;
            this.dgvTable.RowHeadersVisible = false;
            this.dgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTable.Size = new System.Drawing.Size(448, 409);
            this.dgvTable.TabIndex = 2;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(708, 29);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(501, 29);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 0;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 464);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(845, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssLabel
            // 
            this.tssLabel.Name = "tssLabel";
            this.tssLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            // qwe
            // 
            this.qwe.DataPropertyName = "TypeString";
            this.qwe.HeaderText = "Тип";
            this.qwe.Name = "qwe";
            this.qwe.ReadOnly = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 486);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tControl);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Словарь";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.tControl.ResumeLayout(false);
            this.tpExam.ResumeLayout(false);
            this.tpExam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbDic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.TabControl tControl;
        private System.Windows.Forms.TabPage tbDic;
        private System.Windows.Forms.TabPage tpExam;
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSelect;
        private System.Windows.Forms.RadioButton rbInsert;
        private System.Windows.Forms.Label timeLabelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWordEn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWordRu;
        private System.Windows.Forms.DataGridViewTextBoxColumn qwe;
    }
}

