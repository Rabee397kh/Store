using Store.Db;
using Store.Global;
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
    public partial class ListSalesBill : Form
    {
        storeDBEntities storeDB = new storeDBEntities();
        public ListSalesBill()
        {
            InitializeComponent();
           
        }

        private void ListSalesBillcs_Load(object sender, EventArgs e)
        {
            //salesBillGridView.DataSource = storeDB.salesBills.ToList();
            //salesBillCountLb.Text = salesBillGridView.RowCount.ToString();
            _loadBills();
            //salesBillDetailsGridView.DataSource = storeDB.salesBills.Select(s => new { s.id, s.user.username, s.client.clientname,s.date }).ToList();
        }

        private void _loadBills()
        {
            
            List<salesBill> slBills = storeDB.salesBills.ToList();
            //client cl = new client();

            if (slBills.Count == 0)
                return;

            for(int i =0; i < slBills.Count; i++)
            {
                var cl = storeDB.clients.Find(slBills[i].customerid);

                salesBillGridView.Rows.Add(slBills[i].id, UserSession.username, cl.clientname, slBills[i].total,
                    slBills[i].discount, slBills[i].netTotal, slBills[i].billNumber, slBills[i].note, slBills[i].date);
            }

            salesBillCountLb.Text = slBills.Count.ToString();
        }

        private void salesBillGridView_SelectionChanged(object sender, EventArgs e)
        {
            int sbid = Convert.ToInt32(salesBillGridView.CurrentRow.Cells["id"].Value.ToString());
            var data = storeDB.salesbilldetails.Where(s=> s.salesbillid == sbid)
                .Select(s=> new {s.id,s.product.productname,s.price,s.product.img,s.quantity,s.totalprice}).ToList();

            salesBillDetailsGridView.RowTemplate.Height = 70;
            
            salesBillDetailsGridView.DataSource = data.Select(d => new {
                d.id,
                d.productname,
                d.price,
                image = d.img == null ? new Bitmap(70,70) : Image.FromFile(d.img),
                d.quantity,
                d.totalprice
            }).ToList();

            billDetailesCount.Text = storeDB.salesbilldetails.Where(s => s.salesbillid == sbid).Count().ToString();
        }
    }
}
