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

namespace Store.Screens.SalesBill
{
    public partial class ManageSalesBill : Form
    {
        storeDBEntities storeDB = new storeDBEntities();
        List<product> products;
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
    }
}
