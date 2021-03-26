using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace S2_individuele_project_CSGO_case_opening_app
{
    public partial class Caseopeningpage : Form
    {
        public Caseopeningpage()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Homepage HP = new Homepage();
            HP.Show();
            this.Hide();
        }
    }
}
