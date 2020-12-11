namespace YourTube
{
    partial class YourTube
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MP3 = new System.Windows.Forms.TabPage();
            this.fromLab = new System.Windows.Forms.Label();
            this.Mp3Download = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.toLab = new System.Windows.Forms.Label();
            this.SongBrowse = new System.Windows.Forms.Button();
            this.saveToTextBoxSong = new System.Windows.Forms.TextBox();
            this.songProgressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.uriTextBoxSong = new System.Windows.Forms.TextBox();
            this.Videos = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MKV = new System.Windows.Forms.RadioButton();
            this.MP4 = new System.Windows.Forms.RadioButton();
            this.fromVidLab = new System.Windows.Forms.Label();
            this.toVidLab = new System.Windows.Forms.Label();
            this.videoProgressBar = new System.Windows.Forms.ProgressBar();
            this.VideoDownload = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.VideoBrowse = new System.Windows.Forms.Button();
            this.saveToTextBoxVideo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.videoURL = new System.Windows.Forms.TextBox();
            this.Playlists = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.playlistName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playlistUrl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DownloadPlaylist = new System.Windows.Forms.Button();
            this.InspectPlaylistBu = new System.Windows.Forms.Button();
            this.RenamePlaylist = new System.Windows.Forms.Button();
            this.DeletePlaylist = new System.Windows.Forms.Button();
            this.CreatePlaylistButton = new System.Windows.Forms.Button();
            this.Account = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.deleteAccount = new System.Windows.Forms.Button();
            this.EditKeyy = new System.Windows.Forms.Button();
            this.changePassword = new System.Windows.Forms.Button();
            this.labelTotalPlaylist = new System.Windows.Forms.Label();
            this.labelApiKey = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.MP3.SuspendLayout();
            this.Videos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Playlists.SuspendLayout();
            this.Account.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MP3);
            this.tabControl1.Controls.Add(this.Videos);
            this.tabControl1.Controls.Add(this.Playlists);
            this.tabControl1.Controls.Add(this.Account);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(472, 248);
            this.tabControl1.TabIndex = 0;
            // 
            // MP3
            // 
            this.MP3.Controls.Add(this.fromLab);
            this.MP3.Controls.Add(this.Mp3Download);
            this.MP3.Controls.Add(this.label3);
            this.MP3.Controls.Add(this.toLab);
            this.MP3.Controls.Add(this.SongBrowse);
            this.MP3.Controls.Add(this.saveToTextBoxSong);
            this.MP3.Controls.Add(this.songProgressBar);
            this.MP3.Controls.Add(this.label1);
            this.MP3.Controls.Add(this.uriTextBoxSong);
            this.MP3.Location = new System.Drawing.Point(4, 22);
            this.MP3.Name = "MP3";
            this.MP3.Padding = new System.Windows.Forms.Padding(3);
            this.MP3.Size = new System.Drawing.Size(464, 222);
            this.MP3.TabIndex = 0;
            this.MP3.Text = "MP3";
            this.MP3.UseVisualStyleBackColor = true;
            // 
            // fromLab
            // 
            this.fromLab.AutoSize = true;
            this.fromLab.Location = new System.Drawing.Point(6, 147);
            this.fromLab.Name = "fromLab";
            this.fromLab.Size = new System.Drawing.Size(18, 13);
            this.fromLab.TabIndex = 10;
            this.fromLab.Text = "0/";
            // 
            // Mp3Download
            // 
            this.Mp3Download.Location = new System.Drawing.Point(183, 147);
            this.Mp3Download.Name = "Mp3Download";
            this.Mp3Download.Size = new System.Drawing.Size(75, 23);
            this.Mp3Download.TabIndex = 6;
            this.Mp3Download.Text = "Download";
            this.Mp3Download.UseVisualStyleBackColor = true;
            this.Mp3Download.Click += new System.EventHandler(this.Mp3Download_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Save to:";
            // 
            // toLab
            // 
            this.toLab.AutoSize = true;
            this.toLab.Location = new System.Drawing.Point(37, 147);
            this.toLab.Name = "toLab";
            this.toLab.Size = new System.Drawing.Size(13, 13);
            this.toLab.TabIndex = 2;
            this.toLab.Text = "0";
            // 
            // SongBrowse
            // 
            this.SongBrowse.Location = new System.Drawing.Point(383, 80);
            this.SongBrowse.Name = "SongBrowse";
            this.SongBrowse.Size = new System.Drawing.Size(75, 23);
            this.SongBrowse.TabIndex = 2;
            this.SongBrowse.Text = "Browse";
            this.SongBrowse.UseVisualStyleBackColor = true;
            this.SongBrowse.Click += new System.EventHandler(this.SongBrowse_Click);
            // 
            // saveToTextBoxSong
            // 
            this.saveToTextBoxSong.Location = new System.Drawing.Point(3, 82);
            this.saveToTextBoxSong.Name = "saveToTextBoxSong";
            this.saveToTextBoxSong.Size = new System.Drawing.Size(374, 20);
            this.saveToTextBoxSong.TabIndex = 2;
            // 
            // songProgressBar
            // 
            this.songProgressBar.Location = new System.Drawing.Point(3, 109);
            this.songProgressBar.Name = "songProgressBar";
            this.songProgressBar.Size = new System.Drawing.Size(455, 23);
            this.songProgressBar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Song URI:";
            // 
            // uriTextBoxSong
            // 
            this.uriTextBoxSong.Location = new System.Drawing.Point(3, 29);
            this.uriTextBoxSong.Name = "uriTextBoxSong";
            this.uriTextBoxSong.Size = new System.Drawing.Size(455, 20);
            this.uriTextBoxSong.TabIndex = 0;
            // 
            // Videos
            // 
            this.Videos.Controls.Add(this.fromVidLab);
            this.Videos.Controls.Add(this.toVidLab);
            this.Videos.Controls.Add(this.videoProgressBar);
            this.Videos.Controls.Add(this.VideoDownload);
            this.Videos.Controls.Add(this.label5);
            this.Videos.Controls.Add(this.VideoBrowse);
            this.Videos.Controls.Add(this.saveToTextBoxVideo);
            this.Videos.Controls.Add(this.label6);
            this.Videos.Controls.Add(this.videoURL);
            this.Videos.Location = new System.Drawing.Point(4, 22);
            this.Videos.Name = "Videos";
            this.Videos.Padding = new System.Windows.Forms.Padding(3);
            this.Videos.Size = new System.Drawing.Size(464, 222);
            this.Videos.TabIndex = 1;
            this.Videos.Text = "Videos";
            this.Videos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MKV);
            this.groupBox1.Controls.Add(this.MP4);
            this.groupBox1.Location = new System.Drawing.Point(502, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 35);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Video Quality";
            // 
            // MKV
            // 
            this.MKV.AutoSize = true;
            this.MKV.Location = new System.Drawing.Point(76, 12);
            this.MKV.Name = "MKV";
            this.MKV.Size = new System.Drawing.Size(46, 17);
            this.MKV.TabIndex = 13;
            this.MKV.TabStop = true;
            this.MKV.Text = "Best";
            this.MKV.UseVisualStyleBackColor = true;
            // 
            // MP4
            // 
            this.MP4.AutoSize = true;
            this.MP4.Location = new System.Drawing.Point(15, 12);
            this.MP4.Name = "MP4";
            this.MP4.Size = new System.Drawing.Size(45, 17);
            this.MP4.TabIndex = 12;
            this.MP4.TabStop = true;
            this.MP4.Text = "Low";
            this.MP4.UseVisualStyleBackColor = true;
            // 
            // fromVidLab
            // 
            this.fromVidLab.AutoSize = true;
            this.fromVidLab.Location = new System.Drawing.Point(6, 145);
            this.fromVidLab.Name = "fromVidLab";
            this.fromVidLab.Size = new System.Drawing.Size(18, 13);
            this.fromVidLab.TabIndex = 15;
            this.fromVidLab.Text = "0/";
            // 
            // toVidLab
            // 
            this.toVidLab.AutoSize = true;
            this.toVidLab.Location = new System.Drawing.Point(37, 145);
            this.toVidLab.Name = "toVidLab";
            this.toVidLab.Size = new System.Drawing.Size(13, 13);
            this.toVidLab.TabIndex = 14;
            this.toVidLab.Text = "0";
            // 
            // videoProgressBar
            // 
            this.videoProgressBar.Location = new System.Drawing.Point(3, 111);
            this.videoProgressBar.Name = "videoProgressBar";
            this.videoProgressBar.Size = new System.Drawing.Size(455, 23);
            this.videoProgressBar.TabIndex = 9;
            // 
            // VideoDownload
            // 
            this.VideoDownload.Location = new System.Drawing.Point(185, 140);
            this.VideoDownload.Name = "VideoDownload";
            this.VideoDownload.Size = new System.Drawing.Size(75, 23);
            this.VideoDownload.TabIndex = 7;
            this.VideoDownload.Text = "Download";
            this.VideoDownload.UseVisualStyleBackColor = true;
            this.VideoDownload.Click += new System.EventHandler(this.VideoDownload_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Save to:";
            // 
            // VideoBrowse
            // 
            this.VideoBrowse.Location = new System.Drawing.Point(383, 73);
            this.VideoBrowse.Name = "VideoBrowse";
            this.VideoBrowse.Size = new System.Drawing.Size(75, 21);
            this.VideoBrowse.TabIndex = 8;
            this.VideoBrowse.Text = "Browse";
            this.VideoBrowse.UseVisualStyleBackColor = true;
            this.VideoBrowse.Click += new System.EventHandler(this.VideoBrowse_Click);
            // 
            // saveToTextBoxVideo
            // 
            this.saveToTextBoxVideo.Location = new System.Drawing.Point(3, 73);
            this.saveToTextBoxVideo.Name = "saveToTextBoxVideo";
            this.saveToTextBoxVideo.Size = new System.Drawing.Size(374, 20);
            this.saveToTextBoxVideo.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Video URL:";
            // 
            // videoURL
            // 
            this.videoURL.Location = new System.Drawing.Point(3, 20);
            this.videoURL.Name = "videoURL";
            this.videoURL.Size = new System.Drawing.Size(455, 20);
            this.videoURL.TabIndex = 6;
            // 
            // Playlists
            // 
            this.Playlists.Controls.Add(this.listView1);
            this.Playlists.Controls.Add(this.DownloadPlaylist);
            this.Playlists.Controls.Add(this.InspectPlaylistBu);
            this.Playlists.Controls.Add(this.RenamePlaylist);
            this.Playlists.Controls.Add(this.DeletePlaylist);
            this.Playlists.Controls.Add(this.CreatePlaylistButton);
            this.Playlists.Location = new System.Drawing.Point(4, 22);
            this.Playlists.Name = "Playlists";
            this.Playlists.Size = new System.Drawing.Size(367, 222);
            this.Playlists.TabIndex = 2;
            this.Playlists.Text = "Playlists";
            this.Playlists.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.playlistName,
            this.playlistUrl});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-4, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(365, 215);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // playlistName
            // 
            this.playlistName.Text = "Playlist Name";
            this.playlistName.Width = 255;
            // 
            // playlistUrl
            // 
            this.playlistUrl.Text = "Song Count";
            this.playlistUrl.Width = 107;
            // 
            // DownloadPlaylist
            // 
            this.DownloadPlaylist.Location = new System.Drawing.Point(367, 139);
            this.DownloadPlaylist.Name = "DownloadPlaylist";
            this.DownloadPlaylist.Size = new System.Drawing.Size(84, 23);
            this.DownloadPlaylist.TabIndex = 4;
            this.DownloadPlaylist.Text = "Download";
            this.DownloadPlaylist.UseVisualStyleBackColor = true;
            this.DownloadPlaylist.Click += new System.EventHandler(this.DownloadPlaylist_Click);
            // 
            // InspectPlaylistBu
            // 
            this.InspectPlaylistBu.Location = new System.Drawing.Point(367, 110);
            this.InspectPlaylistBu.Name = "InspectPlaylistBu";
            this.InspectPlaylistBu.Size = new System.Drawing.Size(84, 23);
            this.InspectPlaylistBu.TabIndex = 3;
            this.InspectPlaylistBu.Text = "Inspect";
            this.InspectPlaylistBu.UseVisualStyleBackColor = true;
            this.InspectPlaylistBu.Click += new System.EventHandler(this.InspectPlaylistBu_Click);
            // 
            // RenamePlaylist
            // 
            this.RenamePlaylist.Location = new System.Drawing.Point(367, 81);
            this.RenamePlaylist.Name = "RenamePlaylist";
            this.RenamePlaylist.Size = new System.Drawing.Size(84, 23);
            this.RenamePlaylist.TabIndex = 2;
            this.RenamePlaylist.Text = "Rename";
            this.RenamePlaylist.UseVisualStyleBackColor = true;
            this.RenamePlaylist.Click += new System.EventHandler(this.RenamePlaylist_Click);
            // 
            // DeletePlaylist
            // 
            this.DeletePlaylist.Location = new System.Drawing.Point(367, 52);
            this.DeletePlaylist.Name = "DeletePlaylist";
            this.DeletePlaylist.Size = new System.Drawing.Size(84, 23);
            this.DeletePlaylist.TabIndex = 1;
            this.DeletePlaylist.Text = "Delete Playlist";
            this.DeletePlaylist.UseVisualStyleBackColor = true;
            this.DeletePlaylist.Click += new System.EventHandler(this.DeletePlaylist_Click);
            // 
            // CreatePlaylistButton
            // 
            this.CreatePlaylistButton.Location = new System.Drawing.Point(367, 23);
            this.CreatePlaylistButton.Name = "CreatePlaylistButton";
            this.CreatePlaylistButton.Size = new System.Drawing.Size(84, 23);
            this.CreatePlaylistButton.TabIndex = 0;
            this.CreatePlaylistButton.Text = "Create playlist";
            this.CreatePlaylistButton.UseVisualStyleBackColor = true;
            this.CreatePlaylistButton.Click += new System.EventHandler(this.CreatePlaylistButton_Click);
            // 
            // Account
            // 
            this.Account.Controls.Add(this.button1);
            this.Account.Controls.Add(this.deleteAccount);
            this.Account.Controls.Add(this.EditKeyy);
            this.Account.Controls.Add(this.changePassword);
            this.Account.Controls.Add(this.labelTotalPlaylist);
            this.Account.Controls.Add(this.labelApiKey);
            this.Account.Controls.Add(this.labelUsername);
            this.Account.Controls.Add(this.label9);
            this.Account.Controls.Add(this.label8);
            this.Account.Controls.Add(this.label2);
            this.Account.Location = new System.Drawing.Point(4, 22);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(367, 222);
            this.Account.TabIndex = 3;
            this.Account.Text = "Account";
            this.Account.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(386, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Sign out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteAccount
            // 
            this.deleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAccount.Location = new System.Drawing.Point(171, 133);
            this.deleteAccount.Name = "deleteAccount";
            this.deleteAccount.Size = new System.Drawing.Size(127, 30);
            this.deleteAccount.TabIndex = 17;
            this.deleteAccount.Text = "Delete account";
            this.deleteAccount.UseVisualStyleBackColor = true;
            this.deleteAccount.Click += new System.EventHandler(this.deleteAccount_Click);
            // 
            // EditKeyy
            // 
            this.EditKeyy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditKeyy.Location = new System.Drawing.Point(334, 133);
            this.EditKeyy.Name = "EditKeyy";
            this.EditKeyy.Size = new System.Drawing.Size(127, 30);
            this.EditKeyy.TabIndex = 16;
            this.EditKeyy.Text = "Edit key";
            this.EditKeyy.UseVisualStyleBackColor = true;
            this.EditKeyy.Click += new System.EventHandler(this.EditKeyy_Click);
            // 
            // changePassword
            // 
            this.changePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePassword.Location = new System.Drawing.Point(7, 133);
            this.changePassword.Name = "changePassword";
            this.changePassword.Size = new System.Drawing.Size(127, 30);
            this.changePassword.TabIndex = 10;
            this.changePassword.Text = "Change password";
            this.changePassword.UseVisualStyleBackColor = true;
            this.changePassword.Click += new System.EventHandler(this.changePassword_Click);
            // 
            // labelTotalPlaylist
            // 
            this.labelTotalPlaylist.AutoSize = true;
            this.labelTotalPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPlaylist.Location = new System.Drawing.Point(132, 97);
            this.labelTotalPlaylist.Name = "labelTotalPlaylist";
            this.labelTotalPlaylist.Size = new System.Drawing.Size(131, 18);
            this.labelTotalPlaylist.TabIndex = 15;
            this.labelTotalPlaylist.Text = "number of playlists";
            // 
            // labelApiKey
            // 
            this.labelApiKey.AutoSize = true;
            this.labelApiKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApiKey.Location = new System.Drawing.Point(84, 55);
            this.labelApiKey.Name = "labelApiKey";
            this.labelApiKey.Size = new System.Drawing.Size(54, 18);
            this.labelApiKey.TabIndex = 14;
            this.labelApiKey.Text = "api key";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(105, 12);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(81, 18);
            this.labelUsername.TabIndex = 13;
            this.labelUsername.Text = "Username:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Total playlists:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "API key:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Username:";
            // 
            // YourTube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 269);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "YourTube";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.MP3.ResumeLayout(false);
            this.MP3.PerformLayout();
            this.Videos.ResumeLayout(false);
            this.Videos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Playlists.ResumeLayout(false);
            this.Account.ResumeLayout(false);
            this.Account.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MP3;
        private System.Windows.Forms.Button Mp3Download;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SongBrowse;
        private System.Windows.Forms.TextBox saveToTextBoxSong;
        private System.Windows.Forms.ProgressBar songProgressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uriTextBoxSong;
        private System.Windows.Forms.TabPage Videos;
        private System.Windows.Forms.TabPage Playlists;
        private System.Windows.Forms.TabPage Account;
        private System.Windows.Forms.Label toLab;
        private System.Windows.Forms.Button VideoDownload;
        private System.Windows.Forms.RadioButton MKV;
        private System.Windows.Forms.RadioButton MP4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button VideoBrowse;
        private System.Windows.Forms.TextBox saveToTextBoxVideo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox videoURL;
        private System.Windows.Forms.ProgressBar videoProgressBar;
        private System.Windows.Forms.Button DownloadPlaylist;
        private System.Windows.Forms.Button InspectPlaylistBu;
        private System.Windows.Forms.Button RenamePlaylist;
        private System.Windows.Forms.Button DeletePlaylist;
        private System.Windows.Forms.Button CreatePlaylistButton;
        private System.Windows.Forms.Label fromLab;
        private System.Windows.Forms.Button deleteAccount;
        private System.Windows.Forms.Button EditKeyy;
        private System.Windows.Forms.Button changePassword;
        private System.Windows.Forms.Label labelTotalPlaylist;
        private System.Windows.Forms.Label labelApiKey;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fromVidLab;
        private System.Windows.Forms.Label toVidLab;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader playlistName;
        private System.Windows.Forms.ColumnHeader playlistUrl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

