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

namespace Store.Screens.Users
{
    public partial class AddNewUser : Form
    {
        storeDBEntities storeDB = new storeDBEntities();
        public AddNewUser()
        {
            InitializeComponent();
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            

            //user newUser = new user
            //{
            //    username = usernameTxt.Text,
            //    password = passwordTxt.Text
            //};

            storeDB.users.Add(new user
            {
                username = usernameTxt.Text,
                password = passwordTxt.Text
            });
            storeDB.SaveChanges();
            MessageBox.Show($"{usernameTxt.Text} is Added");
        }
    }
}
