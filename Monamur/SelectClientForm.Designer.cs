namespace Monamur
{
    partial class SelectClientForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.client_dataGridView = new System.Windows.Forms.DataGridView();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monamurDBDataSet = new Monamur.MonamurDBDataSet();
            this.clientsTableAdapter = new Monamur.MonamurDBDataSetTableAdapters.ClientsTableAdapter();
            this.cancel_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.addClient_button = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.characterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aboutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.client_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monamurDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ПОИСК";
            // 
            // search_textBox
            // 
            this.search_textBox.Location = new System.Drawing.Point(63, 13);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(140, 20);
            this.search_textBox.TabIndex = 1;
            this.search_textBox.TextChanged += new System.EventHandler(this.search_textBox_TextChanged);
            // 
            // client_dataGridView
            // 
            this.client_dataGridView.AllowUserToAddRows = false;
            this.client_dataGridView.AllowUserToDeleteRows = false;
            this.client_dataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.client_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.client_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.client_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn,
            this.characterDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.socialDataGridViewTextBoxColumn,
            this.aboutDataGridViewTextBoxColumn,
            this.bonusDataGridViewTextBoxColumn});
            this.client_dataGridView.DataSource = this.clientsBindingSource;
            this.client_dataGridView.Location = new System.Drawing.Point(16, 46);
            this.client_dataGridView.Name = "client_dataGridView";
            this.client_dataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.client_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.client_dataGridView.RowHeadersVisible = false;
            this.client_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.client_dataGridView.Size = new System.Drawing.Size(262, 366);
            this.client_dataGridView.TabIndex = 2;
            this.client_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.client_dataGridView_CellDoubleClick);
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
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel_button.Location = new System.Drawing.Point(186, 418);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(91, 25);
            this.cancel_button.TabIndex = 17;
            this.cancel_button.Text = "Отмена";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_button.Location = new System.Drawing.Point(15, 418);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(91, 25);
            this.save_button.TabIndex = 16;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // addClient_button
            // 
            this.addClient_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addClient_button.Location = new System.Drawing.Point(220, 12);
            this.addClient_button.Name = "addClient_button";
            this.addClient_button.Size = new System.Drawing.Size(57, 23);
            this.addClient_button.TabIndex = 18;
            this.addClient_button.Text = "Новый";
            this.addClient_button.UseVisualStyleBackColor = true;
            this.addClient_button.Click += new System.EventHandler(this.addClient_button_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 200;
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            this.fioDataGridViewTextBoxColumn.ReadOnly = true;
            this.fioDataGridViewTextBoxColumn.Width = 230;
            // 
            // characterDataGridViewTextBoxColumn
            // 
            this.characterDataGridViewTextBoxColumn.DataPropertyName = "character";
            this.characterDataGridViewTextBoxColumn.HeaderText = "character";
            this.characterDataGridViewTextBoxColumn.Name = "characterDataGridViewTextBoxColumn";
            this.characterDataGridViewTextBoxColumn.ReadOnly = true;
            this.characterDataGridViewTextBoxColumn.Visible = false;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Visible = false;
            // 
            // socialDataGridViewTextBoxColumn
            // 
            this.socialDataGridViewTextBoxColumn.DataPropertyName = "social";
            this.socialDataGridViewTextBoxColumn.HeaderText = "social";
            this.socialDataGridViewTextBoxColumn.Name = "socialDataGridViewTextBoxColumn";
            this.socialDataGridViewTextBoxColumn.ReadOnly = true;
            this.socialDataGridViewTextBoxColumn.Visible = false;
            // 
            // aboutDataGridViewTextBoxColumn
            // 
            this.aboutDataGridViewTextBoxColumn.DataPropertyName = "about";
            this.aboutDataGridViewTextBoxColumn.HeaderText = "about";
            this.aboutDataGridViewTextBoxColumn.Name = "aboutDataGridViewTextBoxColumn";
            this.aboutDataGridViewTextBoxColumn.ReadOnly = true;
            this.aboutDataGridViewTextBoxColumn.Visible = false;
            // 
            // bonusDataGridViewTextBoxColumn
            // 
            this.bonusDataGridViewTextBoxColumn.DataPropertyName = "bonus";
            this.bonusDataGridViewTextBoxColumn.HeaderText = "bonus";
            this.bonusDataGridViewTextBoxColumn.Name = "bonusDataGridViewTextBoxColumn";
            this.bonusDataGridViewTextBoxColumn.ReadOnly = true;
            this.bonusDataGridViewTextBoxColumn.Visible = false;
            // 
            // SelectClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 453);
            this.Controls.Add(this.addClient_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.client_dataGridView);
            this.Controls.Add(this.search_textBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SelectClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выбрать хозяина";
            this.Load += new System.EventHandler(this.SelectClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.client_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monamurDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.DataGridView client_dataGridView;
        private MonamurDBDataSet monamurDBDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private MonamurDBDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button addClient_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn characterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn socialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aboutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonusDataGridViewTextBoxColumn;
    }
}