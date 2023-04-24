using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateBase
{
    public class dbBook
    {
        List<Book> book = new List<Book>();

        /// Вернуть список
        public List<Book> Book
        {
            get { return book; }
        }

        /// Добавление книги в список
        public void AddBook(string author, string title, string genre, int year, int count, int price)
        {
            Book newBook = new Book(author, title, genre, year, count, price);
            book.Add(newBook);
        }
     
        /// Сохранить БД в файл
        public void SaveDB(string name)
        {
            ///Почитать
            using (StreamWriter sw = new StreamWriter(name, false, System.Text.Encoding.Unicode))
            {
                foreach (Book s in book)
                {
                    sw.WriteLine(s.ToString());
                }
            }
        }

        /// Открыть БД из файла
        public void OpenFile(string name)
        {
            if (!System.IO.File.Exists(name))
                throw new Exception("Файл не существует");

            if (book.Count != 0)
                //DeleteBooks();

            using (StreamReader sw = new StreamReader(name))
            {
                while (!sw.EndOfStream)
                {
                    string str = sw.ReadLine();
                    String[] dataFromFile = str.Split(new String[] { "|" },
                        StringSplitOptions.RemoveEmptyEntries);

                    string author = dataFromFile[0];
                    string title = dataFromFile[1];
                    string genre = dataFromFile[2];
                    int year = int.Parse(dataFromFile[3]);
                    int count = int.Parse(dataFromFile[4]);
                    int price = int.Parse(dataFromFile[5]);
                    AddBook(author, title, genre, year, count, price);
                }
            }
        }

        public void DeleteDB()
        {
            book.Clear();
        }

        public void DeleteBook(int ind)
        {
            book.RemoveAt(ind);
        }





    }
}
