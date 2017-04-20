namespace Library.Model
{
    public class Transaction
    {
        private string bookName;
        private double unitPrice;
        private int quantity;
        private double totalPrice;

        public Transaction()
        {

        }

        public Transaction(string bookName, double unitPrice, int quantity, double totalPrice)
        {
            BookName = bookName;
            UnitPrice = unitPrice;
            Quantity = quantity;
            TotalPrice = totalPrice;
        }

        public string BookName
        {
            get
            {
                return bookName;
            }

            set
            {
                bookName = value;
            }
        }

        public double UnitPrice
        {
            get
            {
                return unitPrice;
            }

            set
            {
                unitPrice = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public double TotalPrice
        {
            get
            {
                return totalPrice;
            }

            set
            {
                totalPrice = value;
            }
        }
    }
}
