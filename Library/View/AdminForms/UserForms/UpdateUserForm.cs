using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Library
{
    public partial class UpdateUserForm : Form
    {
        private AdminController _adminController = new AdminController();
        public UpdateUserForm()
        {
            InitializeComponent();
            List<User> userList = XMLUtility<List<User>>.ReadData("users.xml");
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = userList;
            comboBox1.DataSource = bindingSource;
            comboBox1.DisplayMember = "Username";

            comboBox2.Items.Add("User");
            comboBox2.Items.Add("Admin");

            comboBox2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _adminController.UpdateUser(comboBox1.Text.ToString(), textBox1.Text, comboBox2.SelectedItem.ToString());
                MessageBox.Show("Userul a fost updatat");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
