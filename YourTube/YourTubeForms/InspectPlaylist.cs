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
using YourTube.GetDataFromYoutubeClasses;
using YourTube.SongDownloadClasses;

namespace YourTube
{
    public partial class InspectPlaylist : Form
    {
        private readonly OneSongDownload oneSongDownload;
        public InspectPlaylist()
        {
            InitializeComponent();
            oneSongDownload = new OneSongDownload(ProgressBar);
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
            string directory = Microsoft.VisualBasic.Interaction.InputBox("Please type in where you want to save the playlist", "Save", "");
            if (directory == "")
            {
            }
            else if (Directory.Exists(directory))
            {
                GetInfo getInfo = new GetInfo();
                UserGetSet.input();
                List<string> videoId = getInfo.getAllVideoId(UserGetSet.selectedPlaylis);
                progressBar1.Maximum = videoId.Count;
                toLab.Text = videoId.Count.ToString();
                OneSongDownload oneSongDownload = new OneSongDownload(ProgressBar);
                oneSongDownload.DownloadSong(videoId, directory);
                UpdateInfo updateInfo = new UpdateInfo();
                updateInfo.updateStatus(UserGetSet.selectedPlaylis);
            }
            else
            {
                MessageBox.Show("Save location is invalid");
            }
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
                    toLab.Text = "1";
                    progressBar1.Maximum = 1;
                    UpdateInfo updateInfo = new UpdateInfo();
                    updateInfo.updateOneStatus(selectedSongName);
                    GetInfo getInfo = new GetInfo();
                    string videoId= getInfo.oneVideoId(selectedSongName);
                    List<string> id = new List<string>();
                    id.Add(videoId);
                    OneSongDownload songDownload = new OneSongDownload(ProgressBar);
                    songDownload.DownloadSong(id, directory);
                }
                else
                {
                    MessageBox.Show("Save location is invalid");
                } 
            }
        }

        private void DownloadNew_Click(object sender, EventArgs e)
        {
            GetInfo getInfo = new GetInfo();
            List<string> downloadedYesNo = getInfo.getData();
            bool noNew = false;
            for (int i = 0; i<downloadedYesNo.Count;i++)
            {
                string word = downloadedYesNo[i];
                if (word == "No")
                {
                    noNew = true;
                    break;
                }
            }
            if (noNew == true)
            {
                string directory = Microsoft.VisualBasic.Interaction.InputBox("Please type in where you want to save the playlist", "Save", "");
                if (directory == "")
                {
                }
                else if (Directory.Exists(directory))
                {
                    List<string> newVideoId = getInfo.getNewSongVideoId();
                    OneSongDownload songDownload = new OneSongDownload(ProgressBar);
                    toLab.Text = newVideoId.Count.ToString();
                    progressBar1.Maximum= newVideoId.Count; 
                    songDownload.DownloadSong(newVideoId, directory);
                    UpdateInfo updateInfo = new UpdateInfo();
                    UserGetSet.input();
                    updateInfo.updateStatus(UserGetSet.selectedPlaylis);
                }
                else
                {
                    MessageBox.Show("Save location is invalid");
                }
            }
            else MessageBox.Show("There are no new songs in playlist, try updating it");
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

        private void ProgressBar(int number)
        {
            Invoke((MethodInvoker)delegate ()
            {
                progressBar1.Value = number;
                fromLab.Text = number.ToString() + "/";
                if (progressBar1.Value==progressBar1.Maximum)
                {
                    MessageBox.Show("Your  songs have been downloaded");
                    progressBar1.Value = 0;
                    toLab.Text = "0";
                    fromLab.Text = "0/";
                    updateList();
                }
            });
        }

        private void Update_Click(object sender, EventArgs e)
        {
            GetInfo getInfo = new GetInfo();
            LinksFromPlaylist linksFromPlaylist = new LinksFromPlaylist();
            List<string> playlistUrls = getInfo.playlistUrls();

            List<int> videoCount = getInfo.getPlaylistData(playlistUrls);

            List<int> updatedInfoCount = new List<int>();
            List<string> infoCount = new List<string>();
            foreach (string url in playlistUrls)
            {
                infoCount = linksFromPlaylist.getLinks(url);
                updatedInfoCount.Add(infoCount.Count);
            }
            bool noUpdate = false;
            for (int i = 0; i<updatedInfoCount.Count;i++)
            {
                if (videoCount[i]<updatedInfoCount[i])
                {
                    List<string> databaseVideoId = getInfo.getVideoIdUpdate(playlistUrls[i]);
                    List<string> updatedVideoList = new List<string>();
                    List<string> newSongs = linksFromPlaylist.getLinks(playlistUrls[i]);
                    for (int j = 0; j< newSongs.Count;j++)
                    {
                        bool foundVideo = false;
                        for (int z= 0; z<databaseVideoId.Count;z++)
                        {
                            if (newSongs[j]==databaseVideoId[z])
                            {
                                foundVideo = true;
                                break;
                            }
                        }
                        if (foundVideo == false)
                        {
                            updatedVideoList.Add(newSongs[j]);
                        }
                    }
                    AddInfo addInfo = new AddInfo();
                    addInfo.addUpdatedSongs(updatedVideoList,playlistUrls[i]);
                    noUpdate = true;
                }
            }
            if (noUpdate == false)
            {
                MessageBox.Show("There are no available updates");
            }
            else
            {
                updateList();
                MessageBox.Show("Playlists have been updated");
            }
        }
    }
}
