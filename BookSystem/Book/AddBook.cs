using System;
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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("Book Name");
            table.Columns.Add("Author");
            table.Columns.Add("Price");
            table.Columns.Add("Category");
            table.Columns.Add("Language");

            table.Rows.Add(1, "Harry Potter", "J.K.Rowling", 12.99, "Fantasy", "English");

            GridView1.DataSource = table;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Author author = new Author();
            author.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lang language = new Lang();
            language.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NewBook newbook = new NewBook();
            newbook.ShowDialog();
        }
    }
}
