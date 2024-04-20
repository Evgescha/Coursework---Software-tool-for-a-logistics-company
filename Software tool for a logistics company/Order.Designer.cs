
namespace Software_tool_for_a_logistics_company
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пунктотправленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пунктназначенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.расстояниекмDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.весDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоместDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.трейлерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.трейлерBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logisticDataSet = new Software_tool_for_a_logistics_company.logisticDataSet();
            this.водительDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.водительBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.датасозданияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датавыполненияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказTableAdapter = new Software_tool_for_a_logistics_company.logisticDataSetTableAdapters.заказTableAdapter();
            this.трейлерTableAdapter = new Software_tool_for_a_logistics_company.logisticDataSetTableAdapters.трейлерTableAdapter();
            this.водительTableAdapter = new Software_tool_for_a_logistics_company.logisticDataSetTableAdapters.водительTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.трейлерBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logisticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.водительBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.bindingNavigator1);
            this.groupBox1.Location = new System.Drawing.Point(10, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1190, 396);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Заказы";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.пунктотправленияDataGridViewTextBoxColumn,
            this.пунктназначенияDataGridViewTextBoxColumn,
            this.расстояниекмDataGridViewTextBoxColumn,
            this.весDataGridViewTextBoxColumn,
            this.количествоместDataGridViewTextBoxColumn,
            this.трейлерDataGridViewTextBoxColumn,
            this.водительDataGridViewTextBoxColumn,
            this.датасозданияDataGridViewTextBoxColumn,
            this.датавыполненияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.заказBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1178, 346);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.заказBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 16);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1184, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
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
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(70, 22);
            this.toolStripButton1.Text = "Сохранить";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 43;
            // 
            // пунктотправленияDataGridViewTextBoxColumn
            // 
            this.пунктотправленияDataGridViewTextBoxColumn.DataPropertyName = "Пункт_отправления";
            this.пунктотправленияDataGridViewTextBoxColumn.HeaderText = "Пункт_отправления";
            this.пунктотправленияDataGridViewTextBoxColumn.Name = "пунктотправленияDataGridViewTextBoxColumn";
            this.пунктотправленияDataGridViewTextBoxColumn.Width = 133;
            // 
            // пунктназначенияDataGridViewTextBoxColumn
            // 
            this.пунктназначенияDataGridViewTextBoxColumn.DataPropertyName = "Пункт_назначения";
            this.пунктназначенияDataGridViewTextBoxColumn.HeaderText = "Пункт_назначения";
            this.пунктназначенияDataGridViewTextBoxColumn.Name = "пунктназначенияDataGridViewTextBoxColumn";
            this.пунктназначенияDataGridViewTextBoxColumn.Width = 127;
            // 
            // расстояниекмDataGridViewTextBoxColumn
            // 
            this.расстояниекмDataGridViewTextBoxColumn.DataPropertyName = "Расстояние_км";
            this.расстояниекмDataGridViewTextBoxColumn.HeaderText = "Расстояние_км";
            this.расстояниекмDataGridViewTextBoxColumn.Name = "расстояниекмDataGridViewTextBoxColumn";
            this.расстояниекмDataGridViewTextBoxColumn.Width = 112;
            // 
            // весDataGridViewTextBoxColumn
            // 
            this.весDataGridViewTextBoxColumn.DataPropertyName = "Вес";
            this.весDataGridViewTextBoxColumn.HeaderText = "Вес";
            this.весDataGridViewTextBoxColumn.Name = "весDataGridViewTextBoxColumn";
            this.весDataGridViewTextBoxColumn.Width = 51;
            // 
            // количествоместDataGridViewTextBoxColumn
            // 
            this.количествоместDataGridViewTextBoxColumn.DataPropertyName = "Количество_мест";
            this.количествоместDataGridViewTextBoxColumn.HeaderText = "Количество_мест";
            this.количествоместDataGridViewTextBoxColumn.Name = "количествоместDataGridViewTextBoxColumn";
            this.количествоместDataGridViewTextBoxColumn.Width = 122;
            // 
            // трейлерDataGridViewTextBoxColumn
            // 
            this.трейлерDataGridViewTextBoxColumn.DataPropertyName = "Трейлер";
            this.трейлерDataGridViewTextBoxColumn.DataSource = this.трейлерBindingSource;
            this.трейлерDataGridViewTextBoxColumn.DisplayMember = "Номерной_знак";
            this.трейлерDataGridViewTextBoxColumn.HeaderText = "Трейлер";
            this.трейлерDataGridViewTextBoxColumn.Name = "трейлерDataGridViewTextBoxColumn";
            this.трейлерDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.трейлерDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.трейлерDataGridViewTextBoxColumn.ValueMember = "ID";
            this.трейлерDataGridViewTextBoxColumn.Width = 75;
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
            // водительDataGridViewTextBoxColumn
            // 
            this.водительDataGridViewTextBoxColumn.DataPropertyName = "Водитель";
            this.водительDataGridViewTextBoxColumn.DataSource = this.водительBindingSource;
            this.водительDataGridViewTextBoxColumn.DisplayMember = "ФИО";
            this.водительDataGridViewTextBoxColumn.HeaderText = "Водитель";
            this.водительDataGridViewTextBoxColumn.Name = "водительDataGridViewTextBoxColumn";
            this.водительDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.водительDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.водительDataGridViewTextBoxColumn.ValueMember = "ID";
            this.водительDataGridViewTextBoxColumn.Width = 80;
            // 
            // водительBindingSource
            // 
            this.водительBindingSource.DataMember = "водитель";
            this.водительBindingSource.DataSource = this.logisticDataSet;
            // 
            // датасозданияDataGridViewTextBoxColumn
            // 
            this.датасозданияDataGridViewTextBoxColumn.DataPropertyName = "Дата_создания";
            this.датасозданияDataGridViewTextBoxColumn.HeaderText = "Дата_создания";
            this.датасозданияDataGridViewTextBoxColumn.Name = "датасозданияDataGridViewTextBoxColumn";
            this.датасозданияDataGridViewTextBoxColumn.Width = 112;
            // 
            // датавыполненияDataGridViewTextBoxColumn
            // 
            this.датавыполненияDataGridViewTextBoxColumn.DataPropertyName = "Дата_выполнения";
            this.датавыполненияDataGridViewTextBoxColumn.HeaderText = "Дата_выполнения";
            this.датавыполненияDataGridViewTextBoxColumn.Name = "датавыполненияDataGridViewTextBoxColumn";
            this.датавыполненияDataGridViewTextBoxColumn.Width = 126;
            // 
            // заказBindingSource
            // 
            this.заказBindingSource.DataMember = "заказ";
            this.заказBindingSource.DataSource = this.logisticDataSet;
            // 
            // заказTableAdapter
            // 
            this.заказTableAdapter.ClearBeforeFill = true;
            // 
            // трейлерTableAdapter
            // 
            this.трейлерTableAdapter.ClearBeforeFill = true;
            // 
            // водительTableAdapter
            // 
            this.водительTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Рейсы без напарника";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(203, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Сброс";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 449);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Order";
            this.Text = "Заказы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Order_FormClosing);
            this.Load += new System.EventHandler(this.Order_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.трейлерBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logisticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.водительBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private logisticDataSet logisticDataSet;
        private System.Windows.Forms.BindingSource заказBindingSource;
        private logisticDataSetTableAdapters.заказTableAdapter заказTableAdapter;
        private System.Windows.Forms.BindingSource трейлерBindingSource;
        private logisticDataSetTableAdapters.трейлерTableAdapter трейлерTableAdapter;
        private System.Windows.Forms.BindingSource водительBindingSource;
        private logisticDataSetTableAdapters.водительTableAdapter водительTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пунктотправленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пунктназначенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn расстояниекмDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn весDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоместDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn трейлерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn водительDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датасозданияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датавыполненияDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}