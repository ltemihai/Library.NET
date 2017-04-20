using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.AdminForms.BookForms
{
    public partial class RemoveBookForm : Form
    {
        private AdminController _adminController = new AdminController();
        public RemoveBookForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _adminController.RemoveBook(textBox1.Text);
                MessageBox.Show("Cartea a fost stearsa cu succes");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
