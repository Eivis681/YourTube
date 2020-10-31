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
            this.Download.Text = "Download";
            this.Download.UseVisualStyleBackColor = true;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // BackBu
            // 
            this.BackBu.Location = new System.Drawing.Point(421, 101);
            this.BackBu.Name = "BackBu";
            this.BackBu.Size = new System.Drawing.Size(99, 23);
            this.BackBu.TabIndex = 3;
            this.BackBu.Text = "<- Back";
            this.BackBu.UseVisualStyleBackColor = true;
            this.BackBu.Click += new System.EventHandler(this.BackBu_Click);
            // 
            // InspectPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 331);
            this.Controls.Add(this.BackBu);
            this.Controls.Add(this.Download);
            this.Controls.Add(this.DeleteSong);
            this.Controls.Add(this.AddSong);
            this.Name = "InspectPlaylist";
            this.Text = "InspectPlaylist";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddSong;
        private System.Windows.Forms.Button DeleteSong;
        private System.Windows.Forms.Button Download;
        private System.Windows.Forms.Button BackBu;
    }
}