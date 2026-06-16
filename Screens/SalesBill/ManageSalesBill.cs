using Store.Db;
using Store.Global;
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
        //List<product> productsView = new List<product>();
        decimal tot = 0;
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

                for (int i = 0; i < salesBillGridView.RowCount; i++)
                {
                    if (salesBillGridView.Rows[i].Cells["id"].Value.ToString() == pro.productid.ToString())
                    {
                        //MessageBox.Show("item included");
                        salesBillGridView.Rows[i].Cells["quantity"].Value = Convert.ToInt32(salesBillGridView.Rows[i].Cells["quantity"].Value.ToString()) + 1;
                        salesBillGridView.Rows[i].Cells["total"].Value = Convert.ToInt32(salesBillGridView.Rows[i].Cells["quantity"].Value.ToString()) * Convert.ToInt32(salesBillGridView.Rows[i].Cells["price"].Value.ToString());
                        tot = tot + Convert.ToDecimal(salesBillGridView.Rows[i].Cells["price"].Value.ToString());
                        _updateTotal(tot);
                        return;
                    }
                }    

                        
                        salesBillGridView.Rows.Add(pro.productid, pro.productname, pro.price, 1, pro.price * 1, pro.img == null? new Bitmap(40,40) : Image.FromFile(pro.img));

               tot = tot + pro.price;
                _updateTotal(tot);
                //MessageBox.Show(tot.ToString());
            }
        }

        

        private void _updateTotal(decimal tot)
        {

            totalLB.Text = tot.ToString();
            decimal netTotal = tot - discountNu.Value;
            totalNetLb.Text = netTotal.ToString();
        }

        private void discountNu_ValueChanged(object sender, EventArgs e)
        {
            if(discountNu.Value > tot)
            {
                MessageBox.Show("discount isnt reasonale!");
                return;
            }
            _updateTotal(tot);
            
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (salesBillGridView.CurrentRow != null)
            {
                decimal total = Convert.ToDecimal(salesBillGridView.CurrentRow.Cells["total"].Value);
                salesBillGridView.Rows.Remove(salesBillGridView.CurrentRow);
                decimal newTotal = Convert.ToDecimal(totalLB.Text) - total;
                _updateTotal(newTotal);
            }
            //MessageBox.Show(total.ToString());
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(salesBillGridView.RowCount == 0)
            {
                MessageBox.Show("There is no Bill to save!!");
                return;
            }
            if(billNumTxt.Text == "" || clientCombo.Text == "")
            {
                MessageBox.Show("Important field empty!!");
            }
            int salesBillId = 0;
            _saveSalesBillInfo(ref salesBillId);
            _saveSalesBillDetailsInfo(salesBillId);
            MessageBox.Show("Bill Saved Successfully!");
        }

        private void _saveSalesBillDetailsInfo(int salesbillid)
        {
            salesbilldetail salesbilldetail = new salesbilldetail();
            for(int i = 0; i < salesBillGridView.RowCount; i++)
            {
                salesbilldetail.productid = (int)salesBillGridView.Rows[i].Cells["id"].Value;
                salesbilldetail.salesbillid = salesbillid;
                salesbilldetail.price = Convert.ToDouble(salesBillGridView.Rows[i].Cells["price"].Value);
                salesbilldetail.quantity = Convert.ToInt32(salesBillGridView.Rows[i].Cells["quantity"].Value);
                salesbilldetail.totalprice = Convert.ToInt32(salesBillGridView.Rows[i].Cells["total"].Value);
                storeDB.salesbilldetails.Add(salesbilldetail);
                storeDB.SaveChanges();
            }
        }

        private void _saveSalesBillInfo(ref int salesbillid)
        {
            //MessageBox.Show( clientCombo.SelectedValue.ToString());
            salesBill salesBill = new salesBill
            {
                customerid = (int)clientCombo.SelectedValue,
                userid = UserSession.userid,
                note = noteTxt.Text,
                total = Convert.ToDouble(totalLB.Text),
                discount = Convert.ToDouble(discountNu.Value),
                netTotal = Convert.ToDouble(totalNetLb.Text),
                billNumber = Convert.ToInt32(billNumTxt.Text),
                date = dateTimePicker1.Value
            };
            
            storeDB.salesBills.Add(salesBill);
            storeDB.SaveChanges();
            salesbillid = salesBill.id;
            
        }
    }
}
