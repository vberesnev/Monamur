namespace Monamur
{
    partial class PetsAllProceduresForm
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
            this.petsVisitProc_dataGridView = new System.Windows.Forms.DataGridView();
            this.monamurDBDataSet = new Monamur.MonamurDBDataSet();
            this.vallVisitProceduresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_allVisitProceduresTableAdapter = new Monamur.MonamurDBDataSetTableAdapters.V_allVisitProceduresTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procedurenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.petsVisitProc_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monamurDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vallVisitProceduresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // petsVisitProc_dataGridView
            // 
            this.petsVisitProc_dataGridView.AllowUserToAddRows = false;
            this.petsVisitProc_dataGridView.AllowUserToDeleteRows = false;
            this.petsVisitProc_dataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.petsVisitProc_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.petsVisitProc_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.petsVisitProc_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.agressDataGridViewTextBoxColumn,
            this.procedurenameDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.petIDDataGridViewTextBoxColumn});
            this.petsVisitProc_dataGridView.DataSource = this.vallVisitProceduresBindingSource;
            this.petsVisitProc_dataGridView.Location = new System.Drawing.Point(3, 44);
            this.petsVisitProc_dataGridView.Name = "petsVisitProc_dataGridView";
            this.petsVisitProc_dataGridView.ReadOnly = true;
            this.petsVisitProc_dataGridView.RowHeadersVisible = false;
            this.petsVisitProc_dataGridView.Size = new System.Drawing.Size(689, 281);
            this.petsVisitProc_dataGridView.TabIndex = 1;
            // 
            // monamurDBDataSet
            // 
            this.monamurDBDataSet.DataSetName = "MonamurDBDataSet";
            this.monamurDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vallVisitProceduresBindingSource
            // 
            this.vallVisitProceduresBindingSource.DataMember = "V_allVisitProcedures";
            this.vallVisitProceduresBindingSource.DataSource = this.monamurDBDataSet;
            // 
            // v_allVisitProceduresTableAdapter
            // 
            this.v_allVisitProceduresTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 80;
            // 
            // agressDataGridViewTextBoxColumn
            // 
            this.agressDataGridViewTextBoxColumn.DataPropertyName = "agress";
            this.agressDataGridViewTextBoxColumn.HeaderText = "Агрессивность";
            this.agressDataGridViewTextBoxColumn.Name = "agressDataGridViewTextBoxColumn";
            this.agressDataGridViewTextBoxColumn.ReadOnly = true;
            this.agressDataGridViewTextBoxColumn.Width = 90;
            // 
            // procedurenameDataGridViewTextBoxColumn
            // 
            this.procedurenameDataGridViewTextBoxColumn.DataPropertyName = "procedure_name";
            this.procedurenameDataGridViewTextBoxColumn.HeaderText = "Название процедуры";
            this.procedurenameDataGridViewTextBoxColumn.Name = "procedurenameDataGridViewTextBoxColumn";
            this.procedurenameDataGridViewTextBoxColumn.ReadOnly = true;
            this.procedurenameDataGridViewTextBoxColumn.Width = 250;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            this.costDataGridViewTextBoxColumn.Width = 70;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Исполнено";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.ReadOnly = true;
            this.statusDataGridViewCheckBoxColumn.Width = 80;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Мастер";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            this.loginDataGridViewTextBoxColumn.Width = 90;
            // 
            // petIDDataGridViewTextBoxColumn
            // 
            this.petIDDataGridViewTextBoxColumn.DataPropertyName = "PetID";
            this.petIDDataGridViewTextBoxColumn.HeaderText = "PetID";
            this.petIDDataGridViewTextBoxColumn.Name = "petIDDataGridViewTextBoxColumn";
            this.petIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.petIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // PetsAllProceduresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 328);
            this.Controls.Add(this.petsVisitProc_dataGridView);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PetsAllProceduresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PetsAllProceduresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.petsVisitProc_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monamurDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vallVisitProceduresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView petsVisitProc_dataGridView;
        private MonamurDBDataSet monamurDBDataSet;
        private System.Windows.Forms.BindingSource vallVisitProceduresBindingSource;
        private MonamurDBDataSetTableAdapters.V_allVisitProceduresTableAdapter v_allVisitProceduresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procedurenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petIDDataGridViewTextBoxColumn;
    }
}