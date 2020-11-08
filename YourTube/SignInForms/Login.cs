using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YourTube.DataBaseClasses;
using YourTube.DataClass;
using YourTube.GetDataFromYoutubeClasses;

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
            else
            {
                GetInfo getInfo = new GetInfo();
                int check = getInfo.checkUserCredentials(usenameText.Text, passwordText.Text);
                TestApiKey testApiKey = new TestApiKey();
                string testRezults= testApiKey.testApiKey(UserGetSet.apiKey);
                YourTube yourTube = new YourTube();
                if (testRezults=="Bad")
                {
                    MessageBox.Show("Your Api Key has expired please change it");
                    this.Hide();
                    yourTube.Show();
                }
                else if (check == 1)
                {
                    this.Hide();
                    yourTube.Show();
                }
                else MessageBox.Show("Error your credentials are bad");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }
    }
}
