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

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int productId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            MessageBox.Show(productId.ToString());
            ProductInfo productInfo = new ProductInfo(productId);
            productInfo.Show();
            LoadProducts();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!(MessageBox.Show("are you sure","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes))
            {
                return;
            }
            int productid =(int)dataGridView1.CurrentRow.Cells[0].Value;
            if(productid != -1)
            {
                product pr = storeDB.products.Find( productid);
                storeDB.products.Remove(pr);
                storeDB.SaveChanges();
                MessageBox.Show($"product :{productid} Deleted Succefully!");
                LoadProducts();
            }
        }
    }
}
