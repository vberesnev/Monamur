namespace Monamur
{
    partial class AddClientForm
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
            this.fio_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.character_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.phone_textBox = new System.Windows.Forms.TextBox();
            this.social_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.about_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bonus_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.sms_checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.character_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // fio_textBox
            // 
            this.fio_textBox.Location = new System.Drawing.Point(12, 35);
            this.fio_textBox.Name = "fio_textBox";
            this.fio_textBox.Size = new System.Drawing.Size(229, 20);
            this.fio_textBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Характер";
            // 
            // character_numericUpDown
            // 
            this.character_numericUpDown.Location = new System.Drawing.Point(12, 82);
            this.character_numericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.character_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.character_numericUpDown.Name = "character_numericUpDown";
            this.character_numericUpDown.Size = new System.Drawing.Size(76, 20);
            this.character_numericUpDown.TabIndex = 3;
            this.character_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Телефон";
            // 
            // phone_textBox
            // 
            this.phone_textBox.Location = new System.Drawing.Point(12, 134);
            this.phone_textBox.Name = "phone_textBox";
            this.phone_textBox.Size = new System.Drawing.Size(229, 20);
            this.phone_textBox.TabIndex = 5;
            // 
            // social_textBox
            // 
            this.social_textBox.Location = new System.Drawing.Point(12, 216);
            this.social_textBox.Name = "social_textBox";
            this.social_textBox.Size = new System.Drawing.Size(229, 20);
            this.social_textBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Соц. сети";
            // 
            // about_textBox
            // 
            this.about_textBox.Location = new System.Drawing.Point(12, 264);
            this.about_textBox.Multiline = true;
            this.about_textBox.Name = "about_textBox";
            this.about_textBox.Size = new System.Drawing.Size(229, 94);
            this.about_textBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Информация";
            // 
            // bonus_textBox
            // 
            this.bonus_textBox.Location = new System.Drawing.Point(12, 389);
            this.bonus_textBox.Name = "bonus_textBox";
            this.bonus_textBox.Size = new System.Drawing.Size(76, 20);
            this.bonus_textBox.TabIndex = 11;
            this.bonus_textBox.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Бонусы";
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_button.Location = new System.Drawing.Point(12, 425);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(91, 27);
            this.save_button.TabIndex = 12;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel_button.Location = new System.Drawing.Point(150, 425);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(91, 27);
            this.cancel_button.TabIndex = 13;
            this.cancel_button.Text = "Отмена";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // sms_checkBox
            // 
            this.sms_checkBox.AutoSize = true;
            this.sms_checkBox.Location = new System.Drawing.Point(12, 169);
            this.sms_checkBox.Name = "sms_checkBox";
            this.sms_checkBox.Size = new System.Drawing.Size(204, 17);
            this.sms_checkBox.TabIndex = 14;
            this.sms_checkBox.Text = "Согласен на получение сообщений";
            this.sms_checkBox.UseVisualStyleBackColor = true;
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 461);
            this.Controls.Add(this.sms_checkBox);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.bonus_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.about_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.social_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phone_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.character_numericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fio_textBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новый клиент";
            ((System.ComponentModel.ISupportInitialize)(this.character_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fio_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown character_numericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phone_textBox;
        private System.Windows.Forms.TextBox social_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox about_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bonus_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.CheckBox sms_checkBox;
    }
}