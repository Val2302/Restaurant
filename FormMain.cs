using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Restaurant {

    public partial class FormMain : Form {

        public FormMain ( ) {
            InitializeComponent( );
        }

        private void FormMain_Load ( object sender, EventArgs e ) {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSetSupplierCategories.SupplierCategories". При необходимости она может быть перемещена или удалена.
            this.supplierCategoriesTableAdapter1.Fill( this.restaurantDataSetSupplierCategories.SupplierCategories );
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSetSuppliers.Suppliers". При необходимости она может быть перемещена или удалена.
            this.suppliersTableAdapter1.Fill( this.restaurantDataSetSuppliers.Suppliers );
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSetStore.Store". При необходимости она может быть перемещена или удалена.
            this.storeTableAdapter1.Fill( this.restaurantDataSetStore.Store );
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSetStaff.Staff". При необходимости она может быть перемещена или удалена.
            this.staffTableAdapter1.Fill( this.restaurantDataSetStaff.Staff );
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSetJSuppliers.JournalSupplies". При необходимости она может быть перемещена или удалена.
            this.journalSuppliesTableAdapter1.Fill( this.restaurantDataSetJSuppliers.JournalSupplies );
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSetProductVarieties.ProductVarieties". При необходимости она может быть перемещена или удалена.
            this.productVarietiesTableAdapter.Fill( this.restaurantDataSetProductVarieties.ProductVarieties );
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSetProducts.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter1.Fill( this.restaurantDataSetProducts.Products );
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSetPositions.Positions". При необходимости она может быть перемещена или удалена.
            this.positionsTableAdapter1.Fill( this.restaurantDataSetPositions.Positions );
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSetJOrders.JournalOrders". При необходимости она может быть перемещена или удалена.
            this.journalOrdersTableAdapter1.Fill( this.restaurantDataSetJOrders.JournalOrders );
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSetDishesVarieties.DishVarieties". При необходимости она может быть перемещена или удалена.
            this.dishVarietiesTableAdapter.Fill( this.restaurantDataSetDishesVarieties.DishVarieties );
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSetDishes.Dishes". При необходимости она может быть перемещена или удалена.
            this.dishesTableAdapter1.Fill( this.restaurantDataSetDishes.Dishes );
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSetBoards.Boards". При необходимости она может быть перемещена или удалена.
            this.boardsTableAdapter1.Fill( this.restaurantDataSetBoards.Boards );
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSetBoardsCategories.BoardCategories". При необходимости она может быть перемещена или удалена.
            this.boardCategoriesTableAdapter1.Fill( this.restaurantDataSetBoardsCategories.BoardCategories );
// TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSet1.Suppliers". При необходимости она может быть перемещена или удалена.

        }

        private void dataGridViewDishes_MouseClick ( object sender, MouseEventArgs e ) {
            if ( dataGridViewDishes.CurrentCell.RowIndex > 0 ) {
                FormDishes fd = new FormDishes( );
                fd.Show( );
            }
        }

        private void dataGridViewSupply_MouseClick ( object sender, MouseEventArgs e ) {
            if ( dataGridViewSupply.CurrentCell.RowIndex > 0 ) {
                FormSupply fs = new FormSupply( );
                fs.Show( );
            }
        }

        private void dataGridViewOrder_CellClick ( object sender, DataGridViewCellEventArgs e ) {
            if (    dataGridViewOrder.CurrentCell.RowIndex > 0 ) {
                FormOrders fo = new FormOrders( );
                fo.Show( );
            }
        }

        private void buttonAbout_Click ( object sender, EventArgs e ) {
            FormAbout fa = new FormAbout( );
            fa.Show( );
        }

    }

}
