namespace Monamur
{
    partial class EditVisitForm
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
            this.components = new System.ComponentModel.Container();
            this.vproceduresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monamurDBDataSet = new Monamur.MonamurDBDataSet();
            this.v_proceduresTableAdapter = new Monamur.MonamurDBDataSetTableAdapters.V_proceduresTableAdapter();
            this.sum_textBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.clientPage_button = new System.Windows.Forms.Button();
            this.petPage_button = new System.Windows.Forms.Button();
            this.proc_groupBox = new System.Windows.Forms.GroupBox();
            this.delProc_button = new System.Windows.Forms.Button();
            this.addProc_button = new System.Windows.Forms.Button();
            this.visitProc_dataGridView = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proced_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proced_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.procList_dataGridView = new System.Windows.Forms.DataGridView();
            this.procedurenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.info_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.phone_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.selectPet_button = new System.Windows.Forms.Button();
            this.client_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.breed_textBox = new System.Windows.Forms.TextBox();
            this.pet_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.min_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hour_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.visitDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.v_visitProceduresTableAdapter = new Monamur.MonamurDBDataSetTableAdapters.V_visitProceduresTableAdapter();
            this.master_comboBox = new System.Windows.Forms.ComboBox();
            this.vusersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.agress_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.v_usersTableAdapter = new Monamur.MonamurDBDataSetTableAdapters.V_usersTableAdapter();
            this.status_button = new System.Windows.Forms.Button();
            this.payment_comboBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vproceduresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monamurDBDataSet)).BeginInit();
            this.proc_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitProc_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procList_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vusersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agress_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // vproceduresBindingSource
            // 
            this.vproceduresBindingSource.DataMember = "V_procedures";
            this.vproceduresBindingSource.DataSource = this.monamurDBDataSet;
            // 
            // monamurDBDataSet
            // 
            this.monamurDBDataSet.DataSetName = "MonamurDBDataSet";
            this.monamurDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_proceduresTableAdapter
            // 
            this.v_proceduresTableAdapter.ClearBeforeFill = true;
            // 
            // sum_textBox
            // 
            this.sum_textBox.Location = new System.Drawing.Point(581, 543);
            this.sum_textBox.Name = "sum_textBox";
            this.sum_textBox.ReadOnly = true;
            this.sum_textBox.Size = new System.Drawing.Size(84, 20);
            this.sum_textBox.TabIndex = 50;
            this.sum_textBox.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(526, 546);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "ИТОГО:";
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(786, 541);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 48;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click_1);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(886, 541);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 47;
            this.cancel_button.Text = "Отмена";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // clientPage_button
            // 
            this.clientPage_button.Location = new System.Drawing.Point(10, 271);
            this.clientPage_button.Name = "clientPage_button";
            this.clientPage_button.Size = new System.Drawing.Size(139, 23);
            this.clientPage_button.TabIndex = 46;
            this.clientPage_button.Text = "Страница клиента";
            this.clientPage_button.UseVisualStyleBackColor = true;
            this.clientPage_button.Click += new System.EventHandler(this.clientPage_button_Click);
            // 
            // petPage_button
            // 
            this.petPage_button.Location = new System.Drawing.Point(10, 167);
            this.petPage_button.Name = "petPage_button";
            this.petPage_button.Size = new System.Drawing.Size(139, 23);
            this.petPage_button.TabIndex = 45;
            this.petPage_button.Text = "Страница питомца";
            this.petPage_button.UseVisualStyleBackColor = true;
            this.petPage_button.Click += new System.EventHandler(this.petPage_button_Click);
            // 
            // proc_groupBox
            // 
            this.proc_groupBox.Controls.Add(this.delProc_button);
            this.proc_groupBox.Controls.Add(this.addProc_button);
            this.proc_groupBox.Controls.Add(this.visitProc_dataGridView);
            this.proc_groupBox.Controls.Add(this.label11);
            this.proc_groupBox.Controls.Add(this.search_textBox);
            this.proc_groupBox.Controls.Add(this.label10);
            this.proc_groupBox.Controls.Add(this.procList_dataGridView);
            this.proc_groupBox.Location = new System.Drawing.Point(274, 10);
            this.proc_groupBox.Name = "proc_groupBox";
            this.proc_groupBox.Size = new System.Drawing.Size(698, 520);
            this.proc_groupBox.TabIndex = 44;
            this.proc_groupBox.TabStop = false;
            this.proc_groupBox.Text = "Выбор процедур";
            // 
            // delProc_button
            // 
            this.delProc_button.Location = new System.Drawing.Point(612, 333);
            this.delProc_button.Name = "delProc_button";
            this.delProc_button.Size = new System.Drawing.Size(75, 25);
            this.delProc_button.TabIndex = 22;
            this.delProc_button.Text = "Удалить";
            this.delProc_button.UseVisualStyleBackColor = true;
            this.delProc_button.Click += new System.EventHandler(this.delProc_button_Click);
            // 
            // addProc_button
            // 
            this.addProc_button.Location = new System.Drawing.Point(612, 47);
            this.addProc_button.Name = "addProc_button";
            this.addProc_button.Size = new System.Drawing.Size(75, 25);
            this.addProc_button.TabIndex = 21;
            this.addProc_button.Text = "Добавить";
            this.addProc_button.UseVisualStyleBackColor = true;
            this.addProc_button.Click += new System.EventHandler(this.addProc_button_Click_1);
            // 
            // visitProc_dataGridView
            // 
            this.visitProc_dataGridView.AllowUserToAddRows = false;
            this.visitProc_dataGridView.AllowUserToDeleteRows = false;
            this.visitProc_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitProc_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.proced_name,
            this.proced_Id,
            this.Cost,
            this.info});
            this.visitProc_dataGridView.Location = new System.Drawing.Point(19, 333);
            this.visitProc_dataGridView.Name = "visitProc_dataGridView";
            this.visitProc_dataGridView.RowHeadersVisible = false;
            this.visitProc_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.visitProc_dataGridView.Size = new System.Drawing.Size(587, 128);
            this.visitProc_dataGridView.TabIndex = 20;
            this.visitProc_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.visitProc_dataGridView_CellValueChanged);
            // 
            // number
            // 
            this.number.HeaderText = "№";
            this.number.Name = "number";
            this.number.Width = 30;
            // 
            // proced_name
            // 
            this.proced_name.HeaderText = "Процедура";
            this.proced_name.Name = "proced_name";
            this.proced_name.Width = 250;
            // 
            // proced_Id
            // 
            this.proced_Id.HeaderText = "ID процедуры";
            this.proced_Id.Name = "proced_Id";
            this.proced_Id.Visible = false;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Цена";
            this.Cost.Name = "Cost";
            // 
            // info
            // 
            this.info.HeaderText = "Инфо";
            this.info.Name = "info";
            this.info.Width = 200;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 317);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Процедуры питомцу";
            // 
            // search_textBox
            // 
            this.search_textBox.Location = new System.Drawing.Point(62, 19);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(262, 20);
            this.search_textBox.TabIndex = 19;
            this.search_textBox.TextChanged += new System.EventHandler(this.search_textBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Поиск";
            // 
            // procList_dataGridView
            // 
            this.procList_dataGridView.AllowUserToAddRows = false;
            this.procList_dataGridView.AllowUserToDeleteRows = false;
            this.procList_dataGridView.AutoGenerateColumns = false;
            this.procList_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.procList_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.procedurenameDataGridViewTextBoxColumn,
            this.animalidDataGridViewTextBoxColumn,
            this.animalDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.infoDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.procList_dataGridView.DataSource = this.vproceduresBindingSource;
            this.procList_dataGridView.Location = new System.Drawing.Point(19, 47);
            this.procList_dataGridView.Name = "procList_dataGridView";
            this.procList_dataGridView.ReadOnly = true;
            this.procList_dataGridView.RowHeadersVisible = false;
            this.procList_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.procList_dataGridView.Size = new System.Drawing.Size(587, 237);
            this.procList_dataGridView.TabIndex = 0;
            this.procList_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.procList_dataGridView_CellDoubleClick);
            // 
            // procedurenameDataGridViewTextBoxColumn
            // 
            this.procedurenameDataGridViewTextBoxColumn.DataPropertyName = "procedure_name";
            this.procedurenameDataGridViewTextBoxColumn.HeaderText = "Процедура";
            this.procedurenameDataGridViewTextBoxColumn.Name = "procedurenameDataGridViewTextBoxColumn";
            this.procedurenameDataGridViewTextBoxColumn.ReadOnly = true;
            this.procedurenameDataGridViewTextBoxColumn.Width = 250;
            // 
            // animalidDataGridViewTextBoxColumn
            // 
            this.animalidDataGridViewTextBoxColumn.DataPropertyName = "animal_id";
            this.animalidDataGridViewTextBoxColumn.HeaderText = "animal_id";
            this.animalidDataGridViewTextBoxColumn.Name = "animalidDataGridViewTextBoxColumn";
            this.animalidDataGridViewTextBoxColumn.ReadOnly = true;
            this.animalidDataGridViewTextBoxColumn.Visible = false;
            // 
            // animalDataGridViewTextBoxColumn
            // 
            this.animalDataGridViewTextBoxColumn.DataPropertyName = "animal";
            this.animalDataGridViewTextBoxColumn.HeaderText = "Животное";
            this.animalDataGridViewTextBoxColumn.Name = "animalDataGridViewTextBoxColumn";
            this.animalDataGridViewTextBoxColumn.ReadOnly = true;
            this.animalDataGridViewTextBoxColumn.Width = 70;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            this.costDataGridViewTextBoxColumn.Width = 50;
            // 
            // infoDataGridViewTextBoxColumn
            // 
            this.infoDataGridViewTextBoxColumn.DataPropertyName = "info";
            this.infoDataGridViewTextBoxColumn.HeaderText = "Инфо";
            this.infoDataGridViewTextBoxColumn.Name = "infoDataGridViewTextBoxColumn";
            this.infoDataGridViewTextBoxColumn.ReadOnly = true;
            this.infoDataGridViewTextBoxColumn.Width = 200;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // info_textBox
            // 
            this.info_textBox.Location = new System.Drawing.Point(10, 434);
            this.info_textBox.Multiline = true;
            this.info_textBox.Name = "info_textBox";
            this.info_textBox.Size = new System.Drawing.Size(253, 96);
            this.info_textBox.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 418);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Информация о посещении";
            // 
            // phone_textBox
            // 
            this.phone_textBox.Location = new System.Drawing.Point(65, 245);
            this.phone_textBox.Name = "phone_textBox";
            this.phone_textBox.ReadOnly = true;
            this.phone_textBox.Size = new System.Drawing.Size(201, 20);
            this.phone_textBox.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Телефон";
            // 
            // selectPet_button
            // 
            this.selectPet_button.Location = new System.Drawing.Point(191, 100);
            this.selectPet_button.Name = "selectPet_button";
            this.selectPet_button.Size = new System.Drawing.Size(75, 23);
            this.selectPet_button.TabIndex = 39;
            this.selectPet_button.Text = "Выбрать";
            this.selectPet_button.UseVisualStyleBackColor = true;
            this.selectPet_button.Click += new System.EventHandler(this.selectPet_button_Click);
            // 
            // client_textBox
            // 
            this.client_textBox.Location = new System.Drawing.Point(65, 209);
            this.client_textBox.Name = "client_textBox";
            this.client_textBox.ReadOnly = true;
            this.client_textBox.Size = new System.Drawing.Size(201, 20);
            this.client_textBox.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Хозяин";
            // 
            // breed_textBox
            // 
            this.breed_textBox.Location = new System.Drawing.Point(65, 141);
            this.breed_textBox.Name = "breed_textBox";
            this.breed_textBox.ReadOnly = true;
            this.breed_textBox.Size = new System.Drawing.Size(201, 20);
            this.breed_textBox.TabIndex = 36;
            // 
            // pet_textBox
            // 
            this.pet_textBox.Location = new System.Drawing.Point(65, 102);
            this.pet_textBox.Name = "pet_textBox";
            this.pet_textBox.ReadOnly = true;
            this.pet_textBox.Size = new System.Drawing.Size(120, 20);
            this.pet_textBox.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Порода";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Питомец";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "мин.";
            // 
            // min_textBox
            // 
            this.min_textBox.Location = new System.Drawing.Point(191, 62);
            this.min_textBox.Name = "min_textBox";
            this.min_textBox.Size = new System.Drawing.Size(36, 20);
            this.min_textBox.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "час.";
            // 
            // hour_textBox
            // 
            this.hour_textBox.Location = new System.Drawing.Point(116, 62);
            this.hour_textBox.Name = "hour_textBox";
            this.hour_textBox.Size = new System.Drawing.Size(36, 20);
            this.hour_textBox.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Время посещения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Дата посещения";
            // 
            // visitDate_dateTimePicker
            // 
            this.visitDate_dateTimePicker.Location = new System.Drawing.Point(116, 27);
            this.visitDate_dateTimePicker.Name = "visitDate_dateTimePicker";
            this.visitDate_dateTimePicker.Size = new System.Drawing.Size(147, 20);
            this.visitDate_dateTimePicker.TabIndex = 26;
            // 
            // v_visitProceduresTableAdapter
            // 
            this.v_visitProceduresTableAdapter.ClearBeforeFill = true;
            // 
            // master_comboBox
            // 
            this.master_comboBox.DataSource = this.vusersBindingSource;
            this.master_comboBox.DisplayMember = "login";
            this.master_comboBox.FormattingEnabled = true;
            this.master_comboBox.Location = new System.Drawing.Point(63, 343);
            this.master_comboBox.Name = "master_comboBox";
            this.master_comboBox.Size = new System.Drawing.Size(203, 21);
            this.master_comboBox.TabIndex = 54;
            this.master_comboBox.ValueMember = "Id";
            // 
            // vusersBindingSource
            // 
            this.vusersBindingSource.DataMember = "V_users";
            this.vusersBindingSource.DataSource = this.monamurDBDataSet;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 346);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 53;
            this.label14.Text = "Мастер";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 310);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "Агресивность питомца";
            // 
            // agress_numericUpDown
            // 
            this.agress_numericUpDown.Location = new System.Drawing.Point(140, 308);
            this.agress_numericUpDown.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.agress_numericUpDown.Name = "agress_numericUpDown";
            this.agress_numericUpDown.Size = new System.Drawing.Size(52, 20);
            this.agress_numericUpDown.TabIndex = 51;
            // 
            // v_usersTableAdapter
            // 
            this.v_usersTableAdapter.ClearBeforeFill = true;
            // 
            // status_button
            // 
            this.status_button.Location = new System.Drawing.Point(10, 541);
            this.status_button.Name = "status_button";
            this.status_button.Size = new System.Drawing.Size(160, 23);
            this.status_button.TabIndex = 55;
            this.status_button.Text = "ИСПОЛНЕНО";
            this.status_button.UseVisualStyleBackColor = true;
            this.status_button.Click += new System.EventHandler(this.status_button_Click);
            // 
            // payment_comboBox
            // 
            this.payment_comboBox.FormattingEnabled = true;
            this.payment_comboBox.Items.AddRange(new object[] {
            "КАРТОЙ",
            "НАЛИЧНЫЙ РАСЧЕТ"});
            this.payment_comboBox.Location = new System.Drawing.Point(62, 384);
            this.payment_comboBox.Name = "payment_comboBox";
            this.payment_comboBox.Size = new System.Drawing.Size(204, 21);
            this.payment_comboBox.TabIndex = 57;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 387);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 56;
            this.label15.Text = "Оплата";
            // 
            // EditVisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 571);
            this.Controls.Add(this.payment_comboBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.status_button);
            this.Controls.Add(this.master_comboBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.agress_numericUpDown);
            this.Controls.Add(this.sum_textBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.clientPage_button);
            this.Controls.Add(this.petPage_button);
            this.Controls.Add(this.proc_groupBox);
            this.Controls.Add(this.info_textBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.phone_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.selectPet_button);
            this.Controls.Add(this.client_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.breed_textBox);
            this.Controls.Add(this.pet_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.min_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hour_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.visitDate_dateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditVisitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактировать посещение";
            this.Load += new System.EventHandler(this.EditVisitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vproceduresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monamurDBDataSet)).EndInit();
            this.proc_groupBox.ResumeLayout(false);
            this.proc_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitProc_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procList_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vusersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agress_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource vproceduresBindingSource;
        private MonamurDBDataSetTableAdapters.V_proceduresTableAdapter v_proceduresTableAdapter;
        private System.Windows.Forms.TextBox sum_textBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button clientPage_button;
        private System.Windows.Forms.Button petPage_button;
        private System.Windows.Forms.GroupBox proc_groupBox;
        private System.Windows.Forms.Button delProc_button;
        private System.Windows.Forms.Button addProc_button;
        private System.Windows.Forms.DataGridView visitProc_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn proced_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn proced_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn info;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView procList_dataGridView;
        private System.Windows.Forms.TextBox info_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox phone_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button selectPet_button;
        private System.Windows.Forms.TextBox client_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox breed_textBox;
        private System.Windows.Forms.TextBox pet_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox min_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hour_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker visitDate_dateTimePicker;
        private MonamurDBDataSet monamurDBDataSet;
        private MonamurDBDataSetTableAdapters.V_visitProceduresTableAdapter v_visitProceduresTableAdapter;
        private System.Windows.Forms.ComboBox master_comboBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown agress_numericUpDown;
        private System.Windows.Forms.BindingSource vusersBindingSource;
        private MonamurDBDataSetTableAdapters.V_usersTableAdapter v_usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn procedurenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button status_button;
        private System.Windows.Forms.ComboBox payment_comboBox;
        private System.Windows.Forms.Label label15;
    }
}