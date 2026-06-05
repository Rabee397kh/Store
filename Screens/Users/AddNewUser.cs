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

namespace Store.Screens.Users
{
    public partial class AddNewUser : Form
    {
        storeDBEntities storeDB = new storeDBEntities();
        string imgPath = "";
        public AddNewUser()
        {
            InitializeComponent();
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {


            user newUser = new user
            {
                username = usernameTxt.Text,
                password = passwordTxt.Text
            };

            //storeDB.users.Add(new user
            //{
            //    username = usernameTxt.Text,
            //    password = passwordTxt.Text
            //});

            storeDB.users.Add(newUser);
            storeDB.SaveChanges();
            string newPath = Environment.CurrentDirectory + $"\\images\\users\\{newUser.userid}.png";
            File.Copy(imgPath, newPath);

            newUser.img = newPath;
            storeDB.SaveChanges();


            MessageBox.Show($"{usernameTxt.Text} is Added");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                imgPath = fileDialog.FileName;
                pictureBox1.ImageLocation = imgPath;
                //MessageBox.Show(imgPath);
            }
        }
    }
}
