namespace Monamur
{
    partial class BreedsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BreedsForm));
            this.breeds_dataGridView = new System.Windows.Forms.DataGridView();
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.find_toolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.deleteBreed_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.breedsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monamurDBDataSet = new Monamur.MonamurDBDataSet();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.animalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.breedsTableAdapter = new Monamur.MonamurDBDataSetTableAdapters.BreedsTableAdapter();
            this.animalsTableAdapter = new Monamur.MonamurDBDataSetTableAdapters.AnimalsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.breeds_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.breedsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monamurDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // breeds_dataGridView
            // 
            this.breeds_dataGridView.AllowUserToAddRows = false;
            this.breeds_dataGridView.AllowUserToDeleteRows = false;
            this.breeds_dataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.breeds_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.breeds_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.breeds_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.breedDataGridViewTextBoxColumn,
            this.animalidDataGridViewTextBoxColumn});
            this.breeds_dataGridView.DataSource = this.breedsBindingSource;
            this.breeds_dataGridView.Location = new System.Drawing.Point(12, 33);
            this.breeds_dataGridView.Name = "breeds_dataGridView";
            this.breeds_dataGridView.RowHeadersVisible = false;
            this.breeds_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.breeds_dataGridView.Size = new System.Drawing.Size(358, 433);
            this.breeds_dataGridView.TabIndex = 0;
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator.BindingSource = this.breedsBindingSource;
            this.bindingNavigator.CountItem = null;
            this.bindingNavigator.DeleteItem = null;
            this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.toolStripSeparator1,
            this.deleteBreed_toolStripButton,
            this.find_toolStripTextBox});
            this.bindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator.MoveFirstItem = null;
            this.bindingNavigator.MoveLastItem = null;
            this.bindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = null;
            this.bindingNavigator.Size = new System.Drawing.Size(381, 25);
            this.bindingNavigator.TabIndex = 1;
            this.bindingNavigator.Text = "bindingNavigator";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // find_toolStripTextBox
            // 
            this.find_toolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.find_toolStripTextBox.Name = "find_toolStripTextBox";
            this.find_toolStripTextBox.Size = new System.Drawing.Size(140, 25);
            this.find_toolStripTextBox.TextChanged += new System.EventHandler(this.find_toolStripTextBox_TextChanged);
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_button.Location = new System.Drawing.Point(302, 0);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(68, 25);
            this.save_button.TabIndex = 2;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // deleteBreed_toolStripButton
            // 
            this.deleteBreed_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteBreed_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteBreed_toolStripButton.Image")));
            this.deleteBreed_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteBreed_toolStripButton.Name = "deleteBreed_toolStripButton";
            this.deleteBreed_toolStripButton.Size = new System.Drawing.Size(55, 22);
            this.deleteBreed_toolStripButton.Text = "Удалить";
            this.deleteBreed_toolStripButton.Click += new System.EventHandler(this.deleteBreed_toolStripButton_Click);
            // 
            // breedsBindingSource
            // 
            this.breedsBindingSource.DataMember = "Breeds";
            this.breedsBindingSource.DataSource = this.monamurDBDataSet;
            // 
            // monamurDBDataSet
            // 
            this.monamurDBDataSet.DataSetName = "MonamurDBDataSet";
            this.monamurDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // breedDataGridViewTextBoxColumn
            // 
            this.breedDataGridViewTextBoxColumn.DataPropertyName = "breed";
            this.breedDataGridViewTextBoxColumn.HeaderText = "Порода";
            this.breedDataGridViewTextBoxColumn.Name = "breedDataGridViewTextBoxColumn";
            this.breedDataGridViewTextBoxColumn.Width = 200;
            // 
            // animalidDataGridViewTextBoxColumn
            // 
            this.animalidDataGridViewTextBoxColumn.DataPropertyName = "animal_id";
            this.animalidDataGridViewTextBoxColumn.DataSource = this.animalsBindingSource;
            this.animalidDataGridViewTextBoxColumn.DisplayMember = "animal";
            this.animalidDataGridViewTextBoxColumn.HeaderText = "Животное";
            this.animalidDataGridViewTextBoxColumn.Name = "animalidDataGridViewTextBoxColumn";
            this.animalidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.animalidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.animalidDataGridViewTextBoxColumn.ValueMember = "Id";
            this.animalidDataGridViewTextBoxColumn.Width = 150;
            // 
            // animalsBindingSource
            // 
            this.animalsBindingSource.DataMember = "Animals";
            this.animalsBindingSource.DataSource = this.monamurDBDataSet;
            // 
            // breedsTableAdapter
            // 
            this.breedsTableAdapter.ClearBeforeFill = true;
            // 
            // animalsTableAdapter
            // 
            this.animalsTableAdapter.ClearBeforeFill = true;
            // 
            // BreedsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 478);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.bindingNavigator);
            this.Controls.Add(this.breeds_dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BreedsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Породы";
            this.Load += new System.EventHandler(this.BreedsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.breeds_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.breedsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monamurDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView breeds_dataGridView;
        private MonamurDBDataSet monamurDBDataSet;
        private System.Windows.Forms.BindingSource breedsBindingSource;
        private MonamurDBDataSetTableAdapters.BreedsTableAdapter breedsTableAdapter;
        private System.Windows.Forms.BindingSource animalsBindingSource;
        private MonamurDBDataSetTableAdapters.AnimalsTableAdapter animalsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn breedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn animalidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox find_toolStripTextBox;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.ToolStripButton deleteBreed_toolStripButton;
    }
}