using Store.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store.Screens.Customers
{
    public partial class ManageCustomers : Form
    {
        storeDBEntities storeDB = new storeDBEntities();
        string imgPath = "";
        public ManageCustomers()
        {
            InitializeComponent();
            _loadCustomers();
            
        }

        private void _reset()
        {
            customerGrid.ClearSelection();
            label3.Text = "Add Customer";
            customerNameTxt.Text = "";
            emailTxt.Text = "";
            addressTxt.Text = "";
            companyTxt.Text = "";
            phoneTxt.Text = "";
            noteTxt.Text = "";
            customerImg.ImageLocation = "";
            addCustomerBtn.Enabled = true;
            editBtn.Enabled = false;
            deleteBtn.Enabled = false;
            
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void _loadCustomers()
        {
            customerGrid.DataSource = storeDB.clients.ToList();
            customersNums.Text = customerGrid.Rows.Count.ToString();
            
            
        }
        private void ManageCustomers_Load(object sender, EventArgs e)
        {

        }

        private void _fillCustomer(int id)
        {
            client cl = storeDB.clients.Find(id);

            if(cl == null)
            {
                //MessageBox.Show("Customer Not Found");
                return;
            }

            customerNameTxt.Text = cl.clientname ;
            emailTxt.Text = cl.clientemail;
            addressTxt.Text = cl.clientaddress;
            companyTxt.Text = cl.company;
            phoneTxt.Text = cl.clientnumber;
            noteTxt.Text = cl.note;
            if (cl.isactive == true)
            {
                yesRd.Checked = true;
            }
            else
            {
                noRd.Checked = true;
            }
            customerImg.ImageLocation = cl.img;
            addCustomerBtn.Enabled = false;
            editBtn.Enabled = true;
            deleteBtn.Enabled = true;
        }
        private void customerGrid_SelectionChanged(object sender, EventArgs e)
        {
           int customerId = (int)customerGrid.CurrentRow.Cells[0].Value;
           client cl = storeDB.clients.Find(customerId);
           _fillCustomer(customerId);
            label3.Text = "Edit Customer";
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            int customerId = (int)customerGrid.CurrentRow.Cells[0].Value;
            client cl = storeDB.clients.Find(customerId);

            cl.clientname = customerNameTxt.Text;
            cl.clientemail = emailTxt.Text;
            cl.clientaddress = addressTxt.Text;
            cl.company = companyTxt.Text;
            cl.clientnumber = phoneTxt.Text;
            cl.note = noteTxt.Text;
            if (yesRd.Checked == true)
            {
                cl.isactive = true;
            }
            else
            {
                cl.isactive =false;
            }
            if(imgPath != "")
            {
                string newPath = $"{Environment.CurrentDirectory}\\images\\customers\\{cl.clientid}.png";
                File.Copy(imgPath, newPath, true);
                cl.img = newPath;
            }
            storeDB.SaveChanges();
            MessageBox.Show("Customer " + customerNameTxt.Text + "Updated Succefully!");
            _loadCustomers();
            _reset();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("are youu sure?","Delete",MessageBoxButtons.YesNo) == DialogResult.No){
                return;
            }
            int customerId = (int)customerGrid.CurrentRow.Cells[0].Value;
            client cl = storeDB.clients.Find(customerId);
            storeDB.clients.Remove(cl);
            storeDB.SaveChanges();
            MessageBox.Show($"Client {customerNameTxt.Text} Deleted Successfully!");
            _loadCustomers();
            _reset();
            if(customerGrid.Rows.Count == 0)
            {
                deleteBtn.Enabled = false;
                editBtn.Enabled = false;
            }
        }

        private void customerImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                imgPath = fileDialog.FileName;
                customerImg.ImageLocation = imgPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _reset();
            customerNameTxt.Focus();
        }
    }
}
