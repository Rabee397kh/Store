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

namespace Store.Screens.SalesBill
{
    public partial class ManageSalesBill : Form
    {
        storeDBEntities storeDB = new storeDBEntities();
        List<product> products;
        List<product> productsView = new List<product>();
        public ManageSalesBill()
        {
            InitializeComponent();
            products = storeDB.products.ToList();
        }

        private void ManageSalesBill_Load(object sender, EventArgs e)
        {
            _fillClientsCombo();
            _addItemsToListView();
            
        }

        private void _addItemsToListView()
        {
            //ListViewItem viewItem = new ListViewItem();
            for(int i = 0; i < products.Count(); i++)
            {
                if (products[i].img != null)
                    imageList1.Images.Add(Image.FromFile(products[i].img));
                else
                {
                    Bitmap bitmap = new Bitmap(70,70);
                    imageList1.Images.Add(bitmap);
                }

                ListViewItem viewItem = new ListViewItem();
                viewItem.Text = products[i].productname;
                viewItem.ImageIndex = i;
                viewItem.Tag = products[i];
                productsListView.Items.Add(viewItem);
            }
        }

        private void _fillClientsCombo()
        {
            clientCombo.DataSource = storeDB.clients.Where(c => c.isactive == true).ToList();
            clientCombo.ValueMember = "clientid";
            clientCombo.DisplayMember = "clientname";
        }

        private void productsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(productsListView.SelectedItems.Count > 0)
            {
                product pro = (product)productsListView.SelectedItems[0].Tag;


                if (productsView.Contains(pro))
                {
                    MessageBox.Show("item included");
                }
                else
                {

                    productsView.Add(pro);

                    string imagePath = pro.img; // your source path
                    Image img;

                    if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                    {
                        img = Image.FromFile(imagePath);
                    }
                    else
                    {
                        // fallback image (could be a blank bitmap or a placeholder file)
                        Bitmap bitmap = new Bitmap(40,40);
                        img = bitmap;
                        // or new Bitmap(1,1) if you just want an empty image
                    }

                    //dataGridView.Rows.Add(img, otherValue1, otherValue2);

                    salesBillGridView.Rows.Add(pro.productid, pro.productname, pro.price, 1, pro.price * 1, img);
                }
                    
                

                
                //MessageBox.Show($"{pro.productname} {pro.productcode} {pro.price}");
            }
        }
    }
}
