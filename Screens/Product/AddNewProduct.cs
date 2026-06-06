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
    public partial class AddNewProduct : Form
    {
        storeDBEntities storeDB = new storeDBEntities();
        string imgpath = "";
        public AddNewProduct()
        {
            InitializeComponent();
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            product newProduct = new product
            {
                productname = productNameTxt.Text,
                productcode = parcodeTxt.Text,
                price = priceNu.Value,
                quantity = Convert.ToInt32(quantityNu.Value),
                note = noteTxt.Text
                
            };
            storeDB.products.Add(newProduct);
            storeDB.SaveChanges();

            string newPath = $"{Environment.CurrentDirectory}\\images\\products\\{newProduct.productid}.png";
            File.Copy(imgpath, newPath);
            newProduct.img = newPath;
            storeDB.SaveChanges();

            MessageBox.Show("Product Added");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                imgpath = fileDialog.FileName;
                pictureBox1.ImageLocation = imgpath;
            }

        }
    }
}
