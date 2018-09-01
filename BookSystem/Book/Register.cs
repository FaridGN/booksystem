using System;
using Book.Models;
using Book.Database;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                User newuser = new User();
                newuser.Name = textBox1.Text;
                newuser.Surname = textBox2.Text;
                newuser.Email = textBox3.Text;
                newuser.Username = textBox4.Text;
                newuser.Password = textBox5.Text;

            if (MyDataBase.Finduser(newuser))
            {
                MessageBox.Show("Account exists");
            }
            else
            {
                MyDataBase.Users.Add(newuser);
                AddBook add = new AddBook();
                add.ShowDialog();
            }
        }
    }
}
