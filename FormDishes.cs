using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Restaurant {
    public partial class FormDishes : Form {
        public FormDishes ( ) {
            InitializeComponent( );
        }

        private void FormDishes_Load ( object sender, EventArgs e ) {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSetpp.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill( this.restaurantDataSetpp.Products );
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSetIngredients.Ingredients". При необходимости она может быть перемещена или удалена.
            this.ingredientsTableAdapter.Fill( this.restaurantDataSetIngredients.Ingredients );

        }

        private void buttonOk_Click ( object sender, EventArgs e ) {
            this.ingredientsTableAdapter.Update( this.restaurantDataSetIngredients );
            Close( );
        }
    }
}
