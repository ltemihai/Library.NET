using Library.EmployeeForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Library
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<User> userList = XMLUtility<List<User>>.ReadData("users.xml");
            User user = userList.Find(element => element.Username == textBox1.Text);
            if (user == null)
            {
                MessageBox.Show("Userul nu exista");
            }
            if (user.Password != textBox2.Text)
            {
                MessageBox.Show("Nu-i buna parola");
            }
            if (user.UserType == "Admin")
            {
                Admin form = new Admin();
                form.Show();
                this.Hide();
            }
            if (user.UserType == "User")
            {
                EmployeeForm form = new EmployeeForm();
                form.Show();
                this.Hide();

            }



        }
    }
}
