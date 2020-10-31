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
    public partial class EditKey : Form
    {
        public EditKey()
        {
            InitializeComponent();
            //from db get users api key 
            //textBoxKey.text= is db value
        }

        private void BackBu_Click(object sender, EventArgs e)
        {
            this.Hide();
            YourTube yourTube = new YourTube();
            yourTube.Show();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            //save to db new users key 
            MessageBox.Show("Your API has been saved successfully");
            this.Hide();
            YourTube yourTube = new YourTube();
            yourTube.Show();
        }
    }
}
