namespace Monamur
{
    partial class AuthForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.auth_button = new System.Windows.Forms.Button();
            this.v_usersTableAdapter = new Monamur.MonamurDBDataSetTableAdapters.V_usersTableAdapter();
            this.monamurDBDataSet = new Monamur.MonamurDBDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.login_comboBox = new System.Windows.Forms.ComboBox();
            this.vusersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.monamurDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vusersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(26, 154);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.Size = new System.Drawing.Size(153, 20);
            this.password_textBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // auth_button
            // 
            this.auth_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auth_button.Location = new System.Drawing.Point(54, 204);
            this.auth_button.Name = "auth_button";
            this.auth_button.Size = new System.Drawing.Size(85, 30);
            this.auth_button.TabIndex = 4;
            this.auth_button.Text = "Войти";
            this.auth_button.UseVisualStyleBackColor = true;
            this.auth_button.Click += new System.EventHandler(this.auth_button_Click);
            // 
            // v_usersTableAdapter
            // 
            this.v_usersTableAdapter.ClearBeforeFill = true;
            // 
            // monamurDBDataSet
            // 
            this.monamurDBDataSet.DataSetName = "MonamurDBDataSet";
            this.monamurDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Monamur IS";
            // 
            // login_comboBox
            // 
            this.login_comboBox.DataSource = this.vusersBindingSource;
            this.login_comboBox.DisplayMember = "login";
            this.login_comboBox.FormattingEnabled = true;
            this.login_comboBox.Location = new System.Drawing.Point(26, 103);
            this.login_comboBox.Name = "login_comboBox";
            this.login_comboBox.Size = new System.Drawing.Size(153, 21);
            this.login_comboBox.TabIndex = 6;
            this.login_comboBox.ValueMember = "Id";
            // 
            // vusersBindingSource
            // 
            this.vusersBindingSource.DataMember = "V_users";
            this.vusersBindingSource.DataSource = this.monamurDBDataSet;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 246);
            this.Controls.Add(this.login_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.auth_button);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Activated += new System.EventHandler(this.AuthForm_Activated);
            this.Load += new System.EventHandler(this.AuthForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AuthForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.monamurDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vusersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button auth_button;
        private MonamurDBDataSetTableAdapters.V_usersTableAdapter v_usersTableAdapter;
        private MonamurDBDataSet monamurDBDataSet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox login_comboBox;
        private System.Windows.Forms.BindingSource vusersBindingSource;
    }
}

