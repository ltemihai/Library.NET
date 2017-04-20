using Library.AdminForms.BookForms;
using Library.Controller;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Library.EmployeeForms
{
    public partial class EmployeeForm : Form
    {
        private EmployeeController _employeeController = new EmployeeController();
        public EmployeeForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = XMLUtility<List<Book>>.ReadData("books.xml");
            // List<Transaction> list = new List<Transaction>();
            // list.Add(new Transaction());
            // XMLUtility<List<Transaction>>.SaveData(list, "transactions.xml";
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            FindBookForm form = new FindBookForm();
            form.Show();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            textBox3.Text = _employeeController.CalculateTotal(textBox1.Text, int.Parse(textBox2.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _employeeController.SellBook(textBox1.Text, Convert.ToInt32(textBox2.Text));
        }
    }
}
