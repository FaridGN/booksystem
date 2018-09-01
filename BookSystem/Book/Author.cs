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
    public partial class Author : Form
    {
        public Author()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                Author newauthor = new Author();
                newauthor.Name = textBox1.Text;
                MyDataBase.Authors.Add(newauthor);
        }
    }
}
