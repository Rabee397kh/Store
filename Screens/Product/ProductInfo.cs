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
             prod = storeDB.products.Find(productid);
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

            if (imgpath != "")
            {
                string newpath = $"{Environment.CurrentDirectory}\\images\\products\\{prod.productid}.png";
                File.Copy(imgpath, newpath);
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
