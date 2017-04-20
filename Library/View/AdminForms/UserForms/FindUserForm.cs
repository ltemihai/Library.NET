using System;
using System.Windows.Forms;

namespace Library.AdminForms
{
    public partial class FindUserForm : Form
    {
        private AdminController _adminController = new AdminController();
        public FindUserForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                dataGridView1.DataSource = _adminController.FindUser(textBox1.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
