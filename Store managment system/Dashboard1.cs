using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_managment_system
{
    public partial class Dashboard1 : Form
    {
        public Dashboard1()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            home1.BringToFront();
        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            student1.BringToFront();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            teachers1.BringToFront();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            grade1.BringToFront();
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            salarey1.BringToFront();
        }
    }
}
