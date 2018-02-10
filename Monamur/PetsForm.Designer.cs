namespace Monamur
{
    partial class PetsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cleartFilter_button = new System.Windows.Forms.Button();
            this.filter_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.byAnimal_panel = new System.Windows.Forms.Panel();
            this.animal_comboBox = new System.Windows.Forms.ComboBox();
            this.animalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monamurDBDataSet = new Monamur.MonamurDBDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.breedID_textBox = new System.Windows.Forms.TextBox();
            this.breed_textBox = new System.Windows.Forms.TextBox();
            this.selectBreed_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.client_textBox = new System.Windows.Forms.TextBox();
            this.byAnimal_checkBox = new System.Windows.Forms.CheckBox();
            this.activ_panel = new System.Windows.Forms.Panel();
            this.notActiv_radioButton = new System.Windows.Forms.RadioButton();
            this.all_radioButton = new System.Windows.Forms.RadioButton();
            this.activ_radioButton = new System.Windows.Forms.RadioButton();
            this.dlt_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pets_dataGridView = new System.Windows.Forms.DataGridView();
            this.vpetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_petsTableAdapter = new Monamur.MonamurDBDataSetTableAdapters.V_petsTableAdapter();
            this.breedsTableAdapter = new Monamur.MonamurDBDataSetTableAdapters.BreedsTableAdapter();
            this.animalsTableAdapter = new Monamur.MonamurDBDataSetTableAdapters.AnimalsTableAdapter();
            this.cancelBDay_button = new System.Windows.Forms.Button();
            this.bday_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.between_radioButton = new System.Windows.Forms.RadioButton();
            this.month_radioButton = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.day1_comboBox = new System.Windows.Forms.ComboBox();
            this.month1_comboBox = new System.Windows.Forms.ComboBox();
            this.monthsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monamurDBDataSet1 = new Monamur.MonamurDBDataSet();
            this.monthsTableAdapter = new Monamur.MonamurDBDataSetTableAdapters.MonthsTableAdapter();
            this.month2_comboBox = new System.Windows.Forms.ComboBox();
            this.day2_comboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dates_panel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breedidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aboutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox2.SuspendLayout();
            this.byAnimal_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monamurDBDataSet)).BeginInit();
            this.activ_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pets_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpetsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monamurDBDataSet1)).BeginInit();
            this.dates_panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(228, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "ПОИСК";
            // 
            // search_textBox
            // 
            this.search_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_textBox.Location = new System.Drawing.Point(279, 46);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(333, 22);
            this.search_textBox.TabIndex = 11;
            this.search_textBox.TextChanged += new System.EventHandler(this.search_textBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cleartFilter_button);
            this.groupBox2.Controls.Add(this.filter_button);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.byAnimal_panel);
            this.groupBox2.Controls.Add(this.client_textBox);
            this.groupBox2.Controls.Add(this.byAnimal_checkBox);
            this.groupBox2.Controls.Add(this.activ_panel);
            this.groupBox2.Location = new System.Drawing.Point(12, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 325);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фильтр";
            // 
            // cleartFilter_button
            // 
            this.cleartFilter_button.Location = new System.Drawing.Point(111, 295);
            this.cleartFilter_button.Name = "cleartFilter_button";
            this.cleartFilter_button.Size = new System.Drawing.Size(75, 25);
            this.cleartFilter_button.TabIndex = 13;
            this.cleartFilter_button.Text = "Очистить";
            this.cleartFilter_button.UseVisualStyleBackColor = true;
            this.cleartFilter_button.Click += new System.EventHandler(this.cleartFilter_button_Click);
            // 
            // filter_button
            // 
            this.filter_button.Location = new System.Drawing.Point(9, 295);
            this.filter_button.Name = "filter_button";
            this.filter_button.Size = new System.Drawing.Size(75, 25);
            this.filter_button.TabIndex = 12;
            this.filter_button.Text = "Применить";
            this.filter_button.UseVisualStyleBackColor = true;
            this.filter_button.Click += new System.EventHandler(this.filter_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Хозяин";
            // 
            // byAnimal_panel
            // 
            this.byAnimal_panel.Controls.Add(this.animal_comboBox);
            this.byAnimal_panel.Controls.Add(this.label3);
            this.byAnimal_panel.Controls.Add(this.breedID_textBox);
            this.byAnimal_panel.Controls.Add(this.breed_textBox);
            this.byAnimal_panel.Controls.Add(this.selectBreed_button);
            this.byAnimal_panel.Controls.Add(this.label4);
            this.byAnimal_panel.Enabled = false;
            this.byAnimal_panel.Location = new System.Drawing.Point(6, 132);
            this.byAnimal_panel.Name = "byAnimal_panel";
            this.byAnimal_panel.Size = new System.Drawing.Size(183, 102);
            this.byAnimal_panel.TabIndex = 8;
            // 
            // animal_comboBox
            // 
            this.animal_comboBox.DataSource = this.animalsBindingSource;
            this.animal_comboBox.DisplayMember = "animal";
            this.animal_comboBox.FormattingEnabled = true;
            this.animal_comboBox.Location = new System.Drawing.Point(3, 20);
            this.animal_comboBox.Name = "animal_comboBox";
            this.animal_comboBox.Size = new System.Drawing.Size(177, 21);
            this.animal_comboBox.TabIndex = 5;
            this.animal_comboBox.ValueMember = "Id";
            // 
            // animalsBindingSource
            // 
            this.animalsBindingSource.DataMember = "Animals";
            this.animalsBindingSource.DataSource = this.monamurDBDataSet;
            // 
            // monamurDBDataSet
            // 
            this.monamurDBDataSet.DataSetName = "MonamurDBDataSet";
            this.monamurDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Порода";
            // 
            // breedID_textBox
            // 
            this.breedID_textBox.Location = new System.Drawing.Point(113, 46);
            this.breedID_textBox.Name = "breedID_textBox";
            this.breedID_textBox.Size = new System.Drawing.Size(35, 20);
            this.breedID_textBox.TabIndex = 6;
            this.breedID_textBox.Text = "0";
            this.breedID_textBox.Visible = false;
            // 
            // breed_textBox
            // 
            this.breed_textBox.Location = new System.Drawing.Point(3, 69);
            this.breed_textBox.Name = "breed_textBox";
            this.breed_textBox.ReadOnly = true;
            this.breed_textBox.Size = new System.Drawing.Size(146, 20);
            this.breed_textBox.TabIndex = 2;
            // 
            // selectBreed_button
            // 
            this.selectBreed_button.Location = new System.Drawing.Point(155, 69);
            this.selectBreed_button.Name = "selectBreed_button";
            this.selectBreed_button.Size = new System.Drawing.Size(25, 20);
            this.selectBreed_button.TabIndex = 3;
            this.selectBreed_button.Text = "...";
            this.selectBreed_button.UseVisualStyleBackColor = true;
            this.selectBreed_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Животное";
            // 
            // client_textBox
            // 
            this.client_textBox.Location = new System.Drawing.Point(9, 250);
            this.client_textBox.Name = "client_textBox";
            this.client_textBox.Size = new System.Drawing.Size(177, 20);
            this.client_textBox.TabIndex = 8;
            // 
            // byAnimal_checkBox
            // 
            this.byAnimal_checkBox.AutoSize = true;
            this.byAnimal_checkBox.Location = new System.Drawing.Point(9, 109);
            this.byAnimal_checkBox.Name = "byAnimal_checkBox";
            this.byAnimal_checkBox.Size = new System.Drawing.Size(120, 17);
            this.byAnimal_checkBox.TabIndex = 7;
            this.byAnimal_checkBox.Text = "Фильтр по породе";
            this.byAnimal_checkBox.UseVisualStyleBackColor = true;
            this.byAnimal_checkBox.CheckedChanged += new System.EventHandler(this.byAnimal_checkBox_CheckedChanged);
            // 
            // activ_panel
            // 
            this.activ_panel.Controls.Add(this.notActiv_radioButton);
            this.activ_panel.Controls.Add(this.all_radioButton);
            this.activ_panel.Controls.Add(this.activ_radioButton);
            this.activ_panel.Location = new System.Drawing.Point(6, 19);
            this.activ_panel.Name = "activ_panel";
            this.activ_panel.Size = new System.Drawing.Size(183, 79);
            this.activ_panel.TabIndex = 0;
            // 
            // notActiv_radioButton
            // 
            this.notActiv_radioButton.AutoSize = true;
            this.notActiv_radioButton.Location = new System.Drawing.Point(3, 52);
            this.notActiv_radioButton.Name = "notActiv_radioButton";
            this.notActiv_radioButton.Size = new System.Drawing.Size(88, 17);
            this.notActiv_radioButton.TabIndex = 2;
            this.notActiv_radioButton.Text = "Неактивные";
            this.notActiv_radioButton.UseVisualStyleBackColor = true;
            // 
            // all_radioButton
            // 
            this.all_radioButton.AutoSize = true;
            this.all_radioButton.Checked = true;
            this.all_radioButton.Location = new System.Drawing.Point(3, 6);
            this.all_radioButton.Name = "all_radioButton";
            this.all_radioButton.Size = new System.Drawing.Size(44, 17);
            this.all_radioButton.TabIndex = 1;
            this.all_radioButton.TabStop = true;
            this.all_radioButton.Text = "Все";
            this.all_radioButton.UseVisualStyleBackColor = true;
            // 
            // activ_radioButton
            // 
            this.activ_radioButton.AutoSize = true;
            this.activ_radioButton.Location = new System.Drawing.Point(3, 29);
            this.activ_radioButton.Name = "activ_radioButton";
            this.activ_radioButton.Size = new System.Drawing.Size(75, 17);
            this.activ_radioButton.TabIndex = 0;
            this.activ_radioButton.Text = "Активные";
            this.activ_radioButton.UseVisualStyleBackColor = true;
            // 
            // dlt_button
            // 
            this.dlt_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dlt_button.Location = new System.Drawing.Point(1052, 46);
            this.dlt_button.Name = "dlt_button";
            this.dlt_button.Size = new System.Drawing.Size(110, 25);
            this.dlt_button.TabIndex = 2;
            this.dlt_button.Text = "Удалить";
            this.dlt_button.UseVisualStyleBackColor = true;
            this.dlt_button.Click += new System.EventHandler(this.dlt_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_button.Location = new System.Drawing.Point(912, 46);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(110, 25);
            this.edit_button.TabIndex = 1;
            this.edit_button.Text = "Редактировать";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_button.Location = new System.Drawing.Point(772, 46);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(110, 25);
            this.add_button.TabIndex = 0;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Список питомцев";
            // 
            // pets_dataGridView
            // 
            this.pets_dataGridView.AllowUserToAddRows = false;
            this.pets_dataGridView.AllowUserToDeleteRows = false;
            this.pets_dataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pets_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.pets_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pets_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.bdayDataGridViewTextBoxColumn,
            this.BD,
            this.ageDataGridViewTextBoxColumn,
            this.breedidDataGridViewTextBoxColumn,
            this.breedDataGridViewTextBoxColumn,
            this.clientidDataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn,
            this.aboutDataGridViewTextBoxColumn,
            this.alive});
            this.pets_dataGridView.DataSource = this.vpetsBindingSource;
            this.pets_dataGridView.Location = new System.Drawing.Point(227, 88);
            this.pets_dataGridView.Name = "pets_dataGridView";
            this.pets_dataGridView.ReadOnly = true;
            this.pets_dataGridView.RowHeadersVisible = false;
            this.pets_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pets_dataGridView.Size = new System.Drawing.Size(935, 480);
            this.pets_dataGridView.TabIndex = 7;
            this.pets_dataGridView.DoubleClick += new System.EventHandler(this.pets_dataGridView_DoubleClick);
            // 
            // vpetsBindingSource
            // 
            this.vpetsBindingSource.DataMember = "V_pets";
            this.vpetsBindingSource.DataSource = this.monamurDBDataSet;
            // 
            // v_petsTableAdapter
            // 
            this.v_petsTableAdapter.ClearBeforeFill = true;
            // 
            // breedsTableAdapter
            // 
            this.breedsTableAdapter.ClearBeforeFill = true;
            // 
            // animalsTableAdapter
            // 
            this.animalsTableAdapter.ClearBeforeFill = true;
            // 
            // cancelBDay_button
            // 
            this.cancelBDay_button.Location = new System.Drawing.Point(111, 147);
            this.cancelBDay_button.Name = "cancelBDay_button";
            this.cancelBDay_button.Size = new System.Drawing.Size(75, 25);
            this.cancelBDay_button.TabIndex = 16;
            this.cancelBDay_button.Text = "Очистить";
            this.cancelBDay_button.UseVisualStyleBackColor = true;
            this.cancelBDay_button.Click += new System.EventHandler(this.cancelBDay_button_Click);
            // 
            // bday_button
            // 
            this.bday_button.Location = new System.Drawing.Point(9, 147);
            this.bday_button.Name = "bday_button";
            this.bday_button.Size = new System.Drawing.Size(75, 25);
            this.bday_button.TabIndex = 15;
            this.bday_button.Text = "Применить";
            this.bday_button.UseVisualStyleBackColor = true;
            this.bday_button.Click += new System.EventHandler(this.bday_button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.between_radioButton);
            this.panel1.Controls.Add(this.month_radioButton);
            this.panel1.Location = new System.Drawing.Point(9, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 49);
            this.panel1.TabIndex = 17;
            // 
            // between_radioButton
            // 
            this.between_radioButton.AutoSize = true;
            this.between_radioButton.Location = new System.Drawing.Point(6, 27);
            this.between_radioButton.Name = "between_radioButton";
            this.between_radioButton.Size = new System.Drawing.Size(97, 17);
            this.between_radioButton.TabIndex = 1;
            this.between_radioButton.Text = "В промежутке";
            this.between_radioButton.UseVisualStyleBackColor = true;
            this.between_radioButton.CheckedChanged += new System.EventHandler(this.between_radioButton_CheckedChanged);
            // 
            // month_radioButton
            // 
            this.month_radioButton.AutoSize = true;
            this.month_radioButton.Checked = true;
            this.month_radioButton.Location = new System.Drawing.Point(6, 4);
            this.month_radioButton.Name = "month_radioButton";
            this.month_radioButton.Size = new System.Drawing.Size(101, 17);
            this.month_radioButton.TabIndex = 0;
            this.month_radioButton.TabStop = true;
            this.month_radioButton.Text = "В этом месяце";
            this.month_radioButton.UseVisualStyleBackColor = true;
            this.month_radioButton.CheckedChanged += new System.EventHandler(this.month_radioButton_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "от";
            // 
            // day1_comboBox
            // 
            this.day1_comboBox.FormattingEnabled = true;
            this.day1_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.day1_comboBox.Location = new System.Drawing.Point(27, 5);
            this.day1_comboBox.Name = "day1_comboBox";
            this.day1_comboBox.Size = new System.Drawing.Size(40, 21);
            this.day1_comboBox.TabIndex = 19;
            this.day1_comboBox.Text = "1";
            // 
            // month1_comboBox
            // 
            this.month1_comboBox.DataSource = this.monthsBindingSource;
            this.month1_comboBox.DisplayMember = "month";
            this.month1_comboBox.FormattingEnabled = true;
            this.month1_comboBox.Location = new System.Drawing.Point(73, 5);
            this.month1_comboBox.Name = "month1_comboBox";
            this.month1_comboBox.Size = new System.Drawing.Size(104, 21);
            this.month1_comboBox.TabIndex = 20;
            this.month1_comboBox.ValueMember = "num";
            // 
            // monthsBindingSource
            // 
            this.monthsBindingSource.DataMember = "Months";
            this.monthsBindingSource.DataSource = this.monamurDBDataSet1;
            // 
            // monamurDBDataSet1
            // 
            this.monamurDBDataSet1.DataSetName = "MonamurDBDataSet";
            this.monamurDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monthsTableAdapter
            // 
            this.monthsTableAdapter.ClearBeforeFill = true;
            // 
            // month2_comboBox
            // 
            this.month2_comboBox.DataSource = this.monthsBindingSource;
            this.month2_comboBox.DisplayMember = "month";
            this.month2_comboBox.FormattingEnabled = true;
            this.month2_comboBox.Location = new System.Drawing.Point(73, 32);
            this.month2_comboBox.Name = "month2_comboBox";
            this.month2_comboBox.Size = new System.Drawing.Size(104, 21);
            this.month2_comboBox.TabIndex = 23;
            this.month2_comboBox.ValueMember = "num";
            // 
            // day2_comboBox
            // 
            this.day2_comboBox.FormattingEnabled = true;
            this.day2_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.day2_comboBox.Location = new System.Drawing.Point(27, 32);
            this.day2_comboBox.Name = "day2_comboBox";
            this.day2_comboBox.Size = new System.Drawing.Size(40, 21);
            this.day2_comboBox.TabIndex = 22;
            this.day2_comboBox.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "до";
            // 
            // dates_panel
            // 
            this.dates_panel.Controls.Add(this.month2_comboBox);
            this.dates_panel.Controls.Add(this.month1_comboBox);
            this.dates_panel.Controls.Add(this.label7);
            this.dates_panel.Controls.Add(this.day2_comboBox);
            this.dates_panel.Controls.Add(this.day1_comboBox);
            this.dates_panel.Controls.Add(this.label8);
            this.dates_panel.Enabled = false;
            this.dates_panel.Location = new System.Drawing.Point(9, 69);
            this.dates_panel.Name = "dates_panel";
            this.dates_panel.Size = new System.Drawing.Size(180, 63);
            this.dates_panel.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancelBDay_button);
            this.groupBox1.Controls.Add(this.bday_button);
            this.groupBox1.Controls.Add(this.dates_panel);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 390);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 178);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дни рождения";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Кличка";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 130;
            // 
            // bdayDataGridViewTextBoxColumn
            // 
            this.bdayDataGridViewTextBoxColumn.DataPropertyName = "bday";
            this.bdayDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.bdayDataGridViewTextBoxColumn.Name = "bdayDataGridViewTextBoxColumn";
            this.bdayDataGridViewTextBoxColumn.ReadOnly = true;
            this.bdayDataGridViewTextBoxColumn.Width = 110;
            // 
            // BD
            // 
            this.BD.DataPropertyName = "BD";
            this.BD.HeaderText = "BD";
            this.BD.Name = "BD";
            this.BD.ReadOnly = true;
            this.BD.Visible = false;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = " Возраст";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            this.ageDataGridViewTextBoxColumn.Visible = false;
            // 
            // breedidDataGridViewTextBoxColumn
            // 
            this.breedidDataGridViewTextBoxColumn.DataPropertyName = "breed_id";
            this.breedidDataGridViewTextBoxColumn.HeaderText = "breed_id";
            this.breedidDataGridViewTextBoxColumn.Name = "breedidDataGridViewTextBoxColumn";
            this.breedidDataGridViewTextBoxColumn.ReadOnly = true;
            this.breedidDataGridViewTextBoxColumn.Visible = false;
            // 
            // breedDataGridViewTextBoxColumn
            // 
            this.breedDataGridViewTextBoxColumn.DataPropertyName = "breed";
            this.breedDataGridViewTextBoxColumn.HeaderText = "Порода";
            this.breedDataGridViewTextBoxColumn.Name = "breedDataGridViewTextBoxColumn";
            this.breedDataGridViewTextBoxColumn.ReadOnly = true;
            this.breedDataGridViewTextBoxColumn.Width = 150;
            // 
            // clientidDataGridViewTextBoxColumn
            // 
            this.clientidDataGridViewTextBoxColumn.DataPropertyName = "client_id";
            this.clientidDataGridViewTextBoxColumn.HeaderText = "client_id";
            this.clientidDataGridViewTextBoxColumn.Name = "clientidDataGridViewTextBoxColumn";
            this.clientidDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientidDataGridViewTextBoxColumn.Visible = false;
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "Хозяин";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            this.fioDataGridViewTextBoxColumn.ReadOnly = true;
            this.fioDataGridViewTextBoxColumn.Width = 150;
            // 
            // aboutDataGridViewTextBoxColumn
            // 
            this.aboutDataGridViewTextBoxColumn.DataPropertyName = "about";
            this.aboutDataGridViewTextBoxColumn.HeaderText = "Инфо";
            this.aboutDataGridViewTextBoxColumn.Name = "aboutDataGridViewTextBoxColumn";
            this.aboutDataGridViewTextBoxColumn.ReadOnly = true;
            this.aboutDataGridViewTextBoxColumn.Width = 300;
            // 
            // alive
            // 
            this.alive.DataPropertyName = "alive";
            this.alive.HeaderText = "Активен";
            this.alive.Name = "alive";
            this.alive.ReadOnly = true;
            this.alive.Width = 60;
            // 
            // PetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 580);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dlt_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.search_textBox);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pets_dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PetsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PetsForm";
            this.Load += new System.EventHandler(this.PetsForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.byAnimal_panel.ResumeLayout(false);
            this.byAnimal_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monamurDBDataSet)).EndInit();
            this.activ_panel.ResumeLayout(false);
            this.activ_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pets_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpetsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monamurDBDataSet1)).EndInit();
            this.dates_panel.ResumeLayout(false);
            this.dates_panel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button dlt_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView pets_dataGridView;
        private MonamurDBDataSet monamurDBDataSet;
        private System.Windows.Forms.BindingSource vpetsBindingSource;
        private MonamurDBDataSetTableAdapters.V_petsTableAdapter v_petsTableAdapter;
        private MonamurDBDataSetTableAdapters.BreedsTableAdapter breedsTableAdapter;
        private System.Windows.Forms.Button selectBreed_button;
        private System.Windows.Forms.TextBox breed_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel activ_panel;
        private System.Windows.Forms.RadioButton notActiv_radioButton;
        private System.Windows.Forms.RadioButton all_radioButton;
        private System.Windows.Forms.RadioButton activ_radioButton;
        private System.Windows.Forms.ComboBox animal_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource animalsBindingSource;
        private MonamurDBDataSetTableAdapters.AnimalsTableAdapter animalsTableAdapter;
        private System.Windows.Forms.TextBox breedID_textBox;
        private System.Windows.Forms.Panel byAnimal_panel;
        private System.Windows.Forms.CheckBox byAnimal_checkBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox client_textBox;
        private System.Windows.Forms.Button cleartFilter_button;
        private System.Windows.Forms.Button filter_button;
        private System.Windows.Forms.Button cancelBDay_button;
        private System.Windows.Forms.Button bday_button;
        private System.Windows.Forms.ComboBox month1_comboBox;
        private System.Windows.Forms.ComboBox day1_comboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton between_radioButton;
        private System.Windows.Forms.RadioButton month_radioButton;
        private MonamurDBDataSet monamurDBDataSet1;
        private System.Windows.Forms.BindingSource monthsBindingSource;
        private MonamurDBDataSetTableAdapters.MonthsTableAdapter monthsTableAdapter;
        private System.Windows.Forms.ComboBox month2_comboBox;
        private System.Windows.Forms.ComboBox day2_comboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel dates_panel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn breedidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn breedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aboutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn alive;
    }
}