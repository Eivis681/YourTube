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
using YourTube.GetDataFromYoutubeClasses;

namespace YourTube
{
    public partial class EditKey : Form
    {
        
        public EditKey()
        {
            InitializeComponent();
            UserGetSet.input();
            textBoxKey.Text = UserGetSet.apiKey;
        }

        private void BackBu_Click(object sender, EventArgs e)
        {
            this.Hide();
            YourTube yourTube = new YourTube();
            yourTube.Show();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            TestApiKey testApiKey = new TestApiKey();
            string testResult = testApiKey.testApiKey(textBoxKey.Text);
            if (testResult == "Bad")
            {
                MessageBox.Show("This Api key is invalid");
            }
            else
            {
                SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=YourTubeDB.db; Version = 3; New = True; Compress = True; ");
                sqlite_conn.Open();
                SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "UPDATE User SET ApiKey = '" + textBoxKey.Text + "' WHERE Username = '" + UserGetSet.username + "'";
                sqlite_cmd.ExecuteNonQuery();
                UserGetSet.apiKey = textBoxKey.Text;
                MessageBox.Show("Your API has been saved successfully");
                this.Hide();
                YourTube yourTube = new YourTube();
                yourTube.Show();
            }
        }
    }
}
