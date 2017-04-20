using System.Collections.Generic;
using System.Windows.Forms;

namespace Library
{
    public class AdminController
    {

        public void AddNewBook(string Title, string Author, string Genre, int Quantity, double Price)
        {
            Book book = new Book(Title, Author, Genre, Quantity,
                Price);
            List<Book> bookList = XMLUtility<List<Book>>.ReadData("books.xml");
            bookList.Add(book);
            XMLUtility<List<Book>>.SaveData(bookList, "books.xml");

        }

        public List<Book> FindBook(string Type,string Name)
        {
            List<Book> bookList = XMLUtility<List<Book>>.ReadData("books.xml");
            List<Book> findList = new List<Book>();
            switch (Type)
            {
                case "Title":
                    findList = bookList.FindAll(element => element.Title == Name);
                    return findList;

                case "Author":
                    findList = bookList.FindAll(element => element.Author == Name);
                    return findList;

                case "Genre":
                    findList = bookList.FindAll(element => element.Author == Name);
                    return findList;

                default: break;

            }
            return null;
        }

        public void RemoveBook(string Title)
        {
            List<Book> bookList = XMLUtility<List<Book>>.ReadData("books.xml");
            bookList.RemoveAll(element => element.Title == Title);
            XMLUtility<List<Book>>.SaveData(bookList, "books.xml");
        }

        public void UpdateBook(string Title, string Author, string Genre, int Quantity, double Price)
        {
            Book book = new Book(Title, Author, Genre, Quantity,
                Price);
            List<Book> bookList = XMLUtility<List<Book>>.ReadData("books.xml");
            bookList.RemoveAll(element => element.Title == Title);
            bookList.Add(book);
            XMLUtility<List<Book>>.SaveData(bookList, "books.xml");
        }

        public void AddNewUser(string Username, string Password, string Type)
        {
            User user = new User(Username, Password, Type);
            List<User> userList = XMLUtility<List<User>>.ReadData("users.xml");
            userList.Add(user);
            XMLUtility<List<User>>.SaveData(userList, "users.xml");
        }

        public List<User> FindUser(string Username)
        {
            List<User> userList = XMLUtility<List<User>>.ReadData("users.xml");
            User user = userList.Find(element => element.Username == Username);
            List<User> findList = new List<User>();
            findList.Add(user);
            return findList;
        }

        public void RemoveUser(string Username)
        {
            List<User> userList = XMLUtility<List<User>>.ReadData("users.xml");
            userList.RemoveAll(element => element.Username == Username);
            XMLUtility<List<User>>.SaveData(userList, "users.xml");
        }

        public void UpdateUser(string Username, string Password, string Type)
        {
            User user = new User(Username, Password, Type);
            List<User> userList = XMLUtility<List<User>>.ReadData("users.xml");
            userList.RemoveAll(element => element.Username == Username);
            userList.Add(user);
            XMLUtility<List<User>>.SaveData(userList, "users.xml");
        }

        public void GeneratePDFReport(DataGridView dataGridView)
        {
            List<Book> bookList = XMLUtility<List<Book>>.ReadData("books.xml");
            List<Book> reportList = bookList.FindAll(element => element.Quantity == 0);
            dataGridView.DataSource = reportList;
            RaportFactory factory = new RaportFactory();
            factory.CreatePDFReport(dataGridView);
        }

        public void GenerateCVSReport()
        {
            RaportFactory factory = new RaportFactory();
            factory.CreateCSVReport();
        }
    }
}
