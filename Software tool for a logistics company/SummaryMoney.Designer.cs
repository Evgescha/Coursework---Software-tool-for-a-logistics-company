
namespace Software_tool_for_a_logistics_company
{
    partial class SummaryMoney
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
            this.logisticDataSet = new Software_tool_for_a_logistics_company.logisticDataSet();
            this.summaryMoneyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.summaryMoneyTableAdapter = new Software_tool_for_a_logistics_company.logisticDataSetTableAdapters.SummaryMoneyTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датасозданияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датавыполненияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заработаноDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logisticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.summaryMoneyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.датасозданияDataGridViewTextBoxColumn,
            this.датавыполненияDataGridViewTextBoxColumn,
            this.заработаноDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.summaryMoneyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(532, 190);
            this.dataGridView1.TabIndex = 0;
            // 
            // logisticDataSet
            // 
            this.logisticDataSet.DataSetName = "logisticDataSet";
            this.logisticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // summaryMoneyBindingSource
            // 
            this.summaryMoneyBindingSource.DataMember = "SummaryMoney";
            this.summaryMoneyBindingSource.DataSource = this.logisticDataSet;
            // 
            // summaryMoneyTableAdapter
            // 
            this.summaryMoneyTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 43;
            // 
            // датасозданияDataGridViewTextBoxColumn
            // 
            this.датасозданияDataGridViewTextBoxColumn.DataPropertyName = "Дата_создания";
            this.датасозданияDataGridViewTextBoxColumn.HeaderText = "Дата_создания";
            this.датасозданияDataGridViewTextBoxColumn.Name = "датасозданияDataGridViewTextBoxColumn";
            this.датасозданияDataGridViewTextBoxColumn.ReadOnly = true;
            this.датасозданияDataGridViewTextBoxColumn.Width = 112;
            // 
            // датавыполненияDataGridViewTextBoxColumn
            // 
            this.датавыполненияDataGridViewTextBoxColumn.DataPropertyName = "Дата_выполнения";
            this.датавыполненияDataGridViewTextBoxColumn.HeaderText = "Дата_выполнения";
            this.датавыполненияDataGridViewTextBoxColumn.Name = "датавыполненияDataGridViewTextBoxColumn";
            this.датавыполненияDataGridViewTextBoxColumn.ReadOnly = true;
            this.датавыполненияDataGridViewTextBoxColumn.Width = 126;
            // 
            // заработаноDataGridViewTextBoxColumn
            // 
            this.заработаноDataGridViewTextBoxColumn.DataPropertyName = "Заработано";
            this.заработаноDataGridViewTextBoxColumn.HeaderText = "Заработано";
            this.заработаноDataGridViewTextBoxColumn.Name = "заработаноDataGridViewTextBoxColumn";
            this.заработаноDataGridViewTextBoxColumn.ReadOnly = true;
            this.заработаноDataGridViewTextBoxColumn.Width = 92;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Посчитать общую сумму";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SummaryMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 239);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SummaryMoney";
            this.Text = "Общая прибыль";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SummaryMoney_FormClosing);
            this.Load += new System.EventHandler(this.SummaryMoney_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logisticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.summaryMoneyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private logisticDataSet logisticDataSet;
        private System.Windows.Forms.BindingSource summaryMoneyBindingSource;
        private logisticDataSetTableAdapters.SummaryMoneyTableAdapter summaryMoneyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датасозданияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датавыполненияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn заработаноDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}