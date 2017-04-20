using System;
using System.Windows.Forms;

namespace Library.AdminForms
{
    public partial class AddBookForm : Form
    {
        private AdminController _adminController = new AdminController();

        public AddBookForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _adminController.AddNewBook(textBox1.Text, textBox2.Text, textBox3.Text, Int32.Parse(textBox4.Text),
                    Double.Parse(textBox5.Text));
                MessageBox.Show("Cartea a fost adaugata");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
