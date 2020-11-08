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
using YourTube.GetDataFromYoutubeClasses;

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
            //GetUsersUsername getUsersUsername = new GetUsersUsername();
            GetInfo getInfo = new GetInfo();
            List<string> usernames= getInfo.getUserUsername();
            bool isRegistered = false;
            foreach (string data in usernames)
            {
                if (data==usernameText.Text)
                {
                    MessageBox.Show("Change ussername");
                    isRegistered = true;
                }
            }
            if (isRegistered==false)
            {
                TestApiKey testApiKey = new TestApiKey();
                string testRezult = testApiKey.testApiKey(apiKeyText.Text);
                if (testRezult == "Bad")
                {
                    MessageBox.Show("Your Api key is invalid");
                }
                else
                {
                    AddInfo addInfo = new AddInfo();
                    addInfo.addNewUser(usernameText.Text, passwrodText.Text, apiKeyText.Text);
                    MessageBox.Show("Your have registered successfully");
                    this.Hide();
                    Login login = new Login();
                    login.Show();
                }
            }
        }
    }
}
