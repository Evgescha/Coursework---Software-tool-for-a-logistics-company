
namespace Software_tool_for_a_logistics_company
{
    partial class MaxOrderCountByTrailer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.трейлерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.трейлерBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logisticDataSet = new Software_tool_for_a_logistics_company.logisticDataSet();
            this.количествовыполненыхЗаказовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trailerOrderCountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trailerOrderCountTableAdapter = new Software_tool_for_a_logistics_company.logisticDataSetTableAdapters.TrailerOrderCountTableAdapter();
            this.трейлерTableAdapter = new Software_tool_for_a_logistics_company.logisticDataSetTableAdapters.трейлерTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.трейлерBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logisticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trailerOrderCountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.трейлерDataGridViewTextBoxColumn,
            this.количествовыполненыхЗаказовDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.trailerOrderCountBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(583, 122);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // трейлерDataGridViewTextBoxColumn
            // 
            this.трейлерDataGridViewTextBoxColumn.DataPropertyName = "Трейлер";
            this.трейлерDataGridViewTextBoxColumn.DataSource = this.трейлерBindingSource;
            this.трейлерDataGridViewTextBoxColumn.DisplayMember = "Номерной_знак";
            this.трейлерDataGridViewTextBoxColumn.HeaderText = "Трейлер";
            this.трейлерDataGridViewTextBoxColumn.Name = "трейлерDataGridViewTextBoxColumn";
            this.трейлерDataGridViewTextBoxColumn.ReadOnly = true;
            this.трейлерDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.трейлерDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.трейлерDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // трейлерBindingSource
            // 
            this.трейлерBindingSource.DataMember = "трейлер";
            this.трейлерBindingSource.DataSource = this.logisticDataSet;
            // 
            // logisticDataSet
            // 
            this.logisticDataSet.DataSetName = "logisticDataSet";
            this.logisticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // количествовыполненыхЗаказовDataGridViewTextBoxColumn
            // 
            this.количествовыполненыхЗаказовDataGridViewTextBoxColumn.DataPropertyName = "Количество_выполненыхЗаказов";
            this.количествовыполненыхЗаказовDataGridViewTextBoxColumn.HeaderText = "Количество выполненых заказов";
            this.количествовыполненыхЗаказовDataGridViewTextBoxColumn.Name = "количествовыполненыхЗаказовDataGridViewTextBoxColumn";
            this.количествовыполненыхЗаказовDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trailerOrderCountBindingSource
            // 
            this.trailerOrderCountBindingSource.DataMember = "TrailerOrderCount";
            this.trailerOrderCountBindingSource.DataSource = this.logisticDataSet;
            // 
            // trailerOrderCountTableAdapter
            // 
            this.trailerOrderCountTableAdapter.ClearBeforeFill = true;
            // 
            // трейлерTableAdapter
            // 
            this.трейлерTableAdapter.ClearBeforeFill = true;
            // 
            // MaxOrderCountByTrailer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 122);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MaxOrderCountByTrailer";
            this.Text = "Трейлер с максимальным количеством выполненных";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MaxOrderCount_FormClosing);
            this.Load += new System.EventHandler(this.MaxOrderCount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.трейлерBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logisticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trailerOrderCountBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private logisticDataSet logisticDataSet;
        private System.Windows.Forms.BindingSource trailerOrderCountBindingSource;
        private logisticDataSetTableAdapters.TrailerOrderCountTableAdapter trailerOrderCountTableAdapter;
        private System.Windows.Forms.BindingSource трейлерBindingSource;
        private logisticDataSetTableAdapters.трейлерTableAdapter трейлерTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn трейлерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествовыполненыхЗаказовDataGridViewTextBoxColumn;
    }
}