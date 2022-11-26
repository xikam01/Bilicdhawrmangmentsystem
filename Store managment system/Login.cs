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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (gunaComboBox1.SelectedItem.ToString() == "Admin")
            {

                if (gunaComboBox1.SelectedItem.ToString() == "Admin")
                {
                    if (gunaTextBox1.Text == "Admin" && gunaTextBox2.Text == "1234")
                    {
                        Dashboard1 dd = new Dashboard1();
                        dd.Show();

                    }
                    else
                    {
                        MessageBox.Show("Please Entar Role");
                    }

                }

            }

            if (gunaComboBox1.SelectedIndex > -2)
            {
                if (gunaComboBox1.SelectedItem.ToString() == "User")
                {
                    if (gunaTextBox1.Text == "User" && gunaTextBox2.Text == "1234")
                    {
                        Dashboard2 daa = new Dashboard2();
                        daa.Show();

                    }
                    else
                    {
                        MessageBox.Show("Please Entar Role");
                    }
                }

            }
   
        }
    }
}
