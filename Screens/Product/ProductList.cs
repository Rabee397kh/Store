using Store.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
            //storeDBEntities storeDB = new storeDBEntities();
            using (var context = new storeDBEntities())
            {
             var  result = (from s in context.products
                              join e in context.categories
                              on s.categoryid equals e.id
                              select new
                              {
                                  Productid = s.productid,
                                  Name = s.productname,
                                  Price = s.price,
                                  Category = e.name,
                                  Parcode = s.productcode,
                                  Quantity = s.quantity,
                                  Note = s.note,
                                  Image = s.img
                              }).ToList();

                
                dataGridView1.DataSource = result;
                productsCountLbl.Text = result.Count().ToString();

            }

            //dataGridView1.DataSource = storeDB.products.ToList();
            //productsCountLbl.Text = storeDB.products.Count().ToString();
        }

        private void _fillCategoryCombo()
        {
            categoryCombo.DataSource = storeDB.categories.ToList();
            categoryCombo.DisplayMember = "name";
            categoryCombo.ValueMember = "id";
        }
        private void ProductList_Load(object sender, EventArgs e)
        {
            _fillCategoryCombo();
            LoadProducts();
        }

       

        private void productNameTxt_TextChanged(object sender, EventArgs e)
        {
            if (selected == "ProductName")
            {
                using (var context = new storeDBEntities())
                {
                    string usertext = productSearchTxt.Text;
                    var result = (from s in context.products
                                  join c in context.categories
                                  on s.categoryid equals c.id
                                  where s.productname.Contains(usertext)
                                  select new
                                  {
                                      Productid = s.productid,
                                      Name = s.productname,
                                      Price = s.price,
                                      Category = c.name,
                                      Parcode = s.productcode,
                                      Quantity = s.quantity,
                                      Note = s.note,
                                      Image = s.img
                                  }).ToList();
                    dataGridView1.DataSource = result;

                }

                //dataGridView1.DataSource = storeDB.products.Where(p => p.productname.Contains(productSearchTxt.Text)).ToList();
                }else if (selected == "ParCode")
                {
                using (var context = new storeDBEntities())
                {
                    string usertext = productSearchTxt.Text;
                    var result = (from s in context.products
                                  join c in context.categories
                                  on s.categoryid equals c.id
                                  where s.productcode.Contains(usertext)
                                  select new
                                  {
                                      Productid = s.productid,
                                      Name = s.productname,
                                      Price = s.price,
                                      Category = c.name,
                                      Parcode = s.productcode,
                                      Quantity = s.quantity,
                                      Note = s.note,
                                      Image = s.img
                                  }).ToList();
                    dataGridView1.DataSource = result;

                }
                //dataGridView1.DataSource = storeDB.products.Where(p => p.productcode.Contains(productSearchTxt.Text)).ToList();
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
            productInfo.ShowDialog();
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

        private void categoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new storeDBEntities())
            {
                //int userChoice = Convert.ToInt32(categoryCombo.ValueMember);
                int userchoice = categoryCombo.SelectedIndex + 1;
                var result = (from s in context.products
                              join c in context.categories
                              on s.categoryid equals c.id
                              where c.id == userchoice
                              select new
                              {
                                  Productid = s.productid,
                                  Name = s.productname,
                                  Price = s.price,
                                  Category = c.name,
                                  Parcode = s.productcode,
                                  Quantity = s.quantity,
                                  Note = s.note,
                                  Image = s.img
                              }).ToList();
                dataGridView1.DataSource = result;
                productsCountLbl.Text = result.Count.ToString();
            }
            //dataGridView1.DataSource = storeDB.products.Where(p=> p.categoryid == ).ToList();
        }
    }
}
