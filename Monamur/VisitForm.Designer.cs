namespace Monamur
{
    partial class VisitForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dayPlus_button = new System.Windows.Forms.Button();
            this.dayMinus_button = new System.Windows.Forms.Button();
            this.visits_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.visitList_dataGridView = new System.Windows.Forms.DataGridView();
            this.vvisitesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monamurDBDataSet = new Monamur.MonamurDBDataSet();
            this.v_visitesTableAdapter = new Monamur.MonamurDBDataSetTableAdapters.V_visitesTableAdapter();
            this.addVisit_button = new System.Windows.Forms.Button();
            this.deleteVisit_button = new System.Windows.Forms.Button();
            this.editVisit_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cleartFilter_button = new System.Windows.Forms.Button();
            this.filter_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.end_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.begin_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.master_checkBox = new System.Windows.Forms.CheckBox();
            this.master_comboBox = new System.Windows.Forms.ComboBox();
            this.vusersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petName_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.v_usersTableAdapter = new Monamur.MonamurDBDataSetTableAdapters.V_usersTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timebeginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment_comboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sum_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.status_comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.visitList_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vvisitesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monamurDBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vusersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Расписание посещений";
            // 
            // dayPlus_button
            // 
            this.dayPlus_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayPlus_button.Location = new System.Drawing.Point(458, 45);
            this.dayPlus_button.Name = "dayPlus_button";
            this.dayPlus_button.Size = new System.Drawing.Size(45, 25);
            this.dayPlus_button.TabIndex = 9;
            this.dayPlus_button.Text = ">>";
            this.dayPlus_button.UseVisualStyleBackColor = true;
            this.dayPlus_button.Click += new System.EventHandler(this.dayPlus_button_Click);
            // 
            // dayMinus_button
            // 
            this.dayMinus_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayMinus_button.Location = new System.Drawing.Point(227, 44);
            this.dayMinus_button.Name = "dayMinus_button";
            this.dayMinus_button.Size = new System.Drawing.Size(45, 25);
            this.dayMinus_button.TabIndex = 8;
            this.dayMinus_button.Text = "<<";
            this.dayMinus_button.UseVisualStyleBackColor = true;
            this.dayMinus_button.Click += new System.EventHandler(this.dayMinus_button_Click);
            // 
            // visits_dateTimePicker
            // 
            this.visits_dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.visits_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.visits_dateTimePicker.Location = new System.Drawing.Point(287, 46);
            this.visits_dateTimePicker.Name = "visits_dateTimePicker";
            this.visits_dateTimePicker.Size = new System.Drawing.Size(154, 22);
            this.visits_dateTimePicker.TabIndex = 7;
            this.visits_dateTimePicker.ValueChanged += new System.EventHandler(this.visits_dateTimePicker_ValueChanged);
            // 
            // visitList_dataGridView
            // 
            this.visitList_dataGridView.AllowUserToAddRows = false;
            this.visitList_dataGridView.AllowUserToDeleteRows = false;
            this.visitList_dataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.visitList_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.visitList_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitList_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.status,
            this.dateDataGridViewTextBoxColumn,
            this.timebeginDataGridViewTextBoxColumn,
            this.idpetDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn,
            this.login,
            this.sumDataGridViewTextBoxColumn,
            this.payment,
            this.agress,
            this.infoDataGridViewTextBoxColumn});
            this.visitList_dataGridView.DataSource = this.vvisitesBindingSource;
            this.visitList_dataGridView.Location = new System.Drawing.Point(227, 88);
            this.visitList_dataGridView.MultiSelect = false;
            this.visitList_dataGridView.Name = "visitList_dataGridView";
            this.visitList_dataGridView.ReadOnly = true;
            this.visitList_dataGridView.RowHeadersVisible = false;
            this.visitList_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.visitList_dataGridView.Size = new System.Drawing.Size(935, 480);
            this.visitList_dataGridView.TabIndex = 11;
            this.visitList_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.visitList_dataGridView_CellDoubleClick);
            // 
            // vvisitesBindingSource
            // 
            this.vvisitesBindingSource.DataMember = "V_visites";
            this.vvisitesBindingSource.DataSource = this.monamurDBDataSet;
            // 
            // monamurDBDataSet
            // 
            this.monamurDBDataSet.DataSetName = "MonamurDBDataSet";
            this.monamurDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_visitesTableAdapter
            // 
            this.v_visitesTableAdapter.ClearBeforeFill = true;
            // 
            // addVisit_button
            // 
            this.addVisit_button.Location = new System.Drawing.Point(772, 46);
            this.addVisit_button.Name = "addVisit_button";
            this.addVisit_button.Size = new System.Drawing.Size(110, 25);
            this.addVisit_button.TabIndex = 12;
            this.addVisit_button.Text = "Добавить";
            this.addVisit_button.UseVisualStyleBackColor = true;
            this.addVisit_button.Click += new System.EventHandler(this.addVisit_button_Click);
            // 
            // deleteVisit_button
            // 
            this.deleteVisit_button.Location = new System.Drawing.Point(1052, 46);
            this.deleteVisit_button.Name = "deleteVisit_button";
            this.deleteVisit_button.Size = new System.Drawing.Size(110, 25);
            this.deleteVisit_button.TabIndex = 13;
            this.deleteVisit_button.Text = "Удалить";
            this.deleteVisit_button.UseVisualStyleBackColor = true;
            this.deleteVisit_button.Click += new System.EventHandler(this.deleteVisit_button_Click);
            // 
            // editVisit_button
            // 
            this.editVisit_button.Location = new System.Drawing.Point(912, 46);
            this.editVisit_button.Name = "editVisit_button";
            this.editVisit_button.Size = new System.Drawing.Size(110, 25);
            this.editVisit_button.TabIndex = 14;
            this.editVisit_button.Text = "Редактировать";
            this.editVisit_button.UseVisualStyleBackColor = true;
            this.editVisit_button.Click += new System.EventHandler(this.editVisit_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.status_comboBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.payment_comboBox);
            this.groupBox1.Controls.Add(this.cleartFilter_button);
            this.groupBox1.Controls.Add(this.filter_button);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.end_dateTimePicker);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.begin_dateTimePicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.master_checkBox);
            this.groupBox1.Controls.Add(this.master_comboBox);
            this.groupBox1.Controls.Add(this.petName_textBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 406);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтры";
            // 
            // cleartFilter_button
            // 
            this.cleartFilter_button.Location = new System.Drawing.Point(114, 363);
            this.cleartFilter_button.Name = "cleartFilter_button";
            this.cleartFilter_button.Size = new System.Drawing.Size(75, 25);
            this.cleartFilter_button.TabIndex = 11;
            this.cleartFilter_button.Text = "Очистить";
            this.cleartFilter_button.UseVisualStyleBackColor = true;
            this.cleartFilter_button.Click += new System.EventHandler(this.cleartFilter_button_Click);
            // 
            // filter_button
            // 
            this.filter_button.Location = new System.Drawing.Point(6, 363);
            this.filter_button.Name = "filter_button";
            this.filter_button.Size = new System.Drawing.Size(75, 25);
            this.filter_button.TabIndex = 10;
            this.filter_button.Text = "Применить";
            this.filter_button.UseVisualStyleBackColor = true;
            this.filter_button.Click += new System.EventHandler(this.filter_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "по";
            // 
            // end_dateTimePicker
            // 
            this.end_dateTimePicker.Location = new System.Drawing.Point(35, 96);
            this.end_dateTimePicker.Name = "end_dateTimePicker";
            this.end_dateTimePicker.Size = new System.Drawing.Size(154, 20);
            this.end_dateTimePicker.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "с";
            // 
            // begin_dateTimePicker
            // 
            this.begin_dateTimePicker.Location = new System.Drawing.Point(35, 56);
            this.begin_dateTimePicker.Name = "begin_dateTimePicker";
            this.begin_dateTimePicker.Size = new System.Drawing.Size(154, 20);
            this.begin_dateTimePicker.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Период времени";
            // 
            // master_checkBox
            // 
            this.master_checkBox.AutoSize = true;
            this.master_checkBox.Location = new System.Drawing.Point(9, 186);
            this.master_checkBox.Name = "master_checkBox";
            this.master_checkBox.Size = new System.Drawing.Size(64, 17);
            this.master_checkBox.TabIndex = 4;
            this.master_checkBox.Text = "Мастер";
            this.master_checkBox.UseVisualStyleBackColor = true;
            this.master_checkBox.CheckedChanged += new System.EventHandler(this.master_checkBox_CheckedChanged);
            // 
            // master_comboBox
            // 
            this.master_comboBox.DataSource = this.vusersBindingSource;
            this.master_comboBox.DisplayMember = "login";
            this.master_comboBox.Enabled = false;
            this.master_comboBox.FormattingEnabled = true;
            this.master_comboBox.Location = new System.Drawing.Point(9, 209);
            this.master_comboBox.Name = "master_comboBox";
            this.master_comboBox.Size = new System.Drawing.Size(180, 21);
            this.master_comboBox.TabIndex = 3;
            this.master_comboBox.ValueMember = "Id";
            // 
            // vusersBindingSource
            // 
            this.vusersBindingSource.DataMember = "V_users";
            this.vusersBindingSource.DataSource = this.monamurDBDataSet;
            // 
            // petName_textBox
            // 
            this.petName_textBox.Location = new System.Drawing.Point(9, 153);
            this.petName_textBox.Name = "petName_textBox";
            this.petName_textBox.Size = new System.Drawing.Size(180, 20);
            this.petName_textBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Кличка";
            // 
            // v_usersTableAdapter
            // 
            this.v_usersTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Исполнено";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 70;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 70;
            // 
            // timebeginDataGridViewTextBoxColumn
            // 
            this.timebeginDataGridViewTextBoxColumn.DataPropertyName = "time_begin";
            this.timebeginDataGridViewTextBoxColumn.HeaderText = "Время";
            this.timebeginDataGridViewTextBoxColumn.Name = "timebeginDataGridViewTextBoxColumn";
            this.timebeginDataGridViewTextBoxColumn.ReadOnly = true;
            this.timebeginDataGridViewTextBoxColumn.Width = 60;
            // 
            // idpetDataGridViewTextBoxColumn
            // 
            this.idpetDataGridViewTextBoxColumn.DataPropertyName = "id_pet";
            this.idpetDataGridViewTextBoxColumn.HeaderText = "id_pet";
            this.idpetDataGridViewTextBoxColumn.Name = "idpetDataGridViewTextBoxColumn";
            this.idpetDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpetDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Кличка";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 110;
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            this.fioDataGridViewTextBoxColumn.ReadOnly = true;
            this.fioDataGridViewTextBoxColumn.Width = 130;
            // 
            // login
            // 
            this.login.DataPropertyName = "login";
            this.login.HeaderText = "Мастер";
            this.login.Name = "login";
            this.login.ReadOnly = true;
            this.login.Width = 60;
            // 
            // sumDataGridViewTextBoxColumn
            // 
            this.sumDataGridViewTextBoxColumn.DataPropertyName = "sum";
            this.sumDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.sumDataGridViewTextBoxColumn.Name = "sumDataGridViewTextBoxColumn";
            this.sumDataGridViewTextBoxColumn.ReadOnly = true;
            this.sumDataGridViewTextBoxColumn.Width = 60;
            // 
            // payment
            // 
            this.payment.DataPropertyName = "payment";
            this.payment.HeaderText = "Оплата";
            this.payment.Name = "payment";
            this.payment.ReadOnly = true;
            // 
            // agress
            // 
            this.agress.DataPropertyName = "agress";
            this.agress.HeaderText = "Агрессия";
            this.agress.Name = "agress";
            this.agress.ReadOnly = true;
            this.agress.Width = 70;
            // 
            // infoDataGridViewTextBoxColumn
            // 
            this.infoDataGridViewTextBoxColumn.DataPropertyName = "info";
            this.infoDataGridViewTextBoxColumn.HeaderText = "Инфо";
            this.infoDataGridViewTextBoxColumn.Name = "infoDataGridViewTextBoxColumn";
            this.infoDataGridViewTextBoxColumn.ReadOnly = true;
            this.infoDataGridViewTextBoxColumn.Width = 180;
            // 
            // payment_comboBox
            // 
            this.payment_comboBox.FormattingEnabled = true;
            this.payment_comboBox.Items.AddRange(new object[] {
            "ЛЮБАЯ",
            "КАРТОЙ",
            "НАЛИЧНЫЙ РАСЧЕТ"});
            this.payment_comboBox.Location = new System.Drawing.Point(9, 259);
            this.payment_comboBox.Name = "payment_comboBox";
            this.payment_comboBox.Size = new System.Drawing.Size(180, 21);
            this.payment_comboBox.TabIndex = 12;
            this.payment_comboBox.Text = "ЛЮБАЯ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Оплата";
            // 
            // sum_textBox
            // 
            this.sum_textBox.Location = new System.Drawing.Point(129, 470);
            this.sum_textBox.Name = "sum_textBox";
            this.sum_textBox.ReadOnly = true;
            this.sum_textBox.Size = new System.Drawing.Size(72, 20);
            this.sum_textBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 473);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Сумма";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Статус";
            // 
            // status_comboBox
            // 
            this.status_comboBox.FormattingEnabled = true;
            this.status_comboBox.Items.AddRange(new object[] {
            "ВСЕ",
            "ИСПОЛНЕНО",
            "НЕ ИСПОЛНЕНО"});
            this.status_comboBox.Location = new System.Drawing.Point(9, 313);
            this.status_comboBox.Name = "status_comboBox";
            this.status_comboBox.Size = new System.Drawing.Size(180, 21);
            this.status_comboBox.TabIndex = 14;
            this.status_comboBox.Text = "ВСЕ";
            // 
            // VisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1175, 580);
            this.Controls.Add(this.sum_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.editVisit_button);
            this.Controls.Add(this.deleteVisit_button);
            this.Controls.Add(this.addVisit_button);
            this.Controls.Add(this.visitList_dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dayPlus_button);
            this.Controls.Add(this.dayMinus_button);
            this.Controls.Add(this.visits_dateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VisitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "VisitForm";
            this.Load += new System.EventHandler(this.VisitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visitList_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vvisitesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monamurDBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vusersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dayPlus_button;
        private System.Windows.Forms.Button dayMinus_button;
        private System.Windows.Forms.DateTimePicker visits_dateTimePicker;
        private System.Windows.Forms.DataGridView visitList_dataGridView;
        private MonamurDBDataSet monamurDBDataSet;
        private System.Windows.Forms.BindingSource vvisitesBindingSource;
        private MonamurDBDataSetTableAdapters.V_visitesTableAdapter v_visitesTableAdapter;
        private System.Windows.Forms.Button addVisit_button;
        private System.Windows.Forms.Button deleteVisit_button;
        private System.Windows.Forms.Button editVisit_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox master_checkBox;
        private System.Windows.Forms.ComboBox master_comboBox;
        private System.Windows.Forms.TextBox petName_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource vusersBindingSource;
        private MonamurDBDataSetTableAdapters.V_usersTableAdapter v_usersTableAdapter;
        private System.Windows.Forms.Button cleartFilter_button;
        private System.Windows.Forms.Button filter_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker end_dateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker begin_dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timebeginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn agress;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox payment_comboBox;
        private System.Windows.Forms.TextBox sum_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox status_comboBox;
    }
}