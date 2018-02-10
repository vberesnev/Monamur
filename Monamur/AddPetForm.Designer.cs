namespace Monamur
{
    partial class AddPetForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.client_textBox = new System.Windows.Forms.TextBox();
            this.selectClient_button = new System.Windows.Forms.Button();
            this.bday_radioButton = new System.Windows.Forms.RadioButton();
            this.bday_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.age_radioButton = new System.Windows.Forms.RadioButton();
            this.age_textBox = new System.Windows.Forms.TextBox();
            this.selectBreed_button = new System.Windows.Forms.Button();
            this.breed_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.about_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.animalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monamurDBDataSet = new Monamur.MonamurDBDataSet();
            this.animalsTableAdapter = new Monamur.MonamurDBDataSetTableAdapters.AnimalsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monamurDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кличка";
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(13, 30);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(229, 20);
            this.name_textBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Хозяин";
            // 
            // client_textBox
            // 
            this.client_textBox.Location = new System.Drawing.Point(16, 81);
            this.client_textBox.Name = "client_textBox";
            this.client_textBox.ReadOnly = true;
            this.client_textBox.Size = new System.Drawing.Size(191, 20);
            this.client_textBox.TabIndex = 3;
            // 
            // selectClient_button
            // 
            this.selectClient_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectClient_button.Location = new System.Drawing.Point(214, 79);
            this.selectClient_button.Name = "selectClient_button";
            this.selectClient_button.Size = new System.Drawing.Size(31, 23);
            this.selectClient_button.TabIndex = 4;
            this.selectClient_button.Text = "..";
            this.selectClient_button.UseVisualStyleBackColor = true;
            this.selectClient_button.Click += new System.EventHandler(this.selectClient_button_Click);
            // 
            // bday_radioButton
            // 
            this.bday_radioButton.AutoSize = true;
            this.bday_radioButton.Checked = true;
            this.bday_radioButton.Location = new System.Drawing.Point(16, 238);
            this.bday_radioButton.Name = "bday_radioButton";
            this.bday_radioButton.Size = new System.Drawing.Size(41, 17);
            this.bday_radioButton.TabIndex = 5;
            this.bday_radioButton.TabStop = true;
            this.bday_radioButton.Text = "ДР";
            this.bday_radioButton.UseVisualStyleBackColor = true;
            this.bday_radioButton.CheckedChanged += new System.EventHandler(this.bday_radioButton_CheckedChanged);
            // 
            // bday_dateTimePicker
            // 
            this.bday_dateTimePicker.Location = new System.Drawing.Point(63, 238);
            this.bday_dateTimePicker.Name = "bday_dateTimePicker";
            this.bday_dateTimePicker.Size = new System.Drawing.Size(182, 20);
            this.bday_dateTimePicker.TabIndex = 6;
            this.bday_dateTimePicker.ValueChanged += new System.EventHandler(this.bday_dateTimePicker_ValueChanged);
            // 
            // age_radioButton
            // 
            this.age_radioButton.AutoSize = true;
            this.age_radioButton.Location = new System.Drawing.Point(16, 273);
            this.age_radioButton.Name = "age_radioButton";
            this.age_radioButton.Size = new System.Drawing.Size(67, 17);
            this.age_radioButton.TabIndex = 7;
            this.age_radioButton.Text = "Возраст";
            this.age_radioButton.UseVisualStyleBackColor = true;
            this.age_radioButton.CheckedChanged += new System.EventHandler(this.age_radioButton_CheckedChanged);
            // 
            // age_textBox
            // 
            this.age_textBox.Location = new System.Drawing.Point(89, 272);
            this.age_textBox.Name = "age_textBox";
            this.age_textBox.ReadOnly = true;
            this.age_textBox.Size = new System.Drawing.Size(64, 20);
            this.age_textBox.TabIndex = 8;
            this.age_textBox.Text = "0";
            // 
            // selectBreed_button
            // 
            this.selectBreed_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectBreed_button.Location = new System.Drawing.Point(214, 184);
            this.selectBreed_button.Name = "selectBreed_button";
            this.selectBreed_button.Size = new System.Drawing.Size(31, 23);
            this.selectBreed_button.TabIndex = 11;
            this.selectBreed_button.Text = "..";
            this.selectBreed_button.UseVisualStyleBackColor = true;
            this.selectBreed_button.Click += new System.EventHandler(this.selectBreed_button_Click);
            // 
            // breed_textBox
            // 
            this.breed_textBox.Location = new System.Drawing.Point(16, 186);
            this.breed_textBox.Name = "breed_textBox";
            this.breed_textBox.ReadOnly = true;
            this.breed_textBox.Size = new System.Drawing.Size(191, 20);
            this.breed_textBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Порода";
            // 
            // about_textBox
            // 
            this.about_textBox.Location = new System.Drawing.Point(16, 320);
            this.about_textBox.Multiline = true;
            this.about_textBox.Name = "about_textBox";
            this.about_textBox.Size = new System.Drawing.Size(229, 111);
            this.about_textBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Информация";
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel_button.Location = new System.Drawing.Point(154, 467);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(91, 27);
            this.cancel_button.TabIndex = 15;
            this.cancel_button.Text = "Отмена";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_button.Location = new System.Drawing.Point(12, 467);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(91, 27);
            this.save_button.TabIndex = 14;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Животное";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.animalsBindingSource;
            this.comboBox1.DisplayMember = "animal";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(229, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.ValueMember = "Id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // animalsBindingSource
            // 
            this.animalsBindingSource.DataMember = "Animals";
            this.animalsBindingSource.DataSource = this.monamurDBDataSet;
            // 
            // monamurDBDataSet
            // 
            this.monamurDBDataSet.DataSetName = "MonamurDBDataSet";
            this.monamurDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // animalsTableAdapter
            // 
            this.animalsTableAdapter.ClearBeforeFill = true;
            // 
            // AddPetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 503);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.about_textBox);
            this.Controls.Add(this.selectBreed_button);
            this.Controls.Add(this.breed_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.age_textBox);
            this.Controls.Add(this.age_radioButton);
            this.Controls.Add(this.bday_dateTimePicker);
            this.Controls.Add(this.bday_radioButton);
            this.Controls.Add(this.selectClient_button);
            this.Controls.Add(this.client_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddPetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить питомца";
            this.Load += new System.EventHandler(this.AddPetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monamurDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox client_textBox;
        private System.Windows.Forms.Button selectClient_button;
        private System.Windows.Forms.RadioButton bday_radioButton;
        private System.Windows.Forms.DateTimePicker bday_dateTimePicker;
        private System.Windows.Forms.RadioButton age_radioButton;
        private System.Windows.Forms.TextBox age_textBox;
        private System.Windows.Forms.Button selectBreed_button;
        private System.Windows.Forms.TextBox breed_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox about_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private MonamurDBDataSet monamurDBDataSet;
        private System.Windows.Forms.BindingSource animalsBindingSource;
        private MonamurDBDataSetTableAdapters.AnimalsTableAdapter animalsTableAdapter;
    }
}