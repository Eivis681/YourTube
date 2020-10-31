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
    public partial class InspectPlaylist : Form
    {
        public InspectPlaylist()
        {
            InitializeComponent();
        }

        private void AddSong_Click(object sender, EventArgs e)
        {

        }

        private void DeleteSong_Click(object sender, EventArgs e)
        {

        }

        private void Download_Click(object sender, EventArgs e)
        {

        }

        private void BackBu_Click(object sender, EventArgs e)
        {
            this.Hide();
            YourTube yourTube = new YourTube();
            yourTube.Show();
        }
    }
}
