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

namespace Store.Screens.ProductSuppliers
{
    public partial class ManageSuppliers : Form
    {
        storeDBEntities storeDB = new storeDBEntities();
        string imgpath = "";
        string searchSelected = "";
        public ManageSuppliers()
        {
            InitializeComponent();
        }

        private void _loadSuppliers()
        {
            supplierGrid.DataSource = storeDB.suppliers.ToList();
            SupplierNums.Text = supplierGrid.Rows.Count.ToString();
        }
        private void ManageSuppliers_Load(object sender, EventArgs e)
        {
            _loadSuppliers();
        }

        private void _fillInfo(int id)
        {
            supplier sup = storeDB.suppliers.Find(id);

            if(sup == null)
            {
                //MessageBox.Show("Supplier not found");
                return;
            }

            supplierNameTxt.Text = sup.suppliername;
            emailTxt.Text = sup.supplieremail;
            phoneTxt.Text = sup.suppliernumber;
            companyTxt.Text = sup.company;
            noteTxt.Text= sup.note;
            addressTxt.Text = sup.supplieraddress;
            supplierImg.ImageLocation = sup.img;
            if (sup.isactive == true)
            {
                yesRd.Checked = true;
            }
            else
                noRd.Checked = true;

            editBtn.Enabled = true;
            deleteBtn.Enabled = true;
            addSupplierBtn.Enabled = false;
        }
        private void supplierGrid_SelectionChanged(object sender, EventArgs e)
        {
            int supplierid = (int)supplierGrid.CurrentRow.Cells[0].Value;
            _fillInfo(supplierid);
        }

        private void _reset()
        {
            supplierNameTxt.Text = "";
            emailTxt.Text = "";
            phoneTxt.Text = "";
            companyTxt.Text = "";
            noteTxt.Text = "";
            addressTxt.Text = "";
            supplierImg.ImageLocation = "";

            editBtn.Enabled = false;
            deleteBtn.Enabled = false;
            addSupplierBtn.Enabled = true;
        }
        private void addSupplierBtnFocus_Click(object sender, EventArgs e)
        {
            _reset();
        }

        private void addSupplierBtn_Click(object sender, EventArgs e)
        {
            if(supplierNameTxt.Text == "" || addressTxt.Text == "" || phoneTxt.Text == "")
            {
                MessageBox.Show("Please fill important Field");
                return;
            }

            supplier sup = new supplier
            {
                suppliername = supplierNameTxt.Text,
                supplieremail = emailTxt.Text,
                supplieraddress = addressTxt.Text,
                suppliernumber = phoneTxt.Text,
                company = companyTxt.Text,
                note = noteTxt.Text,
                isactive = yesRd.Checked == true ? true : false
            };

            storeDB.suppliers.Add(sup);
            storeDB.SaveChanges();

            if(imgpath != "")
            {
                string newpath = $"{Environment.CurrentDirectory}\\images\\suppliers\\{sup.supplierid}.png";
                File.Copy(imgpath, newpath);
                sup.img = newpath;
                storeDB.SaveChanges();
            }
            MessageBox.Show("Supplier : " + supplierNameTxt.Text + " Added Successfully");
            _loadSuppliers();
            _reset();
        }

        private void supplierImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imgpath = openFileDialog.FileName;
                supplierImg.ImageLocation = imgpath;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure?","Delete",MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            int supplierId = (int)supplierGrid.CurrentRow.Cells[0].Value;
            supplier sup = storeDB.suppliers.Find(supplierId);

            storeDB.suppliers.Remove(sup);
            storeDB.SaveChanges();
            MessageBox.Show($"Supplier {supplierNameTxt.Text} Deleted Succesffuly");
            _loadSuppliers();
            _reset();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            int supplierId = (int)supplierGrid.CurrentRow.Cells[0].Value;
            supplier sup = storeDB.suppliers.Find(supplierId);

            sup.suppliername = supplierNameTxt.Text;
            sup.supplieremail = emailTxt.Text;
            sup.supplieraddress = addressTxt.Text;
            sup.suppliernumber = phoneTxt.Text;
            sup.company = companyTxt.Text;
            sup.note = noteTxt.Text;
            sup.isactive = yesRd.Checked == true ? true : false;
            

            if(imgpath != "")
            {
                string newpath = $"{Environment.CurrentDirectory}\\images\\suppliers\\{sup.supplierid}.png";
                File.Copy(imgpath, newpath,true);
                sup.img = newpath;   
            }

            storeDB.SaveChanges();
            MessageBox.Show("Supplier : " + supplierNameTxt.Text + " Edited Successfully");
            _loadSuppliers();
            _reset();
}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchSelected = comboBox1.Text;
        }

        private void SupplierSearchTxt_TextChanged(object sender, EventArgs e)
        {
            if(searchSelected == "Supplier Name")
            {
               supplierGrid.DataSource =  storeDB.suppliers.Where(s => s.suppliername.Contains(SupplierSearchTxt.Text)).ToList();
            }else if(searchSelected == "Address")
            {
                supplierGrid.DataSource = storeDB.suppliers.Where(s => s.supplieraddress.Contains(SupplierSearchTxt.Text)).ToList();
            }
        }
    }
}
