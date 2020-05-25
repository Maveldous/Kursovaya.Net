namespace WindowsFormsApp1
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.change2lbl = new System.Windows.Forms.Label();
            this.changeBox2 = new System.Windows.Forms.TextBox();
            this.changeBox1 = new System.Windows.Forms.ComboBox();
            this.change1lbl = new System.Windows.Forms.Label();
            this.changeBtn = new System.Windows.Forms.Button();
            this.changelbl = new System.Windows.Forms.Label();
            this.changeBox = new System.Windows.Forms.TextBox();
            this.delBtn = new System.Windows.Forms.Button();
            this.delbl = new System.Windows.Forms.Label();
            this.enterDelBox = new System.Windows.Forms.TextBox();
            this.enterBoxContinent = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.appendBtn = new System.Windows.Forms.Button();
            this.enterBoxArea = new System.Windows.Forms.TextBox();
            this.enterBoxPopulation = new System.Windows.Forms.TextBox();
            this.enterBoxCapital = new System.Windows.Forms.TextBox();
            this.enterBoxName = new System.Windows.Forms.TextBox();
            this.enterChangeBox = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.findCapitalLbl = new System.Windows.Forms.Label();
            this.findCapitalBtn = new System.Windows.Forms.Button();
            this.findlbl1 = new System.Windows.Forms.Label();
            this.findBox1 = new System.Windows.Forms.TextBox();
            this.massDelLbl = new System.Windows.Forms.Label();
            this.massDelBtn = new System.Windows.Forms.Button();
            this.massDelLbl2 = new System.Windows.Forms.Label();
            this.populDelBox = new System.Windows.Forms.TextBox();
            this.enterChangeBox1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.loadbtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.findlbl3 = new System.Windows.Forms.Label();
            this.findAreaBtn = new System.Windows.Forms.Button();
            this.findlbl2 = new System.Windows.Forms.Label();
            this.findAreaBox = new System.Windows.Forms.TextBox();
            this.find3lbl = new System.Windows.Forms.Label();
            this.findNameBtn = new System.Windows.Forms.Button();
            this.find2lbl = new System.Windows.Forms.Label();
            this.findNameBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enterChangeBox)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enterChangeBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(-2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(871, 526);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.change2lbl);
            this.tabPage1.Controls.Add(this.changeBox2);
            this.tabPage1.Controls.Add(this.changeBox1);
            this.tabPage1.Controls.Add(this.change1lbl);
            this.tabPage1.Controls.Add(this.changeBtn);
            this.tabPage1.Controls.Add(this.changelbl);
            this.tabPage1.Controls.Add(this.changeBox);
            this.tabPage1.Controls.Add(this.delBtn);
            this.tabPage1.Controls.Add(this.delbl);
            this.tabPage1.Controls.Add(this.enterDelBox);
            this.tabPage1.Controls.Add(this.enterBoxContinent);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.appendBtn);
            this.tabPage1.Controls.Add(this.enterBoxArea);
            this.tabPage1.Controls.Add(this.enterBoxPopulation);
            this.tabPage1.Controls.Add(this.enterBoxCapital);
            this.tabPage1.Controls.Add(this.enterBoxName);
            this.tabPage1.Controls.Add(this.enterChangeBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(863, 500);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // change2lbl
            // 
            this.change2lbl.AutoSize = true;
            this.change2lbl.Location = new System.Drawing.Point(11, 449);
            this.change2lbl.Name = "change2lbl";
            this.change2lbl.Size = new System.Drawing.Size(55, 13);
            this.change2lbl.TabIndex = 23;
            this.change2lbl.Text = "Значение";
            // 
            // changeBox2
            // 
            this.changeBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.changeBox2.Location = new System.Drawing.Point(14, 465);
            this.changeBox2.Name = "changeBox2";
            this.changeBox2.Size = new System.Drawing.Size(100, 20);
            this.changeBox2.TabIndex = 22;
            // 
            // changeBox1
            // 
            this.changeBox1.CausesValidation = false;
            this.changeBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.changeBox1.FormattingEnabled = true;
            this.changeBox1.Items.AddRange(new object[] {
            "Название",
            "Столица",
            "Континент",
            "Численность населения",
            "Занимаемая площадь"});
            this.changeBox1.Location = new System.Drawing.Point(14, 412);
            this.changeBox1.Name = "changeBox1";
            this.changeBox1.Size = new System.Drawing.Size(130, 21);
            this.changeBox1.TabIndex = 21;
            // 
            // change1lbl
            // 
            this.change1lbl.AutoSize = true;
            this.change1lbl.Location = new System.Drawing.Point(7, 391);
            this.change1lbl.Name = "change1lbl";
            this.change1lbl.Size = new System.Drawing.Size(137, 13);
            this.change1lbl.TabIndex = 20;
            this.change1lbl.Text = "Поле изменяемого члена";
            // 
            // changeBtn
            // 
            this.changeBtn.Location = new System.Drawing.Point(126, 365);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(73, 23);
            this.changeBtn.TabIndex = 18;
            this.changeBtn.Text = "Изменить";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // changelbl
            // 
            this.changelbl.AutoSize = true;
            this.changelbl.Location = new System.Drawing.Point(7, 346);
            this.changelbl.Name = "changelbl";
            this.changelbl.Size = new System.Drawing.Size(145, 13);
            this.changelbl.TabIndex = 17;
            this.changelbl.Text = "Номер изменяемого члена";
            // 
            // changeBox
            // 
            this.changeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.changeBox.Location = new System.Drawing.Point(14, 365);
            this.changeBox.Name = "changeBox";
            this.changeBox.Size = new System.Drawing.Size(100, 20);
            this.changeBox.TabIndex = 16;
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(126, 278);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(73, 23);
            this.delBtn.TabIndex = 15;
            this.delBtn.Text = "Удалить";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // delbl
            // 
            this.delbl.AutoSize = true;
            this.delbl.Location = new System.Drawing.Point(3, 262);
            this.delbl.Name = "delbl";
            this.delbl.Size = new System.Drawing.Size(136, 13);
            this.delbl.TabIndex = 14;
            this.delbl.Text = "Номер удаляемого члена";
            // 
            // enterDelBox
            // 
            this.enterDelBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enterDelBox.Location = new System.Drawing.Point(10, 281);
            this.enterDelBox.Name = "enterDelBox";
            this.enterDelBox.Size = new System.Drawing.Size(100, 20);
            this.enterDelBox.TabIndex = 13;
            // 
            // enterBoxContinent
            // 
            this.enterBoxContinent.CausesValidation = false;
            this.enterBoxContinent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enterBoxContinent.FormattingEnabled = true;
            this.enterBoxContinent.Items.AddRange(new object[] {
            "Евразия",
            "Африка",
            "Северная Америка",
            "Южная Америка",
            "Австралия",
            "Антарктида"});
            this.enterBoxContinent.Location = new System.Drawing.Point(10, 113);
            this.enterBoxContinent.Name = "enterBoxContinent";
            this.enterBoxContinent.Size = new System.Drawing.Size(100, 21);
            this.enterBoxContinent.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Площадь";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Численость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Континент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Столица";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Название страны";
            // 
            // appendBtn
            // 
            this.appendBtn.Location = new System.Drawing.Point(126, 97);
            this.appendBtn.Name = "appendBtn";
            this.appendBtn.Size = new System.Drawing.Size(73, 23);
            this.appendBtn.TabIndex = 6;
            this.appendBtn.Text = "Добавить";
            this.appendBtn.UseVisualStyleBackColor = true;
            this.appendBtn.Click += new System.EventHandler(this.appendBtn_Click);
            // 
            // enterBoxArea
            // 
            this.enterBoxArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enterBoxArea.Location = new System.Drawing.Point(10, 206);
            this.enterBoxArea.Name = "enterBoxArea";
            this.enterBoxArea.Size = new System.Drawing.Size(100, 20);
            this.enterBoxArea.TabIndex = 5;
            // 
            // enterBoxPopulation
            // 
            this.enterBoxPopulation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enterBoxPopulation.Location = new System.Drawing.Point(10, 163);
            this.enterBoxPopulation.Name = "enterBoxPopulation";
            this.enterBoxPopulation.Size = new System.Drawing.Size(100, 20);
            this.enterBoxPopulation.TabIndex = 4;
            // 
            // enterBoxCapital
            // 
            this.enterBoxCapital.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enterBoxCapital.Location = new System.Drawing.Point(10, 70);
            this.enterBoxCapital.Name = "enterBoxCapital";
            this.enterBoxCapital.Size = new System.Drawing.Size(100, 20);
            this.enterBoxCapital.TabIndex = 2;
            // 
            // enterBoxName
            // 
            this.enterBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enterBoxName.Location = new System.Drawing.Point(10, 27);
            this.enterBoxName.Name = "enterBoxName";
            this.enterBoxName.Size = new System.Drawing.Size(100, 20);
            this.enterBoxName.TabIndex = 1;
            this.enterBoxName.Tag = "";
            // 
            // enterChangeBox
            // 
            this.enterChangeBox.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.enterChangeBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enterChangeBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.enterChangeBox.Location = new System.Drawing.Point(215, 3);
            this.enterChangeBox.Name = "enterChangeBox";
            this.enterChangeBox.Size = new System.Drawing.Size(645, 494);
            this.enterChangeBox.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Номер";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Название";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Столица";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Континент";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Численность населения";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Занимаемая площадь";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.find3lbl);
            this.tabPage2.Controls.Add(this.findNameBtn);
            this.tabPage2.Controls.Add(this.find2lbl);
            this.tabPage2.Controls.Add(this.findNameBox);
            this.tabPage2.Controls.Add(this.findlbl3);
            this.tabPage2.Controls.Add(this.findAreaBtn);
            this.tabPage2.Controls.Add(this.findlbl2);
            this.tabPage2.Controls.Add(this.findAreaBox);
            this.tabPage2.Controls.Add(this.findCapitalLbl);
            this.tabPage2.Controls.Add(this.findCapitalBtn);
            this.tabPage2.Controls.Add(this.findlbl1);
            this.tabPage2.Controls.Add(this.findBox1);
            this.tabPage2.Controls.Add(this.massDelLbl);
            this.tabPage2.Controls.Add(this.massDelBtn);
            this.tabPage2.Controls.Add(this.massDelLbl2);
            this.tabPage2.Controls.Add(this.populDelBox);
            this.tabPage2.Controls.Add(this.enterChangeBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(863, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Additional_functions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // findCapitalLbl
            // 
            this.findCapitalLbl.AutoSize = true;
            this.findCapitalLbl.Location = new System.Drawing.Point(24, 156);
            this.findCapitalLbl.Name = "findCapitalLbl";
            this.findCapitalLbl.Size = new System.Drawing.Size(57, 13);
            this.findCapitalLbl.TabIndex = 23;
            this.findCapitalLbl.Text = "Название";
            // 
            // findCapitalBtn
            // 
            this.findCapitalBtn.Location = new System.Drawing.Point(119, 170);
            this.findCapitalBtn.Name = "findCapitalBtn";
            this.findCapitalBtn.Size = new System.Drawing.Size(73, 23);
            this.findCapitalBtn.TabIndex = 22;
            this.findCapitalBtn.Text = "Поиск";
            this.findCapitalBtn.UseVisualStyleBackColor = true;
            this.findCapitalBtn.Click += new System.EventHandler(this.findCapitalBtn_Click);
            // 
            // findlbl1
            // 
            this.findlbl1.Location = new System.Drawing.Point(10, 130);
            this.findlbl1.Name = "findlbl1";
            this.findlbl1.Size = new System.Drawing.Size(168, 28);
            this.findlbl1.TabIndex = 21;
            this.findlbl1.Text = "Поиск по названию столицы:";
            // 
            // findBox1
            // 
            this.findBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.findBox1.Location = new System.Drawing.Point(13, 173);
            this.findBox1.Name = "findBox1";
            this.findBox1.Size = new System.Drawing.Size(100, 20);
            this.findBox1.TabIndex = 20;
            // 
            // massDelLbl
            // 
            this.massDelLbl.AutoSize = true;
            this.massDelLbl.Location = new System.Drawing.Point(24, 74);
            this.massDelLbl.Name = "massDelLbl";
            this.massDelLbl.Size = new System.Drawing.Size(74, 13);
            this.massDelLbl.TabIndex = 19;
            this.massDelLbl.Text = "Численность";
            // 
            // massDelBtn
            // 
            this.massDelBtn.Location = new System.Drawing.Point(119, 88);
            this.massDelBtn.Name = "massDelBtn";
            this.massDelBtn.Size = new System.Drawing.Size(73, 23);
            this.massDelBtn.TabIndex = 18;
            this.massDelBtn.Text = "Удалить";
            this.massDelBtn.UseVisualStyleBackColor = true;
            this.massDelBtn.Click += new System.EventHandler(this.massDelBtn_Click);
            // 
            // massDelLbl2
            // 
            this.massDelLbl2.Location = new System.Drawing.Point(24, 18);
            this.massDelLbl2.Name = "massDelLbl2";
            this.massDelLbl2.Size = new System.Drawing.Size(143, 46);
            this.massDelLbl2.TabIndex = 17;
            this.massDelLbl2.Text = "Удаление всех стран, у которых численность меньше заданной:";
            // 
            // populDelBox
            // 
            this.populDelBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.populDelBox.Location = new System.Drawing.Point(13, 91);
            this.populDelBox.Name = "populDelBox";
            this.populDelBox.Size = new System.Drawing.Size(100, 20);
            this.populDelBox.TabIndex = 16;
            // 
            // enterChangeBox1
            // 
            this.enterChangeBox1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.enterChangeBox1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enterChangeBox1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.enterChangeBox1.Location = new System.Drawing.Point(215, 3);
            this.enterChangeBox1.Name = "enterChangeBox1";
            this.enterChangeBox1.Size = new System.Drawing.Size(645, 494);
            this.enterChangeBox1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Столица";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Континент";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Численность населения";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Занимаемая площадь";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.loadbtn);
            this.tabPage3.Controls.Add(this.savebtn);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(863, 500);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Save & Load";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // loadbtn
            // 
            this.loadbtn.Location = new System.Drawing.Point(271, 174);
            this.loadbtn.Name = "loadbtn";
            this.loadbtn.Size = new System.Drawing.Size(343, 83);
            this.loadbtn.TabIndex = 1;
            this.loadbtn.Text = "Load data";
            this.loadbtn.UseVisualStyleBackColor = true;
            this.loadbtn.Click += new System.EventHandler(this.loadbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(271, 68);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(343, 83);
            this.savebtn.TabIndex = 0;
            this.savebtn.Text = "Save data";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(863, 500);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Reference";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // findlbl3
            // 
            this.findlbl3.AutoSize = true;
            this.findlbl3.Location = new System.Drawing.Point(24, 249);
            this.findlbl3.Name = "findlbl3";
            this.findlbl3.Size = new System.Drawing.Size(54, 13);
            this.findlbl3.TabIndex = 27;
            this.findlbl3.Text = "Площадь";
            // 
            // findAreaBtn
            // 
            this.findAreaBtn.Location = new System.Drawing.Point(119, 263);
            this.findAreaBtn.Name = "findAreaBtn";
            this.findAreaBtn.Size = new System.Drawing.Size(73, 23);
            this.findAreaBtn.TabIndex = 26;
            this.findAreaBtn.Text = "Поиск";
            this.findAreaBtn.UseVisualStyleBackColor = true;
            this.findAreaBtn.Click += new System.EventHandler(this.findAreaBtn_Click);
            // 
            // findlbl2
            // 
            this.findlbl2.Location = new System.Drawing.Point(10, 214);
            this.findlbl2.Name = "findlbl2";
            this.findlbl2.Size = new System.Drawing.Size(168, 28);
            this.findlbl2.TabIndex = 25;
            this.findlbl2.Text = "Поиск по занимаемой площади свыше заданной:";
            // 
            // findAreaBox
            // 
            this.findAreaBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.findAreaBox.Location = new System.Drawing.Point(13, 266);
            this.findAreaBox.Name = "findAreaBox";
            this.findAreaBox.Size = new System.Drawing.Size(100, 20);
            this.findAreaBox.TabIndex = 24;
            // 
            // find3lbl
            // 
            this.find3lbl.AutoSize = true;
            this.find3lbl.Location = new System.Drawing.Point(24, 339);
            this.find3lbl.Name = "find3lbl";
            this.find3lbl.Size = new System.Drawing.Size(57, 13);
            this.find3lbl.TabIndex = 31;
            this.find3lbl.Text = "Название";
            // 
            // findNameBtn
            // 
            this.findNameBtn.Location = new System.Drawing.Point(119, 353);
            this.findNameBtn.Name = "findNameBtn";
            this.findNameBtn.Size = new System.Drawing.Size(73, 23);
            this.findNameBtn.TabIndex = 30;
            this.findNameBtn.Text = "Поиск";
            this.findNameBtn.UseVisualStyleBackColor = true;
            this.findNameBtn.Click += new System.EventHandler(this.findNameBtn_Click);
            // 
            // find2lbl
            // 
            this.find2lbl.Location = new System.Drawing.Point(10, 311);
            this.find2lbl.Name = "find2lbl";
            this.find2lbl.Size = new System.Drawing.Size(168, 28);
            this.find2lbl.TabIndex = 29;
            this.find2lbl.Text = "Поиск по ключевому полю";
            // 
            // findNameBox
            // 
            this.findNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.findNameBox.Location = new System.Drawing.Point(13, 356);
            this.findNameBox.Name = "findNameBox";
            this.findNameBox.Size = new System.Drawing.Size(100, 20);
            this.findNameBox.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 523);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Курсовая";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enterChangeBox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enterChangeBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView enterChangeBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button appendBtn;
        private System.Windows.Forms.TextBox enterBoxArea;
        private System.Windows.Forms.TextBox enterBoxPopulation;
        private System.Windows.Forms.TextBox enterBoxCapital;
        private System.Windows.Forms.TextBox enterBoxName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox enterBoxContinent;
        private System.Windows.Forms.Button loadbtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Label delbl;
        private System.Windows.Forms.TextBox enterDelBox;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Label changelbl;
        private System.Windows.Forms.TextBox changeBox;
        private System.Windows.Forms.ComboBox changeBox1;
        private System.Windows.Forms.Label change1lbl;
        private System.Windows.Forms.Label change2lbl;
        private System.Windows.Forms.TextBox changeBox2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView enterChangeBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label massDelLbl;
        private System.Windows.Forms.Button massDelBtn;
        private System.Windows.Forms.Label massDelLbl2;
        private System.Windows.Forms.TextBox populDelBox;
        private System.Windows.Forms.Label findCapitalLbl;
        private System.Windows.Forms.Button findCapitalBtn;
        private System.Windows.Forms.Label findlbl1;
        private System.Windows.Forms.TextBox findBox1;
        private System.Windows.Forms.Label findlbl3;
        private System.Windows.Forms.Button findAreaBtn;
        private System.Windows.Forms.Label findlbl2;
        private System.Windows.Forms.TextBox findAreaBox;
        private System.Windows.Forms.Label find3lbl;
        private System.Windows.Forms.Button findNameBtn;
        private System.Windows.Forms.Label find2lbl;
        private System.Windows.Forms.TextBox findNameBox;
    }
}

