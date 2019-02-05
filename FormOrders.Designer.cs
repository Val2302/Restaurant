namespace Restaurant {
    partial class FormOrders {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrders));
            this.comboBoxBoard = new System.Windows.Forms.ComboBox();
            this.boardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantDataSetBoards = new Restaurant.RestaurantDataSetBoards();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelBoard = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.bindingNavigatorSupply = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.orderDishesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantDataSetOrderDishes = new Restaurant.RestaurantDataSetOrderDishes();
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
            this.dataGridViewSupply = new System.Windows.Forms.DataGridView();
            this.dishesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantDataSetDishes = new Restaurant.RestaurantDataSetDishes();
            this.labelId = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.orderDishesTableAdapter = new Restaurant.RestaurantDataSetOrderDishesTableAdapters.OrderDishesTableAdapter();
            this.boardsTableAdapter1 = new Restaurant.RestaurantDataSetBoardsTableAdapters.BoardsTableAdapter();
            this.dishesTableAdapter1 = new Restaurant.RestaurantDataSetDishesTableAdapters.DishesTableAdapter();
            this.restaurantDataSetd = new Restaurant.RestaurantDataSetd();
            this.dishesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dishesTableAdapter = new Restaurant.RestaurantDataSetdTableAdapters.DishesTableAdapter();
            this.idOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.boardsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSetBoards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorSupply)).BeginInit();
            this.bindingNavigatorSupply.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDishesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSetOrderDishes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSetDishes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSetd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxBoard
            // 
            this.comboBoxBoard.DataSource = this.boardsBindingSource;
            this.comboBoxBoard.DisplayMember = "numberBoard";
            this.comboBoxBoard.FormattingEnabled = true;
            this.comboBoxBoard.Location = new System.Drawing.Point(63, 29);
            this.comboBoxBoard.Name = "comboBoxBoard";
            this.comboBoxBoard.Size = new System.Drawing.Size(74, 21);
            this.comboBoxBoard.TabIndex = 17;
            // 
            // boardsBindingSource
            // 
            this.boardsBindingSource.DataMember = "Boards";
            this.boardsBindingSource.DataSource = this.restaurantDataSetBoards;
            // 
            // restaurantDataSetBoards
            // 
            this.restaurantDataSetBoards.DataSetName = "RestaurantDataSetBoards";
            this.restaurantDataSetBoards.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(182, 6);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(123, 20);
            this.textBoxDate.TabIndex = 16;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(46, 6);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(91, 20);
            this.textBoxId.TabIndex = 15;
            // 
            // labelBoard
            // 
            this.labelBoard.AutoSize = true;
            this.labelBoard.Location = new System.Drawing.Point(14, 32);
            this.labelBoard.Name = "labelBoard";
            this.labelBoard.Size = new System.Drawing.Size(43, 13);
            this.labelBoard.TabIndex = 14;
            this.labelBoard.Text = "Столик";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(143, 9);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(33, 13);
            this.labelDate.TabIndex = 13;
            this.labelDate.Text = "Дата";
            // 
            // bindingNavigatorSupply
            // 
            this.bindingNavigatorSupply.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorSupply.BindingSource = this.orderDishesBindingSource;
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
            this.bindingNavigatorSupply.Location = new System.Drawing.Point(11, 54);
            this.bindingNavigatorSupply.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorSupply.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorSupply.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorSupply.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorSupply.Name = "bindingNavigatorSupply";
            this.bindingNavigatorSupply.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorSupply.Size = new System.Drawing.Size(263, 25);
            this.bindingNavigatorSupply.TabIndex = 12;
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
            // orderDishesBindingSource
            // 
            this.orderDishesBindingSource.DataMember = "OrderDishes";
            this.orderDishesBindingSource.DataSource = this.restaurantDataSetOrderDishes;
            // 
            // restaurantDataSetOrderDishes
            // 
            this.restaurantDataSetOrderDishes.DataSetName = "RestaurantDataSetOrderDishes";
            this.restaurantDataSetOrderDishes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dataGridViewSupply
            // 
            this.dataGridViewSupply.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSupply.AutoGenerateColumns = false;
            this.dataGridViewSupply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupply.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOrderDataGridViewTextBoxColumn,
            this.idDishDataGridViewTextBoxColumn});
            this.dataGridViewSupply.DataSource = this.orderDishesBindingSource;
            this.dataGridViewSupply.Location = new System.Drawing.Point(2, 82);
            this.dataGridViewSupply.Name = "dataGridViewSupply";
            this.dataGridViewSupply.Size = new System.Drawing.Size(378, 232);
            this.dataGridViewSupply.TabIndex = 11;
            // 
            // dishesBindingSource
            // 
            this.dishesBindingSource.DataMember = "Dishes";
            this.dishesBindingSource.DataSource = this.restaurantDataSetDishes;
            // 
            // restaurantDataSetDishes
            // 
            this.restaurantDataSetDishes.DataSetName = "RestaurantDataSetDishes";
            this.restaurantDataSetDishes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(14, 9);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(26, 13);
            this.labelId.TabIndex = 10;
            this.labelId.Text = "Код";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(277, 54);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 9;
            this.buttonOk.Text = "Ок";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // orderDishesTableAdapter
            // 
            this.orderDishesTableAdapter.ClearBeforeFill = true;
            // 
            // boardsTableAdapter1
            // 
            this.boardsTableAdapter1.ClearBeforeFill = true;
            // 
            // dishesTableAdapter1
            // 
            this.dishesTableAdapter1.ClearBeforeFill = true;
            // 
            // restaurantDataSetd
            // 
            this.restaurantDataSetd.DataSetName = "RestaurantDataSetd";
            this.restaurantDataSetd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dishesBindingSource1
            // 
            this.dishesBindingSource1.DataMember = "Dishes";
            this.dishesBindingSource1.DataSource = this.restaurantDataSetd;
            // 
            // dishesTableAdapter
            // 
            this.dishesTableAdapter.ClearBeforeFill = true;
            // 
            // idOrderDataGridViewTextBoxColumn
            // 
            this.idOrderDataGridViewTextBoxColumn.DataPropertyName = "idOrder";
            this.idOrderDataGridViewTextBoxColumn.HeaderText = "idOrder";
            this.idOrderDataGridViewTextBoxColumn.Name = "idOrderDataGridViewTextBoxColumn";
            this.idOrderDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDishDataGridViewTextBoxColumn
            // 
            this.idDishDataGridViewTextBoxColumn.DataPropertyName = "idDish";
            this.idDishDataGridViewTextBoxColumn.DataSource = this.dishesBindingSource1;
            this.idDishDataGridViewTextBoxColumn.DisplayMember = "nameDish";
            this.idDishDataGridViewTextBoxColumn.HeaderText = "Блюдо";
            this.idDishDataGridViewTextBoxColumn.Name = "idDishDataGridViewTextBoxColumn";
            this.idDishDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idDishDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idDishDataGridViewTextBoxColumn.ValueMember = "idDish";
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 316);
            this.Controls.Add(this.comboBoxBoard);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelBoard);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.bindingNavigatorSupply);
            this.Controls.Add(this.dataGridViewSupply);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.buttonOk);
            this.Name = "FormOrders";
            this.Text = "Заказ";
            this.Load += new System.EventHandler(this.FormOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boardsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSetBoards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorSupply)).EndInit();
            this.bindingNavigatorSupply.ResumeLayout(false);
            this.bindingNavigatorSupply.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDishesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSetOrderDishes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSetDishes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSetd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxBoard;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelBoard;
        private System.Windows.Forms.Label labelDate;
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
        private System.Windows.Forms.DataGridView dataGridViewSupply;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button buttonOk;
        private RestaurantDataSetOrderDishes restaurantDataSetOrderDishes;
        private System.Windows.Forms.BindingSource orderDishesBindingSource;
        private RestaurantDataSetOrderDishesTableAdapters.OrderDishesTableAdapter orderDishesTableAdapter;
        private System.Windows.Forms.BindingSource boardsBindingSource;
        private RestaurantDataSetBoards restaurantDataSetBoards;
        private RestaurantDataSetBoardsTableAdapters.BoardsTableAdapter boardsTableAdapter1;
        private System.Windows.Forms.BindingSource dishesBindingSource;
        private RestaurantDataSetDishes restaurantDataSetDishes;
        private RestaurantDataSetDishesTableAdapters.DishesTableAdapter dishesTableAdapter1;
        private RestaurantDataSetd restaurantDataSetd;
        private System.Windows.Forms.BindingSource dishesBindingSource1;
        private RestaurantDataSetdTableAdapters.DishesTableAdapter dishesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idDishDataGridViewTextBoxColumn;
    }
}