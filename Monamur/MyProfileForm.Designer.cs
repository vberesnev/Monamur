namespace Monamur
{
    partial class MyProfileForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.saveProfile_button = new System.Windows.Forms.Button();
            this.usersTableAdapter = new Monamur.MonamurDBDataSetTableAdapters.UsersTableAdapter();
            this.changePass_button = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Мой профиль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин";
            // 
            // login_textBox
            // 
            this.login_textBox.Location = new System.Drawing.Point(12, 65);
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(140, 20);
            this.login_textBox.TabIndex = 4;
            // 
            // saveProfile_button
            // 
            this.saveProfile_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveProfile_button.Location = new System.Drawing.Point(12, 164);
            this.saveProfile_button.Name = "saveProfile_button";
            this.saveProfile_button.Size = new System.Drawing.Size(140, 27);
            this.saveProfile_button.TabIndex = 6;
            this.saveProfile_button.Text = "Сохранить профиль";
            this.saveProfile_button.UseVisualStyleBackColor = true;
            this.saveProfile_button.Click += new System.EventHandler(this.saveProfile_button_Click);
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // changePass_button
            // 
            this.changePass_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changePass_button.Location = new System.Drawing.Point(12, 100);
            this.changePass_button.Name = "changePass_button";
            this.changePass_button.Size = new System.Drawing.Size(140, 27);
            this.changePass_button.TabIndex = 7;
            this.changePass_button.Text = "Изменить пароль";
            this.changePass_button.UseVisualStyleBackColor = true;
            this.changePass_button.Click += new System.EventHandler(this.changePass_button_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(14, 139);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 13);
            this.infoLabel.TabIndex = 8;
            // 
            // MyProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1175, 580);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.changePass_button);
            this.Controls.Add(this.saveProfile_button);
            this.Controls.Add(this.login_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MyProfileForm";
            this.Load += new System.EventHandler(this.MyProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login_textBox;
        private System.Windows.Forms.Button saveProfile_button;
        private MonamurDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Button changePass_button;
        private System.Windows.Forms.Label infoLabel;
    }
}