using System;
using System.Windows.Forms;

namespace Library
{
    public partial class AddUserForm : Form
    {
        private AdminController _adminController = new AdminController();
        public AddUserForm()
        {
            InitializeComponent();
            comboBox1.Items.Add("User");
            comboBox1.Items.Add("Admin");

            comboBox1.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _adminController.AddNewUser(textBox1.Text, textBox2.Text, comboBox1.SelectedItem.ToString());
                MessageBox.Show("Userul a fost adaugat cu succes");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
