using Library.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Library.Controller
{
    public class EmployeeController
    {
        public string CalculateTotal(string Title, int Quantity)
        {
            List<Book> bookList = XMLUtility<List<Book>>.ReadData("books.xml");
            Book book = bookList.Find(element => element.Title == Title);
            return Convert.ToString(book.Price * Quantity);
        }

        public List<Book> SellBook(string Title, int Quantity)
        {
            List<Transaction> transactionsList = XMLUtility<List<Transaction>>.ReadData("transactions.xml");
            List<Book> bookList = XMLUtility<List<Book>>.ReadData("books.xml");
            Book book = bookList.Find(element => element.Title == Title);

            if (book.Quantity < Quantity)
            {
                MessageBox.Show("Nu sunt destule exemplare");
                return XMLUtility<List<Book>>.ReadData("books.xml");
            }
            else
            {
                book.Quantity = book.Quantity - Quantity;
                bookList.RemoveAll(element => element.Title == Title);
                bookList.Add(book);
                XMLUtility<List<Book>>.SaveData(bookList, "books.xml");

                MessageBox.Show("Cartea a fost vanduta");

                Transaction transaction = new Transaction(book.Title, book.Price, Quantity, book.Price * Quantity);
                transactionsList.Add(transaction);
                XMLUtility<List<Transaction>>.SaveData(transactionsList, "transactions.xml");

                return XMLUtility<List<Book>>.ReadData("books.xml");
            }
        }
    }
}
