// todo:
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace DateBase
{
    public partial class MainForm : Form
    {
        public DBBook book = new DBBook();
        public string filename = "";


        public MainForm()
        {
            InitializeComponent();
            // rename: 
            // dataSource
            dataGridView1.Rows[0].ReadOnly = true;
            dataGridView1.DataSource = book.books; // ???????????? Как реализовать, не дает записывать иначе через Add
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            AddBookForm addform = new AddBookForm();
            addform.Owner = this;
            addform.Show();
        }

        private void WriteToDataGrid()
        {
            for (int i = 0; i < book.books.Count/*Book.Count*/; i++)
            {
                Book b = (Book)book.books[i]/*Book[i]*/;
                dataGridView1.Rows.Add(b.Author, b.Title, b.Genre, b.Year, b.Count, b.Price);
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                if (filename == "")
            {
                if (saveFileDialog.ShowDialog() == DialogResult.Cancel) return;
                filename = saveFileDialog.FileName;
               
            }
            book.SaveDB(filename);
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;

                filename = openFileDialog.FileName;
                //this.Text = filename + " - База данных книжного магазина";

                dataGridView1.Rows.Clear();
                book.OpenFile(filename);

                WriteToDataGrid();
            }
        }

        private void button_alldelete_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            book.DeleteDB();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int ind = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows.RemoveAt(ind);
            book.DeleteBook(ind);
        }

















        // public void BanChangeColumn(int index) => dataGridView1.Rows[index].Cells[0].ReadOnly = true;


    }
}
