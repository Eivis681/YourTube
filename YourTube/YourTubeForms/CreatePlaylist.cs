﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YourTube.DataBaseClasses;

namespace YourTube
{
    public partial class CreatePlaylist : Form
    {
        public CreatePlaylist()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string[] array = playlistLink.Text.Split('?');
            if (String.IsNullOrEmpty(playlistName.Text))
            {
                MessageBox.Show("Please type in your playlist name");
            }
            else if (String.IsNullOrEmpty(playlistLink.Text))
            {
                MessageBox.Show("Please insert your youtube link");
            }
            else if (array[0] != "https://www.youtube.com/watch" && array[0] != "https://www.youtube.com/playlist")
            {
                MessageBox.Show("We only support Youtube.com links");
            }
            else if (array[0] == "https://www.youtube.com/watch")
            {
                DialogResult dr = MessageBox.Show("It's a single song do you want to add it ?", "Download", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    //SaveNewPlaylist saveNewPlaylist = new SaveNewPlaylist();
                    AddInfo addInfo = new AddInfo();
                    addInfo.addNewPlaylist(playlistName.Text, playlistLink.Text,"No");
                    //test it more
                }
            }
            else if (array[0] == "https://www.youtube.com/playlist")
            {
                DialogResult dr = MessageBox.Show("This is a song play list do you want to add it ?", "Download", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    //SaveNewPlaylist saveNewPlaylist = new SaveNewPlaylist();
                    AddInfo addInfo = new AddInfo();
                    addInfo.addNewPlaylist(playlistName.Text, playlistLink.Text,"No");
                    MessageBox.Show("Your playlist has been added successfully");
                    this.Hide();
                    YourTube yourTube = new YourTube();
                    yourTube.Show();
                    //test it more 
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            YourTube yourTube = new YourTube();
            yourTube.Show();
        }
    }
}
