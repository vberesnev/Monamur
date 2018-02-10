namespace Monamur
{
    partial class EditPetForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.about_textBox = new System.Windows.Forms.TextBox();
            this.selectBreed_button = new System.Windows.Forms.Button();
            this.breed_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.age_textBox = new System.Windows.Forms.TextBox();
            this.age_radioButton = new System.Windows.Forms.RadioButton();
            this.bday_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bday_radioButton = new System.Windows.Forms.RadioButton();
            this.selectClient_button = new System.Windows.Forms.Button();
            this.client_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.alive_checkBox = new System.Windows.Forms.CheckBox();
            this.toClient_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.animal_comboBox = new System.Windows.Forms.ComboBox();
            this.animalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monamurDBDataSet = new Monamur.MonamurDBDataSet();
            this.animalsTableAdapter = new Monamur.MonamurDBDataSetTableAdapters.AnimalsTableAdapter();
            this.proced_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monamurDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel_button.Location = new System.Drawing.Point(153, 449);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(91, 27);
            this.cancel_button.TabIndex = 31;
            this.cancel_button.Text = "Отмена";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_button.Location = new System.Drawing.Point(12, 449);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(91, 27);
            this.save_button.TabIndex = 30;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Информация";
            // 
            // about_textBox
            // 
            this.about_textBox.Location = new System.Drawing.Point(12, 320);
            this.about_textBox.Multiline = true;
            this.about_textBox.Name = "about_textBox";
            this.about_textBox.Size = new System.Drawing.Size(232, 111);
            this.about_textBox.TabIndex = 28;
            // 
            // selectBreed_button
            // 
            this.selectBreed_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectBreed_button.Location = new System.Drawing.Point(213, 196);
            this.selectBreed_button.Name = "selectBreed_button";
            this.selectBreed_button.Size = new System.Drawing.Size(31, 23);
            this.selectBreed_button.TabIndex = 27;
            this.selectBreed_button.Text = "..";
            this.selectBreed_button.UseVisualStyleBackColor = true;
            this.selectBreed_button.Click += new System.EventHandler(this.selectBreed_button_Click);
            // 
            // breed_textBox
            // 
            this.breed_textBox.Location = new System.Drawing.Point(12, 198);
            this.breed_textBox.Name = "breed_textBox";
            this.breed_textBox.ReadOnly = true;
            this.breed_textBox.Size = new System.Drawing.Size(194, 20);
            this.breed_textBox.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Порода";
            // 
            // age_textBox
            // 
            this.age_textBox.Location = new System.Drawing.Point(88, 272);
            this.age_textBox.Name = "age_textBox";
            this.age_textBox.ReadOnly = true;
            this.age_textBox.Size = new System.Drawing.Size(44, 20);
            this.age_textBox.TabIndex = 24;
            this.age_textBox.Text = "0";
            // 
            // age_radioButton
            // 
            this.age_radioButton.AutoSize = true;
            this.age_radioButton.Location = new System.Drawing.Point(15, 273);
            this.age_radioButton.Name = "age_radioButton";
            this.age_radioButton.Size = new System.Drawing.Size(67, 17);
            this.age_radioButton.TabIndex = 23;
            this.age_radioButton.Text = "Возраст";
            this.age_radioButton.UseVisualStyleBackColor = true;
            this.age_radioButton.CheckedChanged += new System.EventHandler(this.age_radioButton_CheckedChanged);
            // 
            // bday_dateTimePicker
            // 
            this.bday_dateTimePicker.Location = new System.Drawing.Point(62, 238);
            this.bday_dateTimePicker.Name = "bday_dateTimePicker";
            this.bday_dateTimePicker.Size = new System.Drawing.Size(182, 20);
            this.bday_dateTimePicker.TabIndex = 22;
            // 
            // bday_radioButton
            // 
            this.bday_radioButton.AutoSize = true;
            this.bday_radioButton.Checked = true;
            this.bday_radioButton.Location = new System.Drawing.Point(15, 238);
            this.bday_radioButton.Name = "bday_radioButton";
            this.bday_radioButton.Size = new System.Drawing.Size(41, 17);
            this.bday_radioButton.TabIndex = 21;
            this.bday_radioButton.TabStop = true;
            this.bday_radioButton.Text = "ДР";
            this.bday_radioButton.UseVisualStyleBackColor = true;
            this.bday_radioButton.CheckedChanged += new System.EventHandler(this.bday_radioButton_CheckedChanged);
            // 
            // selectClient_button
            // 
            this.selectClient_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectClient_button.Location = new System.Drawing.Point(213, 104);
            this.selectClient_button.Name = "selectClient_button";
            this.selectClient_button.Size = new System.Drawing.Size(31, 23);
            this.selectClient_button.TabIndex = 20;
            this.selectClient_button.Text = "..";
            this.selectClient_button.UseVisualStyleBackColor = true;
            this.selectClient_button.Click += new System.EventHandler(this.selectClient_button_Click);
            // 
            // client_textBox
            // 
            this.client_textBox.Location = new System.Drawing.Point(15, 106);
            this.client_textBox.Name = "client_textBox";
            this.client_textBox.ReadOnly = true;
            this.client_textBox.Size = new System.Drawing.Size(191, 20);
            this.client_textBox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Хозяин";
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(12, 55);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(229, 20);
            this.name_textBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Кличка";
            // 
            // alive_checkBox
            // 
            this.alive_checkBox.AutoSize = true;
            this.alive_checkBox.Location = new System.Drawing.Point(176, 275);
            this.alive_checkBox.Name = "alive_checkBox";
            this.alive_checkBox.Size = new System.Drawing.Size(68, 17);
            this.alive_checkBox.TabIndex = 32;
            this.alive_checkBox.Text = "Активен";
            this.alive_checkBox.UseVisualStyleBackColor = true;
            // 
            // toClient_button
            // 
            this.toClient_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toClient_button.Location = new System.Drawing.Point(153, 8);
            this.toClient_button.Name = "toClient_button";
            this.toClient_button.Size = new System.Drawing.Size(88, 27);
            this.toClient_button.TabIndex = 33;
            this.toClient_button.Text = "Хозяин";
            this.toClient_button.UseVisualStyleBackColor = true;
            this.toClient_button.Click += new System.EventHandler(this.toClient_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Животное";
            // 
            // animal_comboBox
            // 
            this.animal_comboBox.DataSource = this.animalsBindingSource;
            this.animal_comboBox.DisplayMember = "animal";
            this.animal_comboBox.FormattingEnabled = true;
            this.animal_comboBox.Location = new System.Drawing.Point(12, 154);
            this.animal_comboBox.Name = "animal_comboBox";
            this.animal_comboBox.Size = new System.Drawing.Size(232, 21);
            this.animal_comboBox.TabIndex = 35;
            this.animal_comboBox.ValueMember = "Id";
            this.animal_comboBox.SelectedIndexChanged += new System.EventHandler(this.animal_comboBox_SelectedIndexChanged);
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
            // proced_button
            // 
            this.proced_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.proced_button.Location = new System.Drawing.Point(12, 8);
            this.proced_button.Name = "proced_button";
            this.proced_button.Size = new System.Drawing.Size(88, 27);
            this.proced_button.TabIndex = 36;
            this.proced_button.Text = "Процедуры";
            this.proced_button.UseVisualStyleBackColor = true;
            this.proced_button.Click += new System.EventHandler(this.proced_button_Click);
            // 
            // EditPetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 490);
            this.Controls.Add(this.proced_button);
            this.Controls.Add(this.animal_comboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.toClient_button);
            this.Controls.Add(this.alive_checkBox);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "EditPetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактировать";
            this.Load += new System.EventHandler(this.EditPetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monamurDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox about_textBox;
        private System.Windows.Forms.Button selectBreed_button;
        private System.Windows.Forms.TextBox breed_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox age_textBox;
        private System.Windows.Forms.RadioButton age_radioButton;
        private System.Windows.Forms.DateTimePicker bday_dateTimePicker;
        private System.Windows.Forms.RadioButton bday_radioButton;
        private System.Windows.Forms.Button selectClient_button;
        private System.Windows.Forms.TextBox client_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox alive_checkBox;
        private System.Windows.Forms.Button toClient_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox animal_comboBox;
        private MonamurDBDataSet monamurDBDataSet;
        private System.Windows.Forms.BindingSource animalsBindingSource;
        private MonamurDBDataSetTableAdapters.AnimalsTableAdapter animalsTableAdapter;
        private System.Windows.Forms.Button proced_button;
    }
}