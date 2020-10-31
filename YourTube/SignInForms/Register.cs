using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourTube
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void BackBu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(usernameText.Text))
            {
                MessageBox.Show("Please type in your username");
            }
            else if (String.IsNullOrEmpty(passwrodText.Text))
            {
                MessageBox.Show("Please type in your password");
            }
            else if (String.IsNullOrEmpty(repeatPasswordText.Text))
            {
                MessageBox.Show("Please type in your repeat password");
            }
            else if (String.IsNullOrEmpty(apiKeyText.Text))
            {
                MessageBox.Show("Please type in your Api key");
            }
            else if (passwrodText.Text!=repeatPasswordText.Text)
            {
                MessageBox.Show("Your passwords don't mach");
            }
            //chech in db for the same username
            MessageBox.Show("Your have registered successfully");
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
