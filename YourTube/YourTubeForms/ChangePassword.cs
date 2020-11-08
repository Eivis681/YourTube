using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YourTube.DataClass;

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
            UserGetSet.input();
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
            else if (newPassword.Text!=repeatPassword.Text)
            {
                MessageBox.Show("Your new and repeated passwords dont mach");
            }
            else if (UserGetSet.password!=oldPassword.Text)
            {
                MessageBox.Show("Your old password dosent match");
            }
            else
            {
                SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=YourTubeDB.db; Version = 3; New = True; Compress = True; ");
                sqlite_conn.Open();
                SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "UPDATE User SET Password = '"+ newPassword.Text+"' WHERE Username = '"+UserGetSet.username+"'";
                sqlite_cmd.ExecuteNonQuery();
                UserGetSet.password = newPassword.Text;
                MessageBox.Show("Your password has been successfully changed");
                this.Hide();
                YourTube yourTube = new YourTube();
                yourTube.Show();
            }
            
           
            
        }
    }
}
