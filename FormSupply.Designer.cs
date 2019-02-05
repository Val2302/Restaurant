namespace Restaurant {
    partial class FormSupply {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( ) {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSupply));
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.dataGridViewSupply = new System.Windows.Forms.DataGridView();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantDataSetProducts = new Restaurant.RestaurantDataSetProducts();
            this.supplyProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantDataSetSupplyProducts = new Restaurant.RestaurantDataSetSupplyProducts();
            this.bindingNavigatorSupply = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.supplyProductsTableAdapter = new Restaurant.RestaurantDataSetSupplyProductsTableAdapters.SupplyProductsTableAdapter();
            this.productsTableAdapter1 = new Restaurant.RestaurantDataSetProductsTableAdapters.ProductsTableAdapter();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelSupplier = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantDataSetSpp = new Restaurant.RestaurantDataSetSpp();
            this.restaurantDataSetSuppliers = new Restaurant.RestaurantDataSetSuppliers();
            this.suppliersTableAdapter = new Restaurant.RestaurantDataSetSppTableAdapters.SuppliersTableAdapter();
            this.restaurantDataSetsc = new Restaurant.RestaurantDataSetsc();
            this.supplierCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierCategoriesTableAdapter = new Restaurant.RestaurantDataSetscTableAdapters.SupplierCategoriesTableAdapter();
            this.restaurantDataSetp = new Restaurant.RestaurantDataSetp();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new Restaurant.RestaurantDataSetpTableAdapters.ProductsTableAdapter();
            this.idSupplyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.countProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSetProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSetSupplyProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorSupply)).BeginInit();
            this.bindingNavigatorSupply.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSetSpp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSetSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSetsc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSetp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(275, 54);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "Ок";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(12, 9);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(26, 13);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "Код";
            // 
            // dataGridViewSupply
            // 
            this.dataGridViewSupply.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSupply.AutoGenerateColumns = false;
            this.dataGridViewSupply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupply.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSupplyDataGridViewTextBoxColumn,
            this.idProductDataGridViewTextBoxColumn,
            this.countProductDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridViewSupply.DataSource = this.supplyProductsBindingSource;
            this.dataGridViewSupply.Location = new System.Drawing.Point(0, 82);
            this.dataGridViewSupply.Name = "dataGridViewSupply";
            this.dataGridViewSupply.Size = new System.Drawing.Size(443, 245);
            this.dataGridViewSupply.TabIndex = 2;
            this.dataGridViewSupply.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSupply_CellContentClick);
            this.dataGridViewSupply.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewSupply_DataError);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.restaurantDataSetProducts;
            // 
            // restaurantDataSetProducts
            // 
            this.restaurantDataSetProducts.DataSetName = "RestaurantDataSetProducts";
            this.restaurantDataSetProducts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplyProductsBindingSource
            // 
            this.supplyProductsBindingSource.DataMember = "SupplyProducts";
            this.supplyProductsBindingSource.DataSource = this.restaurantDataSetSupplyProducts;
            // 
            // restaurantDataSetSupplyProducts
            // 
            this.restaurantDataSetSupplyProducts.DataSetName = "RestaurantDataSetSupplyProducts";
            this.restaurantDataSetSupplyProducts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorSupply
            // 
            this.bindingNavigatorSupply.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorSupply.BindingSource = this.supplyProductsBindingSource;
            this.bindingNavigatorSupply.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorSupply.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorSupply.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigatorSupply.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
            this.bindingNavigatorSupply.Location = new System.Drawing.Point(9, 54);
            this.bindingNavigatorSupply.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorSupply.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorSupply.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorSupply.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorSupply.Name = "bindingNavigatorSupply";
            this.bindingNavigatorSupply.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorSupply.Size = new System.Drawing.Size(263, 25);
            this.bindingNavigatorSupply.TabIndex = 3;
            this.bindingNavigatorSupply.Text = "bindingNavigator1";
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
            // supplyProductsTableAdapter
            // 
            this.supplyProductsTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(141, 9);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(33, 13);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "Дата";
            // 
            // labelSupplier
            // 
            this.labelSupplier.AutoSize = true;
            this.labelSupplier.Location = new System.Drawing.Point(12, 32);
            this.labelSupplier.Name = "labelSupplier";
            this.labelSupplier.Size = new System.Drawing.Size(65, 13);
            this.labelSupplier.TabIndex = 5;
            this.labelSupplier.Text = "Поставщик";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(44, 6);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(91, 20);
            this.textBoxId.TabIndex = 6;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(180, 6);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(123, 20);
            this.textBoxDate.TabIndex = 7;
            // 
            // comboBoxSupplier
            // 
            this.comboBoxSupplier.DataSource = this.suppliersBindingSource;
            this.comboBoxSupplier.DisplayMember = "nameSapplier";
            this.comboBoxSupplier.FormattingEnabled = true;
            this.comboBoxSupplier.Location = new System.Drawing.Point(83, 29);
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            this.comboBoxSupplier.Size = new System.Drawing.Size(189, 21);
            this.comboBoxSupplier.TabIndex = 8;
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.restaurantDataSetSpp;
            // 
            // restaurantDataSetSpp
            // 
            this.restaurantDataSetSpp.DataSetName = "RestaurantDataSetSpp";
            this.restaurantDataSetSpp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // restaurantDataSetSuppliers
            // 
            this.restaurantDataSetSuppliers.DataSetName = "RestaurantDataSetSuppliers";
            this.restaurantDataSetSuppliers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // restaurantDataSetsc
            // 
            this.restaurantDataSetsc.DataSetName = "RestaurantDataSetsc";
            this.restaurantDataSetsc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierCategoriesBindingSource
            // 
            this.supplierCategoriesBindingSource.DataMember = "SupplierCategories";
            this.supplierCategoriesBindingSource.DataSource = this.restaurantDataSetsc;
            // 
            // supplierCategoriesTableAdapter
            // 
            this.supplierCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // restaurantDataSetp
            // 
            this.restaurantDataSetp.DataSetName = "RestaurantDataSetp";
            this.restaurantDataSetp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.restaurantDataSetp;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // idSupplyDataGridViewTextBoxColumn
            // 
            this.idSupplyDataGridViewTextBoxColumn.DataPropertyName = "idSupply";
            this.idSupplyDataGridViewTextBoxColumn.HeaderText = "idSupply";
            this.idSupplyDataGridViewTextBoxColumn.Name = "idSupplyDataGridViewTextBoxColumn";
            this.idSupplyDataGridViewTextBoxColumn.Visible = false;
            // 
            // idProductDataGridViewTextBoxColumn
            // 
            this.idProductDataGridViewTextBoxColumn.DataPropertyName = "idProduct";
            this.idProductDataGridViewTextBoxColumn.DataSource = this.productsBindingSource1;
            this.idProductDataGridViewTextBoxColumn.DisplayMember = "nameProduct";
            this.idProductDataGridViewTextBoxColumn.HeaderText = "Продукт";
            this.idProductDataGridViewTextBoxColumn.Name = "idProductDataGridViewTextBoxColumn";
            this.idProductDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idProductDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idProductDataGridViewTextBoxColumn.ValueMember = "idProduct";
            // 
            // countProductDataGridViewTextBoxColumn
            // 
            this.countProductDataGridViewTextBoxColumn.DataPropertyName = "countProduct";
            this.countProductDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.countProductDataGridViewTextBoxColumn.Name = "countProductDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormSupply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 327);
            this.Controls.Add(this.comboBoxSupplier);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelSupplier);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.bindingNavigatorSupply);
            this.Controls.Add(this.dataGridViewSupply);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.buttonOk);
            this.Name = "FormSupply";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поставка";
            this.Load += new System.EventHandler(this.FormSupply_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSetProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSetSupplyProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorSupply)).EndInit();
            this.bindingNavigatorSupply.ResumeLayout(false);
            this.bindingNavigatorSupply.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSetSpp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSetSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSetsc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSetp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.DataGridView dataGridViewSupply;
        private System.Windows.Forms.BindingNavigator bindingNavigatorSupply;
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
        private RestaurantDataSetSupplyProducts restaurantDataSetSupplyProducts;
        private System.Windows.Forms.BindingSource supplyProductsBindingSource;
        private RestaurantDataSetSupplyProductsTableAdapters.SupplyProductsTableAdapter supplyProductsTableAdapter;
        private RestaurantDataSetProductsTableAdapters.ProductsTableAdapter productsTableAdapter1;
        private RestaurantDataSetProducts restaurantDataSetProducts;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelSupplier;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.ComboBox comboBoxSupplier;
        private RestaurantDataSetSuppliers restaurantDataSetSuppliers;
        private RestaurantDataSetSpp restaurantDataSetSpp;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private RestaurantDataSetSppTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private RestaurantDataSetsc restaurantDataSetsc;
        private System.Windows.Forms.BindingSource supplierCategoriesBindingSource;
        private RestaurantDataSetscTableAdapters.SupplierCategoriesTableAdapter supplierCategoriesTableAdapter;
        private RestaurantDataSetp restaurantDataSetp;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private RestaurantDataSetpTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSupplyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}