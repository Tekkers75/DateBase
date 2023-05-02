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
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void button_AddBook_Click(object sender, EventArgs e)
        {
            MainForm mForm = this.Owner as MainForm;

            /// Добавить пустой параметр? 
            /// Добавить цвет поля
            /// Добавить разные исключения, неправильный формат, пустое поле.
           // try
            {
                
                string author = textBox_Author.Text;
                string title = textBox_Title.Text;
                string genre = textBox_Genre.Text;
                int year = int.Parse(textBox_Year.Text);
                int count = int.Parse(textBox_Count.Text);
                int price = int.Parse(textBox_Price.Text);

                textBox_Author.Text = "";
                textBox_Title.Text = "";
                textBox_Genre.Text = "";
                textBox_Year.Text = "";
                textBox_Count.Text = "";
                textBox_Price.Text = "";

                mForm.book.AddBook(author, title, genre, year, count, price);
                int n = mForm.book.books.Count;   //int n = mForm.book.Book.Count;
                mForm.dataGridView1.Rows.Add(author, title, genre, year, count, price);
               
                
                /// Как работать с DataSource, заранее делать список?
                /// Иначе он не дает заполнить 
                //mForm.book.books.Add(new Book(author, title, genre, year, count, price));
                //mForm.book.books.Add (author, title, genre, year, count, price)
                //mForm.dataGridView1.DataSource = mForm.book.books;


            }
            //catch
            //{
            //   // MessageBox.Show("Пустое поле");
            //}
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
