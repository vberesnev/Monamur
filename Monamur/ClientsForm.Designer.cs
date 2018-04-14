


namespace Monamur
{
    partial class ClientsForm
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
            this.clients_dataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.characterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sms = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.socialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aboutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monamurDBDataSet = new Monamur.MonamurDBDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.dlt_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.smsAll_radioButton = new System.Windows.Forms.RadioButton();
            this.smsNo_radioButton = new System.Windows.Forms.RadioButton();
            this.smsYes_radioButton = new System.Windows.Forms.RadioButton();
            this.bonus_checkBox = new System.Windows.Forms.CheckBox();
            this.mark_checkBox = new System.Windows.Forms.CheckBox();
            this.cleartFilter_button = new System.Windows.Forms.Button();
            this.filter_button = new System.Windows.Forms.Button();
            this.bonusEnd_textBox = new System.Windows.Forms.TextBox();
            this.bonusStart_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.markEnd_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.markStart_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.phone_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clientsTableAdapter = new Monamur.MonamurDBDataSetTableAdapters.ClientsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clients_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monamurDBDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.markEnd_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markStart_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // clients_dataGridView
            // 
            this.clients_dataGridView.AllowUserToAddRows = false;
            this.clients_dataGridView.AllowUserToDeleteRows = false;
            this.clients_dataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clients_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.clients_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clients_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn,
            this.characterDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.sms,
            this.socialDataGridViewTextBoxColumn,
            this.aboutDataGridViewTextBoxColumn,
            this.bonusDataGridViewTextBoxColumn});
            this.clients_dataGridView.DataSource = this.clientsBindingSource;
            this.clients_dataGridView.Location = new System.Drawing.Point(227, 88);
            this.clients_dataGridView.Name = "clients_dataGridView";
            this.clients_dataGridView.ReadOnly = true;
            this.clients_dataGridView.RowHeadersVisible = false;
            this.clients_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clients_dataGridView.Size = new System.Drawing.Size(935, 480);
            this.clients_dataGridView.TabIndex = 0;
            this.clients_dataGridView.DoubleClick += new System.EventHandler(this.clients_dataGridView_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            this.fioDataGridViewTextBoxColumn.ReadOnly = true;
            this.fioDataGridViewTextBoxColumn.Width = 200;
            // 
            // characterDataGridViewTextBoxColumn
            // 
            this.characterDataGridViewTextBoxColumn.DataPropertyName = "character";
            this.characterDataGridViewTextBoxColumn.HeaderText = "Оценка";
            this.characterDataGridViewTextBoxColumn.Name = "characterDataGridViewTextBoxColumn";
            this.characterDataGridViewTextBoxColumn.ReadOnly = true;
            this.characterDataGridViewTextBoxColumn.Width = 50;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 120;
            // 
            // sms
            // 
            this.sms.DataPropertyName = "sms";
            this.sms.HeaderText = "СМС";
            this.sms.Name = "sms";
            this.sms.ReadOnly = true;
            this.sms.Width = 30;
            // 
            // socialDataGridViewTextBoxColumn
            // 
            this.socialDataGridViewTextBoxColumn.DataPropertyName = "social";
            this.socialDataGridViewTextBoxColumn.HeaderText = "Соц. сети";
            this.socialDataGridViewTextBoxColumn.Name = "socialDataGridViewTextBoxColumn";
            this.socialDataGridViewTextBoxColumn.ReadOnly = true;
            this.socialDataGridViewTextBoxColumn.Width = 170;
            // 
            // aboutDataGridViewTextBoxColumn
            // 
            this.aboutDataGridViewTextBoxColumn.DataPropertyName = "about";
            this.aboutDataGridViewTextBoxColumn.HeaderText = "Инфо";
            this.aboutDataGridViewTextBoxColumn.Name = "aboutDataGridViewTextBoxColumn";
            this.aboutDataGridViewTextBoxColumn.ReadOnly = true;
            this.aboutDataGridViewTextBoxColumn.Width = 290;
            // 
            // bonusDataGridViewTextBoxColumn
            // 
            this.bonusDataGridViewTextBoxColumn.DataPropertyName = "bonus";
            this.bonusDataGridViewTextBoxColumn.HeaderText = "Бонусы";
            this.bonusDataGridViewTextBoxColumn.Name = "bonusDataGridViewTextBoxColumn";
            this.bonusDataGridViewTextBoxColumn.ReadOnly = true;
            this.bonusDataGridViewTextBoxColumn.Width = 50;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.monamurDBDataSet;
            // 
            // monamurDBDataSet
            // 
            this.monamurDBDataSet.DataSetName = "MonamurDBDataSet";
            this.monamurDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список клиентов";
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
            // search_textBox
            // 
            this.search_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_textBox.Location = new System.Drawing.Point(279, 46);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(331, 22);
            this.search_textBox.TabIndex = 5;
            this.search_textBox.TextChanged += new System.EventHandler(this.search_textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(228, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ПОИСК";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.bonus_checkBox);
            this.groupBox2.Controls.Add(this.mark_checkBox);
            this.groupBox2.Controls.Add(this.cleartFilter_button);
            this.groupBox2.Controls.Add(this.filter_button);
            this.groupBox2.Controls.Add(this.bonusEnd_textBox);
            this.groupBox2.Controls.Add(this.bonusStart_textBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.markEnd_numericUpDown);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.markStart_numericUpDown);
            this.groupBox2.Controls.Add(this.phone_textBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 371);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фильтр";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.smsAll_radioButton);
            this.groupBox1.Controls.Add(this.smsNo_radioButton);
            this.groupBox1.Controls.Add(this.smsYes_radioButton);
            this.groupBox1.Location = new System.Drawing.Point(9, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 89);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "СМС информирование";
            // 
            // smsAll_radioButton
            // 
            this.smsAll_radioButton.AutoSize = true;
            this.smsAll_radioButton.Checked = true;
            this.smsAll_radioButton.Location = new System.Drawing.Point(7, 66);
            this.smsAll_radioButton.Name = "smsAll_radioButton";
            this.smsAll_radioButton.Size = new System.Drawing.Size(44, 17);
            this.smsAll_radioButton.TabIndex = 2;
            this.smsAll_radioButton.TabStop = true;
            this.smsAll_radioButton.Text = "Все";
            this.smsAll_radioButton.UseVisualStyleBackColor = true;
            // 
            // smsNo_radioButton
            // 
            this.smsNo_radioButton.AutoSize = true;
            this.smsNo_radioButton.Location = new System.Drawing.Point(7, 43);
            this.smsNo_radioButton.Name = "smsNo_radioButton";
            this.smsNo_radioButton.Size = new System.Drawing.Size(44, 17);
            this.smsNo_radioButton.TabIndex = 1;
            this.smsNo_radioButton.Text = "Нет";
            this.smsNo_radioButton.UseVisualStyleBackColor = true;
            // 
            // smsYes_radioButton
            // 
            this.smsYes_radioButton.AutoSize = true;
            this.smsYes_radioButton.Location = new System.Drawing.Point(7, 20);
            this.smsYes_radioButton.Name = "smsYes_radioButton";
            this.smsYes_radioButton.Size = new System.Drawing.Size(40, 17);
            this.smsYes_radioButton.TabIndex = 0;
            this.smsYes_radioButton.Text = "Да";
            this.smsYes_radioButton.UseVisualStyleBackColor = true;
            // 
            // bonus_checkBox
            // 
            this.bonus_checkBox.AutoSize = true;
            this.bonus_checkBox.Location = new System.Drawing.Point(9, 262);
            this.bonus_checkBox.Name = "bonus_checkBox";
            this.bonus_checkBox.Size = new System.Drawing.Size(100, 17);
            this.bonus_checkBox.TabIndex = 20;
            this.bonus_checkBox.Text = "По бонусам от";
            this.bonus_checkBox.UseVisualStyleBackColor = true;
            this.bonus_checkBox.CheckedChanged += new System.EventHandler(this.bonus_checkBox_CheckedChanged);
            // 
            // mark_checkBox
            // 
            this.mark_checkBox.AutoSize = true;
            this.mark_checkBox.Location = new System.Drawing.Point(9, 182);
            this.mark_checkBox.Name = "mark_checkBox";
            this.mark_checkBox.Size = new System.Drawing.Size(99, 17);
            this.mark_checkBox.TabIndex = 19;
            this.mark_checkBox.Text = "По  оценке  от";
            this.mark_checkBox.UseVisualStyleBackColor = true;
            this.mark_checkBox.CheckedChanged += new System.EventHandler(this.mark_checkBox_CheckedChanged);
            // 
            // cleartFilter_button
            // 
            this.cleartFilter_button.Location = new System.Drawing.Point(114, 331);
            this.cleartFilter_button.Name = "cleartFilter_button";
            this.cleartFilter_button.Size = new System.Drawing.Size(75, 25);
            this.cleartFilter_button.TabIndex = 18;
            this.cleartFilter_button.Text = "Очистить";
            this.cleartFilter_button.UseVisualStyleBackColor = true;
            this.cleartFilter_button.Click += new System.EventHandler(this.cleartFilter_button_Click);
            // 
            // filter_button
            // 
            this.filter_button.Location = new System.Drawing.Point(6, 331);
            this.filter_button.Name = "filter_button";
            this.filter_button.Size = new System.Drawing.Size(75, 25);
            this.filter_button.TabIndex = 17;
            this.filter_button.Text = "Применить";
            this.filter_button.UseVisualStyleBackColor = true;
            this.filter_button.Click += new System.EventHandler(this.filter_button_Click);
            // 
            // bonusEnd_textBox
            // 
            this.bonusEnd_textBox.Enabled = false;
            this.bonusEnd_textBox.Location = new System.Drawing.Point(114, 288);
            this.bonusEnd_textBox.Name = "bonusEnd_textBox";
            this.bonusEnd_textBox.Size = new System.Drawing.Size(57, 20);
            this.bonusEnd_textBox.TabIndex = 16;
            this.bonusEnd_textBox.Text = "0";
            // 
            // bonusStart_textBox
            // 
            this.bonusStart_textBox.Enabled = false;
            this.bonusStart_textBox.Location = new System.Drawing.Point(114, 259);
            this.bonusStart_textBox.Name = "bonusStart_textBox";
            this.bonusStart_textBox.Size = new System.Drawing.Size(57, 20);
            this.bonusStart_textBox.TabIndex = 15;
            this.bonusStart_textBox.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "до";
            // 
            // markEnd_numericUpDown
            // 
            this.markEnd_numericUpDown.Enabled = false;
            this.markEnd_numericUpDown.Location = new System.Drawing.Point(114, 212);
            this.markEnd_numericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.markEnd_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.markEnd_numericUpDown.Name = "markEnd_numericUpDown";
            this.markEnd_numericUpDown.Size = new System.Drawing.Size(57, 20);
            this.markEnd_numericUpDown.TabIndex = 12;
            this.markEnd_numericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "до";
            // 
            // markStart_numericUpDown
            // 
            this.markStart_numericUpDown.Enabled = false;
            this.markStart_numericUpDown.Location = new System.Drawing.Point(114, 179);
            this.markStart_numericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.markStart_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.markStart_numericUpDown.Name = "markStart_numericUpDown";
            this.markStart_numericUpDown.Size = new System.Drawing.Size(57, 20);
            this.markStart_numericUpDown.TabIndex = 10;
            this.markStart_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // phone_textBox
            // 
            this.phone_textBox.Location = new System.Drawing.Point(9, 48);
            this.phone_textBox.Name = "phone_textBox";
            this.phone_textBox.Size = new System.Drawing.Size(180, 20);
            this.phone_textBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Номер телефона";
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 580);
            this.Controls.Add(this.dlt_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.search_textBox);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clients_dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ClientsForm";
            this.Load += new System.EventHandler(this.ClientsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clients_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monamurDBDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.markEnd_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markStart_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView clients_dataGridView;
        private MonamurDBDataSet monamurDBDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private MonamurDBDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dlt_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox phone_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bonusEnd_textBox;
        private System.Windows.Forms.TextBox bonusStart_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown markEnd_numericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown markStart_numericUpDown;
        private System.Windows.Forms.CheckBox bonus_checkBox;
        private System.Windows.Forms.CheckBox mark_checkBox;
        private System.Windows.Forms.Button cleartFilter_button;
        private System.Windows.Forms.Button filter_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn characterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sms;
        private System.Windows.Forms.DataGridViewTextBoxColumn socialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aboutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonusDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton smsAll_radioButton;
        private System.Windows.Forms.RadioButton smsNo_radioButton;
        private System.Windows.Forms.RadioButton smsYes_radioButton;
    }
}