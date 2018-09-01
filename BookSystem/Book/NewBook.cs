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
    public partial class NewBook : Form
    {
        public NewBook()
        {
            InitializeComponent();
        }

        private void NewBook_Load(object sender, EventArgs e)
        {
            List<Category> categories = MyDataBase.Categories;
            comboBox2.DataSource = categories;
            comboBox2.DisplayMember = "Name";
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
