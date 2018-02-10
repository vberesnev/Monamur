namespace Monamur
{
    partial class EditUserForm
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
            this.cancel_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.role_comboBox = new System.Windows.Forms.ComboBox();
            this.userRolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monamurDBDataSet = new Monamur.MonamurDBDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userRolesTableAdapter = new Monamur.MonamurDBDataSetTableAdapters.UserRolesTableAdapter();
            this.changePassword_button = new System.Windows.Forms.Button();
            this.usersTableAdapter = new Monamur.MonamurDBDataSetTableAdapters.UsersTableAdapter();
            this.info_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userRolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monamurDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel_button.Location = new System.Drawing.Point(123, 175);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(81, 28);
            this.cancel_button.TabIndex = 17;
            this.cancel_button.Text = "Отмена";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_button.Location = new System.Drawing.Point(14, 175);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(81, 28);
            this.save_button.TabIndex = 16;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // role_comboBox
            // 
            this.role_comboBox.DataSource = this.userRolesBindingSource;
            this.role_comboBox.DisplayMember = "role";
            this.role_comboBox.FormattingEnabled = true;
            this.role_comboBox.Location = new System.Drawing.Point(14, 133);
            this.role_comboBox.Name = "role_comboBox";
            this.role_comboBox.Size = new System.Drawing.Size(190, 21);
            this.role_comboBox.TabIndex = 15;
            this.role_comboBox.ValueMember = "Id";
            // 
            // userRolesBindingSource
            // 
            this.userRolesBindingSource.DataMember = "UserRoles";
            this.userRolesBindingSource.DataSource = this.monamurDBDataSet;
            // 
            // monamurDBDataSet
            // 
            this.monamurDBDataSet.DataSetName = "MonamurDBDataSet";
            this.monamurDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Роль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Пароль";
            // 
            // login_textBox
            // 
            this.login_textBox.Location = new System.Drawing.Point(14, 33);
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(190, 20);
            this.login_textBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Логин";
            // 
            // userRolesTableAdapter
            // 
            this.userRolesTableAdapter.ClearBeforeFill = true;
            // 
            // changePassword_button
            // 
            this.changePassword_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changePassword_button.Location = new System.Drawing.Point(77, 74);
            this.changePassword_button.Name = "changePassword_button";
            this.changePassword_button.Size = new System.Drawing.Size(127, 28);
            this.changePassword_button.TabIndex = 18;
            this.changePassword_button.Text = "Изменить пароль";
            this.changePassword_button.UseVisualStyleBackColor = true;
            this.changePassword_button.Click += new System.EventHandler(this.changePassword_button_Click);
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.Location = new System.Drawing.Point(14, 175);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(0, 13);
            this.info_label.TabIndex = 19;
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 218);
            this.Controls.Add(this.info_label);
            this.Controls.Add(this.changePassword_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.role_comboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.login_textBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактировать пользователя";
            this.Load += new System.EventHandler(this.EditUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userRolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monamurDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.ComboBox role_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login_textBox;
        private System.Windows.Forms.Label label2;
        private MonamurDBDataSet monamurDBDataSet;
        private System.Windows.Forms.BindingSource userRolesBindingSource;
        private MonamurDBDataSetTableAdapters.UserRolesTableAdapter userRolesTableAdapter;
        private System.Windows.Forms.Button changePassword_button;
        private MonamurDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Label info_label;
    }
}