namespace Monamur
{
    partial class ProceduresForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.procedures_tabControl = new System.Windows.Forms.TabControl();
            this.dogs_tabPage = new System.Windows.Forms.TabPage();
            this.dogs_dataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procedurenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vproceduresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monamurDBDataSet = new Monamur.MonamurDBDataSet();
            this.cats_tabPage = new System.Windows.Forms.TabPage();
            this.cats_dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mouse_tabPage = new System.Windows.Forms.TabPage();
            this.mouse_dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.v_proceduresTableAdapter = new Monamur.MonamurDBDataSetTableAdapters.V_proceduresTableAdapter();
            this.procedures_tabControl.SuspendLayout();
            this.dogs_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogs_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vproceduresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monamurDBDataSet)).BeginInit();
            this.cats_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cats_dataGridView)).BeginInit();
            this.mouse_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mouse_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // procedures_tabControl
            // 
            this.procedures_tabControl.Controls.Add(this.dogs_tabPage);
            this.procedures_tabControl.Controls.Add(this.cats_tabPage);
            this.procedures_tabControl.Controls.Add(this.mouse_tabPage);
            this.procedures_tabControl.Location = new System.Drawing.Point(10, 40);
            this.procedures_tabControl.Name = "procedures_tabControl";
            this.procedures_tabControl.SelectedIndex = 0;
            this.procedures_tabControl.Size = new System.Drawing.Size(723, 418);
            this.procedures_tabControl.TabIndex = 0;
            // 
            // dogs_tabPage
            // 
            this.dogs_tabPage.Controls.Add(this.dogs_dataGridView);
            this.dogs_tabPage.Location = new System.Drawing.Point(4, 22);
            this.dogs_tabPage.Name = "dogs_tabPage";
            this.dogs_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.dogs_tabPage.Size = new System.Drawing.Size(715, 392);
            this.dogs_tabPage.TabIndex = 0;
            this.dogs_tabPage.Text = "Собаки";
            this.dogs_tabPage.UseVisualStyleBackColor = true;
            this.dogs_tabPage.Enter += new System.EventHandler(this.dogs_tabPage_Enter);
            // 
            // dogs_dataGridView
            // 
            this.dogs_dataGridView.AllowUserToAddRows = false;
            this.dogs_dataGridView.AllowUserToDeleteRows = false;
            this.dogs_dataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dogs_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dogs_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dogs_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.procedurenameDataGridViewTextBoxColumn,
            this.animalidDataGridViewTextBoxColumn,
            this.animalDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.infoDataGridViewTextBoxColumn});
            this.dogs_dataGridView.DataSource = this.vproceduresBindingSource;
            this.dogs_dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dogs_dataGridView.Name = "dogs_dataGridView";
            this.dogs_dataGridView.ReadOnly = true;
            this.dogs_dataGridView.RowHeadersVisible = false;
            this.dogs_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dogs_dataGridView.Size = new System.Drawing.Size(709, 383);
            this.dogs_dataGridView.TabIndex = 2;
            this.dogs_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dogs_dataGridView_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
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
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            this.costDataGridViewTextBoxColumn.Width = 80;
            // 
            // infoDataGridViewTextBoxColumn
            // 
            this.infoDataGridViewTextBoxColumn.DataPropertyName = "info";
            this.infoDataGridViewTextBoxColumn.HeaderText = "Информация";
            this.infoDataGridViewTextBoxColumn.Name = "infoDataGridViewTextBoxColumn";
            this.infoDataGridViewTextBoxColumn.ReadOnly = true;
            this.infoDataGridViewTextBoxColumn.Width = 250;
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
            // cats_tabPage
            // 
            this.cats_tabPage.Controls.Add(this.cats_dataGridView);
            this.cats_tabPage.Location = new System.Drawing.Point(4, 22);
            this.cats_tabPage.Name = "cats_tabPage";
            this.cats_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cats_tabPage.Size = new System.Drawing.Size(715, 392);
            this.cats_tabPage.TabIndex = 1;
            this.cats_tabPage.Text = "Кошки";
            this.cats_tabPage.UseVisualStyleBackColor = true;
            this.cats_tabPage.Enter += new System.EventHandler(this.cats_tabPage_Enter);
            // 
            // cats_dataGridView
            // 
            this.cats_dataGridView.AllowUserToAddRows = false;
            this.cats_dataGridView.AllowUserToDeleteRows = false;
            this.cats_dataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cats_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.cats_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cats_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.cats_dataGridView.DataSource = this.vproceduresBindingSource;
            this.cats_dataGridView.Location = new System.Drawing.Point(3, 3);
            this.cats_dataGridView.Name = "cats_dataGridView";
            this.cats_dataGridView.ReadOnly = true;
            this.cats_dataGridView.RowHeadersVisible = false;
            this.cats_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cats_dataGridView.Size = new System.Drawing.Size(709, 383);
            this.cats_dataGridView.TabIndex = 3;
            this.cats_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cats_dataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "procedure_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Процедура";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "animal_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "animal_id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "animal";
            this.dataGridViewTextBoxColumn4.HeaderText = "Животное";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "cost";
            this.dataGridViewTextBoxColumn5.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "info";
            this.dataGridViewTextBoxColumn6.HeaderText = "Информация";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 250;
            // 
            // mouse_tabPage
            // 
            this.mouse_tabPage.Controls.Add(this.mouse_dataGridView);
            this.mouse_tabPage.Location = new System.Drawing.Point(4, 22);
            this.mouse_tabPage.Name = "mouse_tabPage";
            this.mouse_tabPage.Size = new System.Drawing.Size(715, 392);
            this.mouse_tabPage.TabIndex = 2;
            this.mouse_tabPage.Text = "Грызуны";
            this.mouse_tabPage.UseVisualStyleBackColor = true;
            this.mouse_tabPage.Enter += new System.EventHandler(this.mouse_tabPage_Enter);
            // 
            // mouse_dataGridView
            // 
            this.mouse_dataGridView.AllowUserToAddRows = false;
            this.mouse_dataGridView.AllowUserToDeleteRows = false;
            this.mouse_dataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mouse_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mouse_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mouse_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.mouse_dataGridView.DataSource = this.vproceduresBindingSource;
            this.mouse_dataGridView.Location = new System.Drawing.Point(3, 3);
            this.mouse_dataGridView.Name = "mouse_dataGridView";
            this.mouse_dataGridView.ReadOnly = true;
            this.mouse_dataGridView.RowHeadersVisible = false;
            this.mouse_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mouse_dataGridView.Size = new System.Drawing.Size(709, 383);
            this.mouse_dataGridView.TabIndex = 3;
            this.mouse_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mouse_dataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn7.HeaderText = "id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "procedure_name";
            this.dataGridViewTextBoxColumn8.HeaderText = "Процедура";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 250;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "animal_id";
            this.dataGridViewTextBoxColumn9.HeaderText = "animal_id";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "animal";
            this.dataGridViewTextBoxColumn10.HeaderText = "Животное";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "cost";
            this.dataGridViewTextBoxColumn11.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 80;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "info";
            this.dataGridViewTextBoxColumn12.HeaderText = "Информация";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 250;
            // 
            // search_textBox
            // 
            this.search_textBox.Location = new System.Drawing.Point(61, 12);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(210, 20);
            this.search_textBox.TabIndex = 1;
            this.search_textBox.TextChanged += new System.EventHandler(this.search_textBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск";
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(355, 12);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(95, 23);
            this.add_button.TabIndex = 3;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(489, 13);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(95, 23);
            this.edit_button.TabIndex = 4;
            this.edit_button.Text = "Редактировать";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(625, 13);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(95, 23);
            this.delete_button.TabIndex = 5;
            this.delete_button.Text = "Удалить";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // v_proceduresTableAdapter
            // 
            this.v_proceduresTableAdapter.ClearBeforeFill = true;
            // 
            // ProceduresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 461);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.procedures_tabControl);
            this.Controls.Add(this.search_textBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ProceduresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Процедуры";
            this.Load += new System.EventHandler(this.ProceduresForm_Load);
            this.procedures_tabControl.ResumeLayout(false);
            this.dogs_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dogs_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vproceduresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monamurDBDataSet)).EndInit();
            this.cats_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cats_dataGridView)).EndInit();
            this.mouse_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mouse_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl procedures_tabControl;
        private System.Windows.Forms.TabPage dogs_tabPage;
        private System.Windows.Forms.TabPage cats_tabPage;
        private System.Windows.Forms.TabPage mouse_tabPage;
        private System.Windows.Forms.DataGridView dogs_dataGridView;
        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.Label label1;
        private MonamurDBDataSet monamurDBDataSet;
        private System.Windows.Forms.BindingSource vproceduresBindingSource;
        private MonamurDBDataSetTableAdapters.V_proceduresTableAdapter v_proceduresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn breedidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn breedDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn breedidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn breedDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView cats_dataGridView;
        private System.Windows.Forms.DataGridView mouse_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procedurenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}