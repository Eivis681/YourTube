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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void BackBu_Click(object sender, EventArgs e)
        {
            this.Hide();
            YourTube yourTube = new YourTube();
            yourTube.Show();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(oldPassword.Text))
            {
                MessageBox.Show("Please type in your old password");
            }
            else if (String.IsNullOrEmpty(newPassword.Text))
            {
                MessageBox.Show("Please type in your new password");
            }
            else if (String.IsNullOrEmpty(repeatPassword.Text))
            {
                MessageBox.Show("Please type in your repeat new password");
            }
            else if (oldPassword.Text!=repeatPassword.Text)
            {
                MessageBox.Show("Your new and repeated passwords dont mach");
            }
            // chech old password in db 
            //save new password to db
            MessageBox.Show("Your password has been successfully changed");
            this.Hide();
            YourTube yourTube = new YourTube();
            yourTube.Show();
        }
    }
}
