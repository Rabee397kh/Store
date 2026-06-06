using Store.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class Form1 : Form
    {
        string username = "",password="";
        storeDBEntities storeDB = new storeDBEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            username = usernameTxt.Text;
            password = passwordTxt.Text;

            if (storeDB.users.Where((u => u.username == this.username && u.password == this.password)).Count() != 0)
            {
                this.Close();
                Thread thread = new Thread(openMain);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
                MessageBox.Show("please enter valid credentials");
            
        }


        private void openMain()
        {

            Application.Run(new Main());

        }
    }
}
