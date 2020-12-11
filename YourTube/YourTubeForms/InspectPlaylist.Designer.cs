namespace YourTube
{
    partial class InspectPlaylist
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
            this.AddSong = new System.Windows.Forms.Button();
            this.DeleteSong = new System.Windows.Forms.Button();
            this.Download = new System.Windows.Forms.Button();
            this.BackBu = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.songTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.downloaded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Update = new System.Windows.Forms.Button();
            this.DownloadNew = new System.Windows.Forms.Button();
            this.DownloadOne = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.fromLab = new System.Windows.Forms.Label();
            this.toLab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddSong
            // 
            this.AddSong.Location = new System.Drawing.Point(421, 12);
            this.AddSong.Name = "AddSong";
            this.AddSong.Size = new System.Drawing.Size(99, 23);
            this.AddSong.TabIndex = 0;
            this.AddSong.Text = "Add song";
            this.AddSong.UseVisualStyleBackColor = true;
            this.AddSong.Click += new System.EventHandler(this.AddSong_Click);
            // 
            // DeleteSong
            // 
            this.DeleteSong.Location = new System.Drawing.Point(421, 41);
            this.DeleteSong.Name = "DeleteSong";
            this.DeleteSong.Size = new System.Drawing.Size(99, 25);
            this.DeleteSong.TabIndex = 1;
            this.DeleteSong.Text = "Delete song";
            this.DeleteSong.UseVisualStyleBackColor = true;
            this.DeleteSong.Click += new System.EventHandler(this.DeleteSong_Click);
            // 
            // Download
            // 
            this.Download.Location = new System.Drawing.Point(421, 72);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(99, 23);
            this.Download.TabIndex = 2;
            this.Download.Text = "Download All";
            this.Download.UseVisualStyleBackColor = true;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // BackBu
            // 
            this.BackBu.Location = new System.Drawing.Point(421, 188);
            this.BackBu.Name = "BackBu";
            this.BackBu.Size = new System.Drawing.Size(99, 23);
            this.BackBu.TabIndex = 3;
            this.BackBu.Text = "<- Back";
            this.BackBu.UseVisualStyleBackColor = true;
            this.BackBu.Click += new System.EventHandler(this.BackBu_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.songTitle,
            this.downloaded});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(402, 273);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // songTitle
            // 
            this.songTitle.Text = "Song title";
            this.songTitle.Width = 319;
            // 
            // downloaded
            // 
            this.downloaded.Text = "Downloaded";
            this.downloaded.Width = 78;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(421, 159);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(99, 23);
            this.Update.TabIndex = 5;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // DownloadNew
            // 
            this.DownloadNew.Location = new System.Drawing.Point(421, 101);
            this.DownloadNew.Name = "DownloadNew";
            this.DownloadNew.Size = new System.Drawing.Size(99, 23);
            this.DownloadNew.TabIndex = 6;
            this.DownloadNew.Text = "Download New";
            this.DownloadNew.UseVisualStyleBackColor = true;
            this.DownloadNew.Click += new System.EventHandler(this.DownloadNew_Click);
            // 
            // DownloadOne
            // 
            this.DownloadOne.Location = new System.Drawing.Point(421, 130);
            this.DownloadOne.Name = "DownloadOne";
            this.DownloadOne.Size = new System.Drawing.Size(99, 23);
            this.DownloadOne.TabIndex = 7;
            this.DownloadOne.Text = "Download One";
            this.DownloadOne.UseVisualStyleBackColor = true;
            this.DownloadOne.Click += new System.EventHandler(this.DownloadOne_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 292);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(402, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // fromLab
            // 
            this.fromLab.AutoSize = true;
            this.fromLab.Location = new System.Drawing.Point(422, 302);
            this.fromLab.Name = "fromLab";
            this.fromLab.Size = new System.Drawing.Size(18, 13);
            this.fromLab.TabIndex = 12;
            this.fromLab.Text = "0/";
            // 
            // toLab
            // 
            this.toLab.AutoSize = true;
            this.toLab.Location = new System.Drawing.Point(453, 302);
            this.toLab.Name = "toLab";
            this.toLab.Size = new System.Drawing.Size(13, 13);
            this.toLab.TabIndex = 11;
            this.toLab.Text = "0";
            // 
            // InspectPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 331);
            this.Controls.Add(this.fromLab);
            this.Controls.Add(this.toLab);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.DownloadOne);
            this.Controls.Add(this.DownloadNew);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.BackBu);
            this.Controls.Add(this.Download);
            this.Controls.Add(this.DeleteSong);
            this.Controls.Add(this.AddSong);
            this.Name = "InspectPlaylist";
            this.Text = " b  ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddSong;
        private System.Windows.Forms.Button DeleteSong;
        private System.Windows.Forms.Button Download;
        private System.Windows.Forms.Button BackBu;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader songTitle;
        private System.Windows.Forms.ColumnHeader downloaded;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button DownloadNew;
        private System.Windows.Forms.Button DownloadOne;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label fromLab;
        private System.Windows.Forms.Label toLab;
    }
}