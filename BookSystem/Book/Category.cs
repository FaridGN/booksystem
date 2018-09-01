using System;
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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category newcat = new Category();
             newcat.Name = textBox1.Text;
            MyDataBase.Categories.Add(newcat);
        }
    }
}
