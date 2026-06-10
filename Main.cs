using Store.Screens.Customers;
using Store.Screens.Product;
using Store.Screens.ProductSuppliers;
using Store.Screens.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewUser addNewUser = new AddNewUser();
            addNewUser.Show();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewProduct addNewProduct = new AddNewProduct();
            addNewProduct.Show();
        }

        private void manageProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductList productList = new ProductList();
            productList.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductList productList = new ProductList();
            productList.Show();
        }

        private void manageClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCustomers manageCustomers = new ManageCustomers();
            manageCustomers.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageCustomers manageCustomers = new ManageCustomers();
            manageCustomers.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageSuppliers manageSuppliers = new ManageSuppliers();
            manageSuppliers.Show();
        }

        private void manageSuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageSuppliers manageSuppliers = new ManageSuppliers();
            manageSuppliers.Show();
        }
    }
}
