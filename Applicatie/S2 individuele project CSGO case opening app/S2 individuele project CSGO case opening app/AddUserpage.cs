using Class_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace S2_individuele_project_CSGO_case_opening_app
{
    public partial class AddUserpage : Form
    {

        public AddUserpage()
        {
            InitializeComponent();
        }
        AddUser addUser = new AddUser();
        private void button1_Click(object sender, EventArgs e)
        {
            var first_name = First_name_txt.Text;
            var last_name = Last_name_txt.Text;
            var email = Email_txt.Text;
            var password = Password_txt.Text;
            if (first_name != "" && last_name != "" && email != "" && password != "")
            {
                addUser.GetAllUsers(first_name, last_name, email, password);
                Loginpage LP = new Loginpage();
                LP.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Fill in all the information");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Loginpage LP = new Loginpage();
            LP.Show();
            this.Hide();
        }
    }
}
