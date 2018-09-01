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
    public partial class Lang : Form
    {
        public Lang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Language newlang = new Language();
            newlang.Lang = textBox1.Text;
            MyDataBase.Langs.Add(newlang);
        }
    }
}
