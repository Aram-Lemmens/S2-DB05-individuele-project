using Class_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace S2_individuele_project_CSGO_case_opening_app
{
    public partial class Loginpage : Form
    {
        DatabaseManager ULogin = new DatabaseManager();
        Login adduser = new Login();
        public Loginpage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(adduser.GetAllUsers(email_txt.Text, password_txt.Text) != null)
            {                
                Homepage HP = new Homepage();
                HP.Show();
                this.Hide();
            }
        }

        private void New_account_btn_Click(object sender, EventArgs e)
        {
            {
                AddUserpage AUP = new AddUserpage();
                AUP.Show();
                this.Hide();
            }
        }
    }
}
