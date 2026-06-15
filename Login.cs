using Store.Db;
using Store.Global;
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
    public partial class Login : Form
    {
        string username = "",password="";
        storeDBEntities storeDB = new storeDBEntities();
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            username = usernameTxt.Text;
            password = passwordTxt.Text;

            var usr = storeDB.users.FirstOrDefault(u=> u.username == this.username && u.password == this.password);
            if (usr != null) {
                UserSession.userid = usr.userid;
                UserSession.username = usr.username;
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
