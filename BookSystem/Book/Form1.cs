﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User myuser = new User();
            myuser.Username = textBox1.Text;
            myuser.Password = textBox2.Text;

            if (MyDataBase.Finduser(myuser))
            {
                AddBook add = new AddBook();
                add.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register registered = new Register();
            registered.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
