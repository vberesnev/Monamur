namespace Monamur
{
    partial class EditClientForm
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
            this.cancel_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.bonus_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.about_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.social_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phone_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.character_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.fio_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.character_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel_button.Location = new System.Drawing.Point(152, 392);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(91, 27);
            this.cancel_button.TabIndex = 27;
            this.cancel_button.Text = "Отмена";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_button.Location = new System.Drawing.Point(14, 392);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(91, 27);
            this.save_button.TabIndex = 26;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // bonus_textBox
            // 
            this.bonus_textBox.Location = new System.Drawing.Point(14, 349);
            this.bonus_textBox.Name = "bonus_textBox";
            this.bonus_textBox.Size = new System.Drawing.Size(91, 20);
            this.bonus_textBox.TabIndex = 25;
            this.bonus_textBox.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Бонусы";
            // 
            // about_textBox
            // 
            this.about_textBox.Location = new System.Drawing.Point(14, 224);
            this.about_textBox.Multiline = true;
            this.about_textBox.Name = "about_textBox";
            this.about_textBox.Size = new System.Drawing.Size(229, 94);
            this.about_textBox.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Информация";
            // 
            // social_textBox
            // 
            this.social_textBox.Location = new System.Drawing.Point(14, 176);
            this.social_textBox.Name = "social_textBox";
            this.social_textBox.Size = new System.Drawing.Size(229, 20);
            this.social_textBox.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Соц. сети";
            // 
            // phone_textBox
            // 
            this.phone_textBox.Location = new System.Drawing.Point(14, 127);
            this.phone_textBox.Name = "phone_textBox";
            this.phone_textBox.Size = new System.Drawing.Size(229, 20);
            this.phone_textBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Телефон";
            // 
            // character_numericUpDown
            // 
            this.character_numericUpDown.Location = new System.Drawing.Point(14, 75);
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
            this.character_numericUpDown.Size = new System.Drawing.Size(91, 20);
            this.character_numericUpDown.TabIndex = 17;
            this.character_numericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Характер";
            // 
            // fio_textBox
            // 
            this.fio_textBox.Location = new System.Drawing.Point(14, 28);
            this.fio_textBox.Name = "fio_textBox";
            this.fio_textBox.Size = new System.Drawing.Size(229, 20);
            this.fio_textBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "ФИО";
            // 
            // EditClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 431);
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
            this.Name = "EditClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.character_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.TextBox bonus_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox about_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox social_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phone_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown character_numericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fio_textBox;
        private System.Windows.Forms.Label label1;
    }
}