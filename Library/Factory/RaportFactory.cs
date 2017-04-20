using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    class RaportFactory
    {
        public void CreatePDFReport(DataGridView dataGridView)
        {

            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Out of stock books";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("dd/MM/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Libraria LTE";
            printer.FooterSpacing = 15;

            // List<Book> bookList = XMLUtility<List<Book>>.ReadData("books.xml");
            //  List<Book> reportList = bookList.FindAll(element => element.Quantity == 0);

            // dataGridView.DataSource = reportList;
            printer.PrintDataGridView(dataGridView);

            /*printer.print
             Document document = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
             document.AddTitle("Out of stock books");
             document.
             PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(fileName, FileMode.Create));
             document.Open();
             List<Book> bookList = XMLUtility<List<Book>>.ReadData("books.xml");
             List<Book> reportList = bookList.FindAll(element => element.Quantity == 0);
             foreach (Book book in reportList)
             {
                 Paragraph paragraph = new Paragraph(book.Title + " " + book.Author + " " + book.Genre + " " + book.Quantity + " " + book.Price);
                 document.Add(paragraph);
 
             }
             document.Close();*/
        }

        public async void CreateCSVReport()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter streamWriter =
                        new StreamWriter(new FileStream(saveFileDialog.FileName, FileMode.Create), Encoding.UTF8))
                    {
                        List<Book> bookList = XMLUtility<List<Book>>.ReadData("books.xml");
                        List<Book> reportList = bookList.FindAll(element => element.Quantity == 0);
                        StringBuilder stringBuilder = new StringBuilder();
                        stringBuilder.AppendLine("Title,Author,Genre,Quantity,Price");
                        foreach (Book book in reportList)
                        {
                            stringBuilder.AppendLine(string.Format("{0},{1},{2},{3},{4}", book.Title, book.Author,
                                book.Genre, book.Quantity, book.Price));
                        }
                        await streamWriter.WriteLineAsync(stringBuilder.ToString());
                        MessageBox.Show("S-a generat raportul CSV");
                    }

                }
            }

            /*StringBuilder csvContent = new StringBuilder();
            csvContent.AppendLine("Title , Author , Genre , Quantity , Price");
            List<Book> bookList = XMLUtility<List<Book>>.ReadData("books.xml");
            List<Book> reportList = bookList.FindAll(element => element.Quantity == 0);
            foreach (Book book in reportList)
            {
                csvContent.AppendLine(book.Title + "," + book.Author + "," + book.Genre + "," + book.Quantity + "," +
                                      book.Price);
            }
            File.AppendAllText(Environment.CurrentDirectory + "Report.csv", csvContent.ToString());
        */
        }
    }
}
