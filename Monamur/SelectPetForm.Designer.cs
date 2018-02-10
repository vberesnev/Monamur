namespace Monamur
{
    partial class SelectPetForm
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
            this.addClient_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.pets_dataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breedidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aboutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aliveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vpetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monamurDBDataSet = new Monamur.MonamurDBDataSet();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.v_petsTableAdapter = new Monamur.MonamurDBDataSetTableAdapters.V_petsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pets_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monamurDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // addClient_button
            // 
            this.addClient_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addClient_button.Location = new System.Drawing.Point(394, 10);
            this.addClient_button.Name = "addClient_button";
            this.addClient_button.Size = new System.Drawing.Size(91, 25);
            this.addClient_button.TabIndex = 24;
            this.addClient_button.Text = "Новый";
            this.addClient_button.UseVisualStyleBackColor = true;
            this.addClient_button.Click += new System.EventHandler(this.addClient_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel_button.Location = new System.Drawing.Point(394, 418);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(91, 25);
            this.cancel_button.TabIndex = 23;
            this.cancel_button.Text = "Отмена";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_button.Location = new System.Drawing.Point(278, 419);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(91, 25);
            this.save_button.TabIndex = 22;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
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
            this.breedidDataGridViewTextBoxColumn,
            this.breedDataGridViewTextBoxColumn,
            this.clientidDataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn,
            this.aboutDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.aliveDataGridViewCheckBoxColumn});
            this.pets_dataGridView.DataSource = this.vpetsBindingSource;
            this.pets_dataGridView.Location = new System.Drawing.Point(12, 46);
            this.pets_dataGridView.Name = "pets_dataGridView";
            this.pets_dataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pets_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.pets_dataGridView.RowHeadersVisible = false;
            this.pets_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pets_dataGridView.Size = new System.Drawing.Size(473, 366);
            this.pets_dataGridView.TabIndex = 21;
            this.pets_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pets_dataGridView_CellDoubleClick);
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
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // bdayDataGridViewTextBoxColumn
            // 
            this.bdayDataGridViewTextBoxColumn.DataPropertyName = "bday";
            this.bdayDataGridViewTextBoxColumn.HeaderText = "bday";
            this.bdayDataGridViewTextBoxColumn.Name = "bdayDataGridViewTextBoxColumn";
            this.bdayDataGridViewTextBoxColumn.ReadOnly = true;
            this.bdayDataGridViewTextBoxColumn.Visible = false;
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
            this.aboutDataGridViewTextBoxColumn.HeaderText = "about";
            this.aboutDataGridViewTextBoxColumn.Name = "aboutDataGridViewTextBoxColumn";
            this.aboutDataGridViewTextBoxColumn.ReadOnly = true;
            this.aboutDataGridViewTextBoxColumn.Visible = false;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            this.ageDataGridViewTextBoxColumn.Visible = false;
            // 
            // aliveDataGridViewCheckBoxColumn
            // 
            this.aliveDataGridViewCheckBoxColumn.DataPropertyName = "alive";
            this.aliveDataGridViewCheckBoxColumn.HeaderText = "alive";
            this.aliveDataGridViewCheckBoxColumn.Name = "aliveDataGridViewCheckBoxColumn";
            this.aliveDataGridViewCheckBoxColumn.ReadOnly = true;
            this.aliveDataGridViewCheckBoxColumn.Visible = false;
            // 
            // vpetsBindingSource
            // 
            this.vpetsBindingSource.DataMember = "V_pets";
            this.vpetsBindingSource.DataSource = this.monamurDBDataSet;
            // 
            // monamurDBDataSet
            // 
            this.monamurDBDataSet.DataSetName = "MonamurDBDataSet";
            this.monamurDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // search_textBox
            // 
            this.search_textBox.Location = new System.Drawing.Point(59, 13);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(255, 20);
            this.search_textBox.TabIndex = 20;
            this.search_textBox.TextChanged += new System.EventHandler(this.search_textBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "ПОИСК";
            // 
            // v_petsTableAdapter
            // 
            this.v_petsTableAdapter.ClearBeforeFill = true;
            // 
            // SelectPetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 456);
            this.Controls.Add(this.addClient_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.pets_dataGridView);
            this.Controls.Add(this.search_textBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SelectPetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выбрать питомца";
            this.Load += new System.EventHandler(this.SelectPetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pets_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monamurDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addClient_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.DataGridView pets_dataGridView;
        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.Label label1;
        private MonamurDBDataSet monamurDBDataSet;
        private System.Windows.Forms.BindingSource vpetsBindingSource;
        private MonamurDBDataSetTableAdapters.V_petsTableAdapter v_petsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn breedidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn breedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aboutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aliveDataGridViewCheckBoxColumn;
    }
}