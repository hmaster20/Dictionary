﻿namespace Dictionary
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
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMerge = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuImport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpExam = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelWord = new System.Windows.Forms.Label();
            this.numericDic = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timeLabelName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rB3 = new System.Windows.Forms.RadioButton();
            this.rB2 = new System.Windows.Forms.RadioButton();
            this.rB1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSelect = new System.Windows.Forms.RadioButton();
            this.rbInsert = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbDic = new System.Windows.Forms.TabPage();
            this.lbFindType = new System.Windows.Forms.Label();
            this.lbFind = new System.Windows.Forms.Label();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.cbTypeFind = new System.Windows.Forms.ComboBox();
            this.Edit = new System.Windows.Forms.Button();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.colWordEn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWordRu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qwe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.statusDown = new System.Windows.Forms.StatusStrip();
            this.GLobalStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.FindStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerQuiz = new System.Windows.Forms.Timer(this.components);
            this.MainMenu.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tpExam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbDic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.statusDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuOptions,
            this.MenuHelp});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(845, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCreate,
            this.MenuMerge,
            this.toolSep1,
            this.MenuImport,
            this.toolSep2,
            this.MenuExit});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(48, 20);
            this.MenuFile.Text = "Файл";
            // 
            // MenuCreate
            // 
            this.MenuCreate.Name = "MenuCreate";
            this.MenuCreate.Size = new System.Drawing.Size(171, 22);
            this.MenuCreate.Text = "Создать базу";
            // 
            // MenuMerge
            // 
            this.MenuMerge.Name = "MenuMerge";
            this.MenuMerge.Size = new System.Drawing.Size(171, 22);
            this.MenuMerge.Text = "Объединить базы";
            // 
            // toolSep1
            // 
            this.toolSep1.Name = "toolSep1";
            this.toolSep1.Size = new System.Drawing.Size(168, 6);
            // 
            // MenuImport
            // 
            this.MenuImport.Name = "MenuImport";
            this.MenuImport.Size = new System.Drawing.Size(171, 22);
            this.MenuImport.Text = "Импорт..";
            this.MenuImport.Click += new System.EventHandler(this.import_Click);
            // 
            // toolSep2
            // 
            this.toolSep2.Name = "toolSep2";
            this.toolSep2.Size = new System.Drawing.Size(168, 6);
            // 
            // MenuExit
            // 
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(171, 22);
            this.MenuExit.Text = "Выход";
            // 
            // MenuOptions
            // 
            this.MenuOptions.Name = "MenuOptions";
            this.MenuOptions.Size = new System.Drawing.Size(78, 20);
            this.MenuOptions.Text = "Настройка";
            // 
            // MenuHelp
            // 
            this.MenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAbout});
            this.MenuHelp.Name = "MenuHelp";
            this.MenuHelp.Size = new System.Drawing.Size(65, 20);
            this.MenuHelp.Text = "Справка";
            // 
            // MenuAbout
            // 
            this.MenuAbout.Name = "MenuAbout";
            this.MenuAbout.Size = new System.Drawing.Size(149, 22);
            this.MenuAbout.Text = "О программе";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpExam);
            this.tabControl.Controls.Add(this.tbDic);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(845, 462);
            this.tabControl.TabIndex = 1;
            this.tabControl.Click += new System.EventHandler(this.tabControl_ResetFindStatus_Click);
            // 
            // tpExam
            // 
            this.tpExam.BackColor = System.Drawing.SystemColors.Control;
            this.tpExam.Controls.Add(this.checkBox1);
            this.tpExam.Controls.Add(this.labelWord);
            this.tpExam.Controls.Add(this.numericDic);
            this.tpExam.Controls.Add(this.numericUpDown1);
            this.tpExam.Controls.Add(this.label5);
            this.tpExam.Controls.Add(this.label3);
            this.tpExam.Controls.Add(this.label4);
            this.tpExam.Controls.Add(this.label1);
            this.tpExam.Controls.Add(this.timeLabelName);
            this.tpExam.Controls.Add(this.groupBox2);
            this.tpExam.Controls.Add(this.groupBox1);
            this.tpExam.Controls.Add(this.button1);
            this.tpExam.Controls.Add(this.startButton);
            this.tpExam.Controls.Add(this.timeLabel);
            this.tpExam.Controls.Add(this.textBox3);
            this.tpExam.Controls.Add(this.textBox2);
            this.tpExam.Controls.Add(this.textBox1);
            this.tpExam.Location = new System.Drawing.Point(4, 22);
            this.tpExam.Name = "tpExam";
            this.tpExam.Padding = new System.Windows.Forms.Padding(3);
            this.tpExam.Size = new System.Drawing.Size(837, 436);
            this.tpExam.TabIndex = 1;
            this.tpExam.Text = "Проверка знаний";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(377, 206);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "По порядку";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // labelWord
            // 
            this.labelWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelWord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelWord.Location = new System.Drawing.Point(83, 146);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(173, 14);
            this.labelWord.TabIndex = 10;
            // 
            // numericDic
            // 
            this.numericDic.Location = new System.Drawing.Point(377, 180);
            this.numericDic.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericDic.Name = "numericDic";
            this.numericDic.Size = new System.Drawing.Size(75, 20);
            this.numericDic.TabIndex = 9;
            this.numericDic.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericDic.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(315, 311);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(610, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Статистика";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Количество:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Отображение";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Режим:";
            // 
            // timeLabelName
            // 
            this.timeLabelName.AutoSize = true;
            this.timeLabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabelName.Location = new System.Drawing.Point(67, 79);
            this.timeLabelName.Name = "timeLabelName";
            this.timeLabelName.Size = new System.Drawing.Size(108, 13);
            this.timeLabelName.TabIndex = 7;
            this.timeLabelName.Text = "Оставшееся время:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rB3);
            this.groupBox2.Controls.Add(this.rB2);
            this.groupBox2.Controls.Add(this.rB1);
            this.groupBox2.Location = new System.Drawing.Point(80, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 92);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выбери правильный ответ:";
            // 
            // rB3
            // 
            this.rB3.Location = new System.Drawing.Point(6, 65);
            this.rB3.Name = "rB3";
            this.rB3.Size = new System.Drawing.Size(158, 17);
            this.rB3.TabIndex = 5;
            this.rB3.UseVisualStyleBackColor = true;
            // 
            // rB2
            // 
            this.rB2.Location = new System.Drawing.Point(6, 42);
            this.rB2.Name = "rB2";
            this.rB2.Size = new System.Drawing.Size(158, 17);
            this.rB2.TabIndex = 5;
            this.rB2.UseVisualStyleBackColor = true;
            // 
            // rB1
            // 
            this.rB1.Location = new System.Drawing.Point(6, 19);
            this.rB1.Name = "rB1";
            this.rB1.Size = new System.Drawing.Size(158, 17);
            this.rB1.TabIndex = 5;
            this.rB1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSelect);
            this.groupBox1.Controls.Add(this.rbInsert);
            this.groupBox1.Location = new System.Drawing.Point(301, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 67);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Режим ответов";
            // 
            // rbSelect
            // 
            this.rbSelect.AutoSize = true;
            this.rbSelect.Location = new System.Drawing.Point(6, 19);
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
            this.rbInsert.Location = new System.Drawing.Point(6, 42);
            this.rbInsert.Name = "rbInsert";
            this.rbInsert.Size = new System.Drawing.Size(83, 17);
            this.rbInsert.TabIndex = 5;
            this.rbInsert.TabStop = true;
            this.rbInsert.Text = "Ввод слова";
            this.rbInsert.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Остановить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(134, 111);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Location = new System.Drawing.Point(181, 78);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(75, 16);
            this.timeLabel.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(603, 275);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(146, 89);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(315, 285);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(315, 256);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 2;
            // 
            // tbDic
            // 
            this.tbDic.BackColor = System.Drawing.SystemColors.Control;
            this.tbDic.Controls.Add(this.lbFindType);
            this.tbDic.Controls.Add(this.lbFind);
            this.tbDic.Controls.Add(this.tbFind);
            this.tbDic.Controls.Add(this.btnFind);
            this.tbDic.Controls.Add(this.cbTypeFind);
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
            // lbFindType
            // 
            this.lbFindType.AutoSize = true;
            this.lbFindType.Location = new System.Drawing.Point(498, 215);
            this.lbFindType.Name = "lbFindType";
            this.lbFindType.Size = new System.Drawing.Size(94, 13);
            this.lbFindType.TabIndex = 21;
            this.lbFindType.Text = "Критерий поиска";
            // 
            // lbFind
            // 
            this.lbFind.AutoSize = true;
            this.lbFind.Location = new System.Drawing.Point(498, 167);
            this.lbFind.Name = "lbFind";
            this.lbFind.Size = new System.Drawing.Size(82, 13);
            this.lbFind.TabIndex = 21;
            this.lbFind.Text = "Строка поиска";
            // 
            // tbFind
            // 
            this.tbFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFind.Location = new System.Drawing.Point(501, 183);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(304, 20);
            this.tbFind.TabIndex = 20;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.Location = new System.Drawing.Point(723, 229);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(82, 23);
            this.btnFind.TabIndex = 19;
            this.btnFind.Text = "Поиск";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // cbTypeFind
            // 
            this.cbTypeFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeFind.FormattingEnabled = true;
            this.cbTypeFind.Items.AddRange(new object[] {
            "Слово",
            "Перевод"});
            this.cbTypeFind.Location = new System.Drawing.Point(501, 231);
            this.cbTypeFind.Name = "cbTypeFind";
            this.cbTypeFind.Size = new System.Drawing.Size(138, 21);
            this.cbTypeFind.TabIndex = 18;
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
            // statusDown
            // 
            this.statusDown.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GLobalStatusLabel,
            this.FindStatusLabel});
            this.statusDown.Location = new System.Drawing.Point(0, 464);
            this.statusDown.Name = "statusDown";
            this.statusDown.Size = new System.Drawing.Size(845, 22);
            this.statusDown.TabIndex = 0;
            // 
            // GLobalStatusLabel
            // 
            this.GLobalStatusLabel.Name = "GLobalStatusLabel";
            this.GLobalStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // FindStatusLabel
            // 
            this.FindStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.FindStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.FindStatusLabel.Name = "FindStatusLabel";
            this.FindStatusLabel.Size = new System.Drawing.Size(4, 17);
            // 
            // timerQuiz
            // 
            this.timerQuiz.Interval = 1000;
            this.timerQuiz.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 486);
            this.Controls.Add(this.statusDown);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Словарь";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tpExam.ResumeLayout(false);
            this.tpExam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbDic.ResumeLayout(false);
            this.tbDic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.statusDown.ResumeLayout(false);
            this.statusDown.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tbDic;
        private System.Windows.Forms.TabPage tpExam;
        private System.Windows.Forms.StatusStrip statusDown;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.ToolStripMenuItem MenuCreate;
        private System.Windows.Forms.ToolStripMenuItem MenuMerge;
        private System.Windows.Forms.ToolStripSeparator toolSep2;
        private System.Windows.Forms.ToolStripMenuItem MenuExit;
        private System.Windows.Forms.ToolStripMenuItem MenuOptions;
        private System.Windows.Forms.ToolStripStatusLabel GLobalStatusLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timerQuiz;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSelect;
        private System.Windows.Forms.RadioButton rbInsert;
        private System.Windows.Forms.Label timeLabelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rB3;
        private System.Windows.Forms.RadioButton rB2;
        private System.Windows.Forms.RadioButton rB1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWordEn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWordRu;
        private System.Windows.Forms.DataGridViewTextBoxColumn qwe;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numericDic;
        private System.Windows.Forms.Label lbFind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ToolStripSeparator toolSep1;
        private System.Windows.Forms.ToolStripMenuItem MenuImport;
        private System.Windows.Forms.Label lbFindType;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox cbTypeFind;
        private System.Windows.Forms.ToolStripStatusLabel FindStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem MenuHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuAbout;
        private System.Windows.Forms.Label label3;
    }
}

