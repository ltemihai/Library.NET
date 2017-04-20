using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Library.AdminForms.BookForms
{
    public partial class UpdateBookForm : Form
    {
        private AdminController _adminController = new AdminController();
        public UpdateBookForm()
        {
            InitializeComponent();
            List<Book> bookList = XMLUtility<List<Book>>.ReadData("books.xml");
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = bookList;
            comboBox1.DataSource = bindingSource;
            comboBox1.DisplayMember = "Title";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _adminController.UpdateBook(comboBox1.Text, textBox2.Text, textBox3.Text, Int32.Parse(textBox4.Text),
                    Double.Parse(textBox5.Text));
                MessageBox.Show("Cartea a fost updatata cu succes");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
