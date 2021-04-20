using CarStoreCommonLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShopWinForm
{
    public partial class Form1 : Form
    {
        Store my_store = new Store();
        BindingSource carInventoryBindingSource = new BindingSource();
        BindingSource cartBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCreateCar_Click(object sender, EventArgs e)
        {
            Car create_car = new Car(txtMake.Text, txtModel.Text, decimal.Parse(txt_price.Text));
            my_store.CarList.Add(create_car);
            carInventoryBindingSource.ResetBindings(false);
            

        }

        private void BtnAddInv_Click(object sender, EventArgs e)
        {
            // get the selected item from inventory
            Car selected = (Car)CarList.SelectedItem;
            // cast that
            // add to cart
            my_store.ShoppingList.Add(selected);
            // update list
            cartBindingSource.ResetBindings(false);
        }

        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            decimal total = my_store.CheckOut();
            LblTotal.Text = $"${total}";
            cartBindingSource.ResetBindings(false);

        }

        private void LblTotal_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carInventoryBindingSource.DataSource = my_store.
                CarList;
            CarList.DataSource = carInventoryBindingSource;
            CarList.DisplayMember = ToString();
            cartBindingSource.DataSource = my_store.ShoppingList;
            CartList.DataSource = cartBindingSource;
            CartList.DisplayMember = ToString();
           
        }
    }
}
