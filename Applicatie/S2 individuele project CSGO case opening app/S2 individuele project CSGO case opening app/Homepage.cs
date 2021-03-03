using Class_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S2_individuele_project_CSGO_case_opening_app
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
            TestDatabaseManager dbMan = new TestDatabaseManager();

            var tests = dbMan.GetAllTest();

            foreach (var test in tests)
            {
                Console.WriteLine(test);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }
    }
}
