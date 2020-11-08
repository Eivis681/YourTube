using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YourTube.DataBaseClasses;
using YourTube.DataClass;
using YourTube.SongDownloadClasses;

namespace YourTube
{
    public partial class InspectPlaylist : Form
    {
        public InspectPlaylist()
        {
            InitializeComponent();
            updateList();
        }

        private void AddSong_Click(object sender, EventArgs e)
        {
            string playlistName = Microsoft.VisualBasic.Interaction.InputBox("Please type in your new song link", "Add song", "");
            string[] array = playlistName.Split('?');
            if (playlistName =="")
            {
            }
            else if (array[0] != "https://www.youtube.com/watch" && array[0] != "https://www.youtube.com/playlist")
            {
                MessageBox.Show("We only support Youtube.com links");
            }
            else if (array[0] == "https://www.youtube.com/watch")
            {
                //fix adding
                AddInfo addInfo = new AddInfo();
                addInfo.addSong(playlistName);
                MessageBox.Show("Your song has been added");
                updateList();
            }
            else if (array[0] == "https://www.youtube.com/playlist")
            {
                DialogResult dr = MessageBox.Show("This is a song play list do you want to add it ?", "Add song", MessageBoxButtons.YesNo);
                if (dr==DialogResult.Yes)
                {
                    AddInfo addInfo = new AddInfo();
                    UserGetSet.input();
                    addInfo.addSongs(UserGetSet.selectedPlaylis, playlistName, "No");
                    MessageBox.Show("Your songs have been added");
                    updateList();
                }
            }

        }

        private void DeleteSong_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a song");
            }
            else
            {
                string selectedPlaylistName = listView1.Items[listView1.SelectedIndices[0]].Text;
                DeleteInfo deleteInfo = new DeleteInfo();
                deleteInfo.DeleteSong(selectedPlaylistName);
                MessageBox.Show("Song has been deleted");
                updateList();
            }
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

        private void DownloadOne_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a song");
            }
            else
            {
                string selectedSongName = listView1.Items[listView1.SelectedIndices[0]].Text;
                string directory = Microsoft.VisualBasic.Interaction.InputBox("Please type in where you want to save the playlist", "Save", "");
                if (directory == "")
                {
                }
                else if (Directory.Exists(directory))
                {
                    UpdateInfo updateInfo = new UpdateInfo();
                    updateInfo.updateOneStatus(selectedSongName);
                    GetInfo getInfo = new GetInfo();
                    string videoId= getInfo.oneVideoId(selectedSongName);
                    OneSongDownload songDownload = new OneSongDownload();
                    string url = "https://www.youtube.com/watch?v=" + videoId;
                    songDownload.DownloadSong(url, directory);
                    MessageBox.Show("Song has been downloaded");
                    updateList();
                }
                else
                {
                    MessageBox.Show("Save location is invalid");
                } 
            }
        }

        private void DownloadNew_Click(object sender, EventArgs e)
        {
            string directory = Microsoft.VisualBasic.Interaction.InputBox("Please type in where you want to save the playlist", "Save", "");
            if (directory == "")
            {
            }
            else if (Directory.Exists(directory))
            {
                GetInfo getInfo = new GetInfo();
                List<string> newVideoId = getInfo.getNewSongVideoId();
                OneSongDownload songDownload = new OneSongDownload();
                foreach (string videoId in newVideoId)
                {
                    string url = "https://www.youtube.com/watch?v=" + videoId;
                    songDownload.DownloadSong(url, directory);
                }
                UpdateInfo updateInfo = new UpdateInfo();
                UserGetSet.input();
                updateInfo.updateStatus(UserGetSet.selectedPlaylis);
                MessageBox.Show("Songs have been downloaded");
            }
            else
            {
                MessageBox.Show("Save location is invalid");
            }
        }

        public void updateList()
        {
            listView1.Items.Clear();
            GetInfo getInfo = new GetInfo();
            List<string> playlistData = getInfo.getData();
            for (int i = 0; i < playlistData.Count; i = i + 2)
            {
                if (i == 0)
                {
                    listView1.Items.Add(playlistData[i]);
                    listView1.Items[i].SubItems.Add(playlistData[i + 1]);
                }
                else
                {
                    listView1.Items.Add(playlistData[i]);
                    listView1.Items[i / 2].SubItems.Add(playlistData[i + 1]);
                }
            }
        }
    }
}
