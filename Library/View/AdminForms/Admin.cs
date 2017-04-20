using Library.AdminForms;
using Library.AdminForms.BookForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Library
{
    public partial class Admin : Form
    {
        private AdminController _adminController = new AdminController();
        public Admin()
        {
            InitializeComponent();
            dataGridView1.DataSource = XMLUtility<List<User>>.ReadData("users.xml");
            dataGridView2.DataSource = XMLUtility<List<Book>>.ReadData("books.xml");
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUserForm form = new AddUserForm();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemoveUserForm form = new RemoveUserForm();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateUserForm form = new UpdateUserForm();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FindUserForm form = new FindUserForm();
            form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddBookForm form = new AddBookForm();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RemoveBookForm form = new RemoveBookForm();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UpdateBookForm form = new UpdateBookForm();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FindBookForm form = new FindBookForm();
            form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            _adminController.GeneratePDFReport(dataGridView3);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            _adminController.GenerateCVSReport();
        }
    }
}
