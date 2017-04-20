using System;
using System.Windows.Forms;

namespace Library
{
    public partial class RemoveUserForm : Form
    {
        private AdminController _adminController = new AdminController();
        public RemoveUserForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _adminController.RemoveUser(textBox1.Text);
                MessageBox.Show("Userul a fost sters");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
