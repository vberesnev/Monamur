namespace Monamur
{
    partial class LogsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.logs_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dayMinus_button = new System.Windows.Forms.Button();
            this.dayPlus_button = new System.Windows.Forms.Button();
            this.logs_dataGridView = new System.Windows.Forms.DataGridView();
            this.vlogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monamurDBDataSet = new Monamur.MonamurDBDataSet();
            this.v_logsTableAdapter = new Monamur.MonamurDBDataSetTableAdapters.V_logsTableAdapter();
            this.filterByLogin_checkBox = new System.Windows.Forms.CheckBox();
            this.login_comboBox = new System.Windows.Forms.ComboBox();
            this.vusersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_usersTableAdapter = new Monamur.MonamurDBDataSetTableAdapters.V_usersTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logtextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.logs_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlogsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monamurDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vusersBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logs_dateTimePicker
            // 
            this.logs_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logs_dateTimePicker.Location = new System.Drawing.Point(72, 49);
            this.logs_dateTimePicker.Name = "logs_dateTimePicker";
            this.logs_dateTimePicker.Size = new System.Drawing.Size(154, 22);
            this.logs_dateTimePicker.TabIndex = 0;
            this.logs_dateTimePicker.ValueChanged += new System.EventHandler(this.logs_dateTimePicker_ValueChanged);
            // 
            // dayMinus_button
            // 
            this.dayMinus_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayMinus_button.Location = new System.Drawing.Point(12, 47);
            this.dayMinus_button.Name = "dayMinus_button";
            this.dayMinus_button.Size = new System.Drawing.Size(45, 25);
            this.dayMinus_button.TabIndex = 1;
            this.dayMinus_button.Text = "<<";
            this.dayMinus_button.UseVisualStyleBackColor = true;
            this.dayMinus_button.Click += new System.EventHandler(this.dayMinus_button_Click);
            // 
            // dayPlus_button
            // 
            this.dayPlus_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayPlus_button.Location = new System.Drawing.Point(243, 48);
            this.dayPlus_button.Name = "dayPlus_button";
            this.dayPlus_button.Size = new System.Drawing.Size(45, 25);
            this.dayPlus_button.TabIndex = 2;
            this.dayPlus_button.Text = ">>";
            this.dayPlus_button.UseVisualStyleBackColor = true;
            this.dayPlus_button.Click += new System.EventHandler(this.dayPlus_button_Click);
            // 
            // logs_dataGridView
            // 
            this.logs_dataGridView.AllowUserToAddRows = false;
            this.logs_dataGridView.AllowUserToDeleteRows = false;
            this.logs_dataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.logs_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.logs_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logs_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.datetimeDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.logtextDataGridViewTextBoxColumn});
            this.logs_dataGridView.DataSource = this.vlogsBindingSource;
            this.logs_dataGridView.Location = new System.Drawing.Point(12, 88);
            this.logs_dataGridView.Name = "logs_dataGridView";
            this.logs_dataGridView.ReadOnly = true;
            this.logs_dataGridView.RowHeadersVisible = false;
            this.logs_dataGridView.RowTemplate.Height = 30;
            this.logs_dataGridView.Size = new System.Drawing.Size(1150, 480);
            this.logs_dataGridView.TabIndex = 3;
            // 
            // vlogsBindingSource
            // 
            this.vlogsBindingSource.DataMember = "V_logs";
            this.vlogsBindingSource.DataSource = this.monamurDBDataSet;
            // 
            // monamurDBDataSet
            // 
            this.monamurDBDataSet.DataSetName = "MonamurDBDataSet";
            this.monamurDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_logsTableAdapter
            // 
            this.v_logsTableAdapter.ClearBeforeFill = true;
            // 
            // filterByLogin_checkBox
            // 
            this.filterByLogin_checkBox.AutoSize = true;
            this.filterByLogin_checkBox.Location = new System.Drawing.Point(6, 26);
            this.filterByLogin_checkBox.Name = "filterByLogin_checkBox";
            this.filterByLogin_checkBox.Size = new System.Drawing.Size(77, 17);
            this.filterByLogin_checkBox.TabIndex = 4;
            this.filterByLogin_checkBox.Text = "По логину";
            this.filterByLogin_checkBox.UseVisualStyleBackColor = true;
            this.filterByLogin_checkBox.CheckedChanged += new System.EventHandler(this.filter_checkBox_CheckedChanged);
            // 
            // login_comboBox
            // 
            this.login_comboBox.DataSource = this.vusersBindingSource;
            this.login_comboBox.DisplayMember = "login";
            this.login_comboBox.Enabled = false;
            this.login_comboBox.FormattingEnabled = true;
            this.login_comboBox.Location = new System.Drawing.Point(99, 22);
            this.login_comboBox.Name = "login_comboBox";
            this.login_comboBox.Size = new System.Drawing.Size(183, 21);
            this.login_comboBox.TabIndex = 5;
            this.login_comboBox.ValueMember = "login";
            this.login_comboBox.SelectedIndexChanged += new System.EventHandler(this.login_comboBox_SelectedIndexChanged);
            // 
            // vusersBindingSource
            // 
            this.vusersBindingSource.DataMember = "V_users";
            this.vusersBindingSource.DataSource = this.monamurDBDataSet;
            // 
            // v_usersTableAdapter
            // 
            this.v_usersTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "История действий";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.filterByLogin_checkBox);
            this.groupBox1.Controls.Add(this.login_comboBox);
            this.groupBox1.Location = new System.Drawing.Point(306, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 50);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтры";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // datetimeDataGridViewTextBoxColumn
            // 
            this.datetimeDataGridViewTextBoxColumn.DataPropertyName = "datetime";
            this.datetimeDataGridViewTextBoxColumn.HeaderText = "Дата/время";
            this.datetimeDataGridViewTextBoxColumn.Name = "datetimeDataGridViewTextBoxColumn";
            this.datetimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.datetimeDataGridViewTextBoxColumn.Width = 120;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // logtextDataGridViewTextBoxColumn
            // 
            this.logtextDataGridViewTextBoxColumn.DataPropertyName = "log_text";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.logtextDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.logtextDataGridViewTextBoxColumn.HeaderText = "История";
            this.logtextDataGridViewTextBoxColumn.Name = "logtextDataGridViewTextBoxColumn";
            this.logtextDataGridViewTextBoxColumn.ReadOnly = true;
            this.logtextDataGridViewTextBoxColumn.Width = 895;
            // 
            // LogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 580);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logs_dataGridView);
            this.Controls.Add(this.dayPlus_button);
            this.Controls.Add(this.dayMinus_button);
            this.Controls.Add(this.logs_dateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LogsForm";
            this.Load += new System.EventHandler(this.LogsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logs_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlogsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monamurDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vusersBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker logs_dateTimePicker;
        private System.Windows.Forms.Button dayMinus_button;
        private System.Windows.Forms.Button dayPlus_button;
        private MonamurDBDataSetTableAdapters.V_logsTableAdapter v_logsTableAdapter;
        private MonamurDBDataSet monamurDBDataSet;
        private System.Windows.Forms.DataGridView logs_dataGridView;
        private System.Windows.Forms.BindingSource vlogsBindingSource;
        private System.Windows.Forms.CheckBox filterByLogin_checkBox;
        private System.Windows.Forms.ComboBox login_comboBox;
        private System.Windows.Forms.BindingSource vusersBindingSource;
        private MonamurDBDataSetTableAdapters.V_usersTableAdapter v_usersTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logtextDataGridViewTextBoxColumn;
    }
}