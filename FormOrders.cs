using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Restaurant {
    public partial class FormOrders : Form {
        public FormOrders ( ) {
            InitializeComponent( );
        }

        private void buttonOk_Click ( object sender, EventArgs e ) {
            this.orderDishesTableAdapter.Update( this.restaurantDataSetOrderDishes );
            Close( );
        }

        private void FormOrders_Load ( object sender, EventArgs e ) {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSetd.Dishes". При необходимости она может быть перемещена или удалена.
            this.dishesTableAdapter.Fill( this.restaurantDataSetd.Dishes );
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSetOrderDishes.OrderDishes". При необходимости она может быть перемещена или удалена.
            this.orderDishesTableAdapter.Fill( this.restaurantDataSetOrderDishes.OrderDishes );

        }
    }
}
