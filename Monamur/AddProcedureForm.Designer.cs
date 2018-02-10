﻿namespace Monamur
{
    partial class AddProcedureForm
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
            this.procedure_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.animal_comboBox = new System.Windows.Forms.ComboBox();
            this.animalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monamurDBDataSet = new Monamur.MonamurDBDataSet();
            this.animalsTableAdapter = new Monamur.MonamurDBDataSetTableAdapters.AnimalsTableAdapter();
            this.cost_textBox = new System.Windows.Forms.TextBox();
            this.cost_checkBox = new System.Windows.Forms.CheckBox();
            this.info_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monamurDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Процедура";
            // 
            // procedure_textBox
            // 
            this.procedure_textBox.Location = new System.Drawing.Point(12, 32);
            this.procedure_textBox.Multiline = true;
            this.procedure_textBox.Name = "procedure_textBox";
            this.procedure_textBox.Size = new System.Drawing.Size(210, 50);
            this.procedure_textBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Животное";
            // 
            // animal_comboBox
            // 
            this.animal_comboBox.DataSource = this.animalsBindingSource;
            this.animal_comboBox.DisplayMember = "animal";
            this.animal_comboBox.FormattingEnabled = true;
            this.animal_comboBox.Location = new System.Drawing.Point(13, 110);
            this.animal_comboBox.Name = "animal_comboBox";
            this.animal_comboBox.Size = new System.Drawing.Size(210, 21);
            this.animal_comboBox.TabIndex = 3;
            this.animal_comboBox.ValueMember = "Id";
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
            // cost_textBox
            // 
            this.cost_textBox.Enabled = false;
            this.cost_textBox.Location = new System.Drawing.Point(156, 150);
            this.cost_textBox.Name = "cost_textBox";
            this.cost_textBox.Size = new System.Drawing.Size(66, 20);
            this.cost_textBox.TabIndex = 8;
            // 
            // cost_checkBox
            // 
            this.cost_checkBox.AutoSize = true;
            this.cost_checkBox.Location = new System.Drawing.Point(12, 150);
            this.cost_checkBox.Name = "cost_checkBox";
            this.cost_checkBox.Size = new System.Drawing.Size(136, 17);
            this.cost_checkBox.TabIndex = 9;
            this.cost_checkBox.Text = "Фиксированная цена";
            this.cost_checkBox.UseVisualStyleBackColor = true;
            this.cost_checkBox.CheckedChanged += new System.EventHandler(this.cost_checkBox_CheckedChanged);
            // 
            // info_textBox
            // 
            this.info_textBox.Location = new System.Drawing.Point(12, 199);
            this.info_textBox.Multiline = true;
            this.info_textBox.Name = "info_textBox";
            this.info_textBox.Size = new System.Drawing.Size(210, 64);
            this.info_textBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Информация";
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(12, 281);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 12;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(148, 281);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 13;
            this.cancel_button.Text = "Отмена";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // AddProcedureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 316);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.info_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cost_checkBox);
            this.Controls.Add(this.cost_textBox);
            this.Controls.Add(this.animal_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.procedure_textBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AddProcedureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новая процедура";
            this.Load += new System.EventHandler(this.AddProcedureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monamurDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox procedure_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox animal_comboBox;
        private MonamurDBDataSet monamurDBDataSet;
        private System.Windows.Forms.BindingSource animalsBindingSource;
        private MonamurDBDataSetTableAdapters.AnimalsTableAdapter animalsTableAdapter;
        private System.Windows.Forms.TextBox cost_textBox;
        private System.Windows.Forms.CheckBox cost_checkBox;
        private System.Windows.Forms.TextBox info_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button cancel_button;
    }
}