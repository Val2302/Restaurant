using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Restaurant {
    public partial class FormSupply : Form {
        public FormSupply ( ) {
            InitializeComponent( );
        }

        private void FormSupply_Load ( object sender, EventArgs e ) {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSetp.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill( this.restaurantDataSetp.Products );
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSetsc.SupplierCategories". При необходимости она может быть перемещена или удалена.
            this.supplierCategoriesTableAdapter.Fill( this.restaurantDataSetsc.SupplierCategories );
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSetSpp.Suppliers". При необходимости она может быть перемещена или удалена.
            this.suppliersTableAdapter.Fill( this.restaurantDataSetSpp.Suppliers );
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSetSupplyProducts.SupplyProducts". При необходимости она может быть перемещена или удалена.
            this.supplyProductsTableAdapter.Fill( this.restaurantDataSetSupplyProducts.SupplyProducts );
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSetSupplyProducts.SupplyProducts". При необходимости она может быть перемещена или удалена.
            this.supplyProductsTableAdapter.Fill( this.restaurantDataSetSupplyProducts.SupplyProducts );
          
        }

        private void buttonOk_Click ( object sender, EventArgs e ) {
            this.supplyProductsTableAdapter.Update( this.restaurantDataSetSupplyProducts );
            Close( );
        }

        private void dataGridViewSupply_DataError ( object sender, DataGridViewDataErrorEventArgs e ) {

        }

        private void dataGridViewSupply_CellContentClick ( object sender, DataGridViewCellEventArgs e ) {

        }
    }
}
