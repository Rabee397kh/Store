using Store.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store.Screens.Product
{
    public partial class ProductInfo : Form
    {
        int productid = -1;
        storeDBEntities storeDB = new storeDBEntities();
        product prod;
        string imgpath = "";
        public ProductInfo(int productid)
        {
            InitializeComponent();
            this.productid = productid;
            prod = storeDB.products.SingleOrDefault(p=> p.productid == this.productid);
            _fillCategoryCombo();
        }

        private void _fillCategoryCombo()
        {
            categoryCombo.DataSource = storeDB.categories.ToList();
            categoryCombo.DisplayMember = "name";
            categoryCombo.ValueMember = "id";
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            if(productNameTxt.Text == "" || parcodeTxt.Text == "")
            {
                MessageBox.Show("important fields empty");
                return;
            }
            prod.productname = productNameTxt.Text ;
            prod.productcode = parcodeTxt.Text;
            prod.price = priceNu.Value;
            prod.quantity= Convert.ToInt32(quantityNu.Value);
            prod.note = noteTxt.Text;
            prod.categoryid = categoryCombo.SelectedIndex + 1;

            if (imgpath != "")
            {
                string newpath = $"{Environment.CurrentDirectory}\\images\\products\\{prod.productid}.png";
                File.Copy(imgpath, newpath,true);
                prod.img = newpath;
            }

            storeDB.SaveChanges();
            MessageBox.Show($"Product {prod.productname} Edited");
        }

        private void ProductInfo_Load(object sender, EventArgs e)
        {
            

            if(prod == null)
            {
                MessageBox.Show($"Product with id :{productid} not found");
                this.Close();
                return;
            }

            productNameTxt.Text = prod.productname;
            parcodeTxt.Text = prod.productcode;
            pictureBox1.ImageLocation = prod.img;
            priceNu.Value = prod.price;
            quantityNu.Value = prod.quantity;
            noteTxt.Text = prod.note;
            categoryCombo.SelectedIndex = Convert.ToInt32(prod.categoryid -1);
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK) {
                imgpath = fileDialog.FileName;
                pictureBox1.ImageLocation = imgpath;
            }
        }
    }
}
