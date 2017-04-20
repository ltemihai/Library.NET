using System;
using System.Windows.Forms;

namespace Library.AdminForms.BookForms
{

    public partial class FindBookForm : Form
    {
        private AdminController _adminController = new AdminController();
        public FindBookForm()
        {
            InitializeComponent();
            comboBox1.Items.Add("Title");
            comboBox1.Items.Add("Author");
            comboBox1.Items.Add("Genre");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = _adminController.FindBook(comboBox1.Text,textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
