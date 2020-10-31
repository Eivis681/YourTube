using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using YourTube.GetDataFromYoutubeClasses;
using YourTube.VideoDownloadClasses;

namespace YourTube
{
    public partial class YourTube : Form
    {
        private readonly SongPlaylistDownload songPlaylistDownload;
        private readonly SongDownload songDownload;
        private readonly VideoDownload videoDownload;
        private readonly VideoPlaylistDownload videoPlaylistDownload;
        public YourTube()
        {
            InitializeComponent();
            songPlaylistDownload = new SongPlaylistDownload(ProgressBar);
            songDownload = new SongDownload(ProgressBar);
            videoDownload = new VideoDownload(ProgressBarVideo);
            videoPlaylistDownload = new VideoPlaylistDownload(ProgressBarVideo);
            //labelUsername.Text= get from db username of user
            //labelApiKey.Text= get from db username of user 
            //labelTotalPlaylist.text = get all playlist from db
        }

        private void Mp3Download_Click(object sender, EventArgs e)
        {
            string[] array = uriTextBoxSong.Text.Split('?');
            if (String.IsNullOrEmpty(uriTextBoxSong.Text))
            {
                MessageBox.Show("Please insert your URL");
            }
            else if (String.IsNullOrEmpty(saveToTextBoxSong.Text))
            {
                MessageBox.Show("Please select where you want to save your file");
            }
            else if (array[0] != "https://www.youtube.com/watch" && array[0] != "https://www.youtube.com/playlist")
            {
                MessageBox.Show("We only support Youtube.com links");
            }
            else if (array[0] == "https://www.youtube.com/watch")
            {
                SongDownload songDownload = new SongDownload(ProgressBar);
                DialogResult dr = MessageBox.Show("Do you want to download this one song", "Download", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    songProgressBar.Maximum = 1;
                    toLab.Text = "1";
                    songDownload.DownloadSong(uriTextBoxSong.Text, saveToTextBoxSong.Text);
                }
            }
            else if (array[0] == "https://www.youtube.com/playlist")
            {
                SongPlaylistDownload playlistDownload = new SongPlaylistDownload(ProgressBar);
                DialogResult dr = MessageBox.Show("This is a song play list do you want to download it ?", "Download", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    DialogResult dr1 = MessageBox.Show("Do you want to save this play list to your database?", "Download", MessageBoxButtons.YesNo);
                    if (dr1 == DialogResult.Yes)
                    {
                        GetTitles get = new GetTitles();
                        List<string> titles = get.getTitles(uriTextBoxSong.Text);
                        if (titles[0] == "error")
                        {
                            MessageBox.Show("Your playlist link is invalid or API key is invalid");
                        }
                        else
                        {
                            string playlistName = Microsoft.VisualBasic.Interaction.InputBox("Please type in your playlist name", "Download", "");
                            //save titles to database 
                            LinksFromPlaylist linksFromPlaylist = new LinksFromPlaylist();
                            List<string> videoIdLists = linksFromPlaylist.getLinks(uriTextBoxSong.Text);
                            songProgressBar.Maximum = videoIdLists.Count;
                            toLab.Text = videoIdLists.Count.ToString();
                            string[] playlistID = uriTextBoxSong.Text.Split('=');
                            int index = 0;
                            playlistDownload.DownloadSongPlaylist(videoIdLists, saveToTextBoxSong.Text, playlistID[1], index);
                        }

                    }
                    else if (dr1 == DialogResult.No)
                    {
                        LinksFromPlaylist linksFromPlaylist = new LinksFromPlaylist();
                        List<string> videoIdLists = linksFromPlaylist.getLinks(uriTextBoxSong.Text);
                        if (videoIdLists[0] == "error")
                        {
                            MessageBox.Show("Your playlist link is invalid or API key is invalid");
                        }
                        else
                        {
                            songProgressBar.Maximum = videoIdLists.Count;
                            toLab.Text = videoIdLists.Count.ToString();
                            fromLab.Text = "0 /";
                            string[] playlistID = uriTextBoxSong.Text.Split('=');
                            int index = 0;
                            playlistDownload.DownloadSongPlaylist(videoIdLists, saveToTextBoxSong.Text, playlistID[1], index);
                        }
                    }
                }
            }
        }
        private void SongBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                saveToTextBoxSong.Text = folderDlg.SelectedPath.ToString();
            }
        }
        private void VideoBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                saveToTextBoxVideo.Text = folderDlg.SelectedPath.ToString();
            }
        }

        private void VideoDownload_Click(object sender, EventArgs e)
        {
            string[] videoArray = videoURL.Text.Split('?');
            if (String.IsNullOrEmpty(videoURL.Text))
            {
                MessageBox.Show("Please insert your video URL");
            }
            else if (String.IsNullOrEmpty(saveToTextBoxVideo.Text))
            {
                MessageBox.Show("Please select where you want to save your video");
            }
            else if (MP4.Checked == false && MKV.Checked == false)
            {
                MessageBox.Show("Please select video format");
            }
            else if (videoArray[0] != "https://www.youtube.com/watch" && videoArray[0] != "https://www.youtube.com/playlist")
            {
                MessageBox.Show("We only support Youtube.com links");
            }
            else if (videoArray[0] == "https://www.youtube.com/watch")
            {
                VideoDownload videoDownload = new VideoDownload(ProgressBarVideo);
                string format1 = null;
                if (MP4.Checked == true)
                {
                    format1 = MP4.Text;
                }
                else if (MP4.Checked == true)
                {
                    format1 = MP4.Text;
                }
                DialogResult dr = MessageBox.Show("Do you want to download this video", "Download", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    videoProgressBar.Maximum = 1;
                    toVidLab.Text = 1.ToString();
                    videoDownload.DownloadVideo(videoURL.Text, saveToTextBoxVideo.Text, format1);
                }
            }
            else if (videoArray[0] == "https://www.youtube.com/playlist")
            {
                DialogResult dr = MessageBox.Show("This is a video play list do you want to download it ?", "Download", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    LinksFromPlaylist linksFromPlaylist = new LinksFromPlaylist();
                    List<string> videoIdLists = linksFromPlaylist.getLinks(videoURL.Text);
                    if (videoIdLists[0] == "error")
                    {
                        MessageBox.Show("Your playlist link is invalid or API key is invalid");
                    }
                    VideoPlaylistDownload videosDownloads = new VideoPlaylistDownload(ProgressBarVideo);
                    int index = 0;
                    string[] playlistID = videoURL.Text.Split('=');
                    videoProgressBar.Maximum = videoIdLists.Count;
                    toVidLab.Text = videoIdLists.Count.ToString();
                    videosDownloads.downloadVideoPlaylist(videoIdLists, saveToTextBoxVideo.Text, index,playlistID[1]);
                }
            }
        }

        private void CreatePlaylistButton_Click(object sender, EventArgs e)
        {
            CreatePlaylist createPlaylist = new CreatePlaylist();
            this.Hide();
            createPlaylist.Show();
        }

        private void InspectPlaylistBu_Click(object sender, EventArgs e)
        {
            this.Hide();
            InspectPlaylist inspectPlaylist = new InspectPlaylist();
            inspectPlaylist.Show();
        }

        private void RenamePlaylist_Click(object sender, EventArgs e)
        {
            //var result = Interaction.InputBox("Please type in a new playlist name", "Rename", "");
            //if (result == DialogResult.OK)
            //{

            //}
        }
        private void ProgressBar(int number)
        {
            Invoke((MethodInvoker)delegate ()
            {
                songProgressBar.Value = number;
                fromLab.Text = number.ToString() + "/";
            });
        }
        private void ProgressBarVideo(int number)
        {
            Invoke((MethodInvoker)delegate ()
            {
                videoProgressBar.Value = number;
                fromVidLab.Text = number.ToString() + "/";
            });
        }

        public void UpdateVideoBar(int index)
        {
            videoProgressBar.Value = index;

        }

        private void EditKeyy_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditKey editKey = new EditKey();
            editKey.Show();
        }

        private void deleteAccount_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete your account", "Download", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                //delete from db account 
                MessageBox.Show("Your account has beend deletes cessfully");
                Login login = new Login();
                this.Hide();
                login.Show();
            }
        }
        private void changePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassword changePassword = new ChangePassword();
            changePassword.Show();
        }
        public void DownloadEn()
        {
            MessageBox.Show("Your item has succesfully downloaded");
            songProgressBar.Value = 0;
            fromLab.Text = 0 + "/";
        }
        public void YouHaveSong()
        {
            MessageBox.Show("You already have this song in your folder");
        }
        public void YourHaveVideo()
        {
            MessageBox.Show("You already have this video in your folder");
        }
    }
}
