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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(usenameText.Text))
            {
                MessageBox.Show("Please type in your ussername");
            }
            else if (String.IsNullOrEmpty(passwordText.Text))
            {
                MessageBox.Show("Please type in your password");
            }
            //chech from db user credentials
            YourTube yourTube = new YourTube();
            this.Hide();
            yourTube.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }
    }
}
