using Store.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store.Screens.Product
{
    public partial class ProductList : Form
    {
        storeDBEntities storeDB = new storeDBEntities();
        string selected = "";
        public ProductList()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void LoadProducts()
        {
            dataGridView1.DataSource = storeDB.products.ToList();
            productsCountLbl.Text = storeDB.products.Count().ToString();
        }
        private void ProductList_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

       

        private void productNameTxt_TextChanged(object sender, EventArgs e)
        {
            if(selected == "ProductName")
            {
                dataGridView1.DataSource = storeDB.products.Where(p => p.productname.Contains(productSearchTxt.Text)).ToList();
            }else if (selected == "ParCode")
            {
                dataGridView1.DataSource = storeDB.products.Where(p => p.productcode.Contains(productSearchTxt.Text)).ToList();
            }
            
            productsCountLbl.Text = dataGridView1.Rows.Count.ToString();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            selected = comboBox1.Text;
            
        }
    }
}
