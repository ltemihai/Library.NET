using System;

namespace Library
{
    public class Book
    {
        private string _title;
        private string _author;
        private string _genre;
        private Int32 _quantity;
        private Double _price;

        public Book(string title, string author, string genre, Int32 quantity, Double price)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Quantity = quantity;
            Price = price;
        }

        public Book()
        {

        }

        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
            }
        }

        public string Author
        {
            get
            {
                return _author;
            }

            set
            {
                _author = value;
            }
        }

        public string Genre
        {
            get
            {
                return _genre;
            }

            set
            {
                _genre = value;
            }
        }

        public int Quantity
        {
            get
            {
                return _quantity;
            }

            set
            {
                _quantity = value;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }
    }
}
