namespace Monamur
{
    partial class UsersListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.userList_dataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vusersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monamurDBDataSet = new Monamur.MonamurDBDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delUser_button = new System.Windows.Forms.Button();
            this.editUser_button = new System.Windows.Forms.Button();
            this.addUser_button = new System.Windows.Forms.Button();
            this.v_usersTableAdapter = new Monamur.MonamurDBDataSetTableAdapters.V_usersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.userList_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vusersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monamurDBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список пользователей";
            // 
            // userList_dataGridView
            // 
            this.userList_dataGridView.AllowUserToAddRows = false;
            this.userList_dataGridView.AllowUserToDeleteRows = false;
            this.userList_dataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userList_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.userList_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userList_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.userList_dataGridView.DataSource = this.vusersBindingSource;
            this.userList_dataGridView.Location = new System.Drawing.Point(12, 40);
            this.userList_dataGridView.Name = "userList_dataGridView";
            this.userList_dataGridView.ReadOnly = true;
            this.userList_dataGridView.RowHeadersVisible = false;
            this.userList_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userList_dataGridView.Size = new System.Drawing.Size(308, 215);
            this.userList_dataGridView.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            this.loginDataGridViewTextBoxColumn.Width = 150;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Роль";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.ReadOnly = true;
            this.roleDataGridViewTextBoxColumn.Width = 150;
            // 
            // vusersBindingSource
            // 
            this.vusersBindingSource.DataMember = "V_users";
            this.vusersBindingSource.DataSource = this.monamurDBDataSet;
            // 
            // monamurDBDataSet
            // 
            this.monamurDBDataSet.DataSetName = "MonamurDBDataSet";
            this.monamurDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.delUser_button);
            this.groupBox1.Controls.Add(this.editUser_button);
            this.groupBox1.Controls.Add(this.addUser_button);
            this.groupBox1.Location = new System.Drawing.Point(344, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 215);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление";
            // 
            // delUser_button
            // 
            this.delUser_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delUser_button.Location = new System.Drawing.Point(6, 147);
            this.delUser_button.Name = "delUser_button";
            this.delUser_button.Size = new System.Drawing.Size(110, 25);
            this.delUser_button.TabIndex = 2;
            this.delUser_button.Text = "Удалить";
            this.delUser_button.UseVisualStyleBackColor = true;
            this.delUser_button.Click += new System.EventHandler(this.delUser_button_Click);
            // 
            // editUser_button
            // 
            this.editUser_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editUser_button.Location = new System.Drawing.Point(6, 86);
            this.editUser_button.Name = "editUser_button";
            this.editUser_button.Size = new System.Drawing.Size(110, 25);
            this.editUser_button.TabIndex = 1;
            this.editUser_button.Text = "Редактировать";
            this.editUser_button.UseVisualStyleBackColor = true;
            this.editUser_button.Click += new System.EventHandler(this.editUser_button_Click);
            // 
            // addUser_button
            // 
            this.addUser_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addUser_button.Location = new System.Drawing.Point(6, 28);
            this.addUser_button.Name = "addUser_button";
            this.addUser_button.Size = new System.Drawing.Size(110, 25);
            this.addUser_button.TabIndex = 0;
            this.addUser_button.Text = "Добавить";
            this.addUser_button.UseVisualStyleBackColor = true;
            this.addUser_button.Click += new System.EventHandler(this.addUser_button_Click);
            // 
            // v_usersTableAdapter
            // 
            this.v_usersTableAdapter.ClearBeforeFill = true;
            // 
            // UsersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 580);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.userList_dataGridView);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "UsersListForm";
            this.Load += new System.EventHandler(this.UsersListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userList_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vusersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monamurDBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView userList_dataGridView;
        private MonamurDBDataSet monamurDBDataSet;
        private System.Windows.Forms.BindingSource vusersBindingSource;
        private MonamurDBDataSetTableAdapters.V_usersTableAdapter v_usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button delUser_button;
        private System.Windows.Forms.Button editUser_button;
        private System.Windows.Forms.Button addUser_button;
    }
}