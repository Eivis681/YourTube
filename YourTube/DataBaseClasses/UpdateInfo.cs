using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourTube.DataClass;

namespace YourTube.DataBaseClasses
{
    public class UpdateInfo
    {
        SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=YourTubeDB.db; Version = 3; New = True; Compress = True; ");
        public void renamePlaylist(string playlistname, string newPlaylistName)
        {
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "Update Playlist Set Name = '" + newPlaylistName + "' Where Name = '" + playlistname + "'; ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "Update Titles Set PlaylistID = '" + newPlaylistName + "' Where PlaylistID = '" + playlistname + "'; ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_conn.Close();
        }

        public void updateStatus(string playlistName)
        {
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "Update Titles Set DownloadedVideo = 'Yes' Where PlaylistID = '" + playlistName + "'; ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_conn.Close();
        }

        public void updateOneStatus (string songName)
        {
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            UserGetSet.input();
            sqlite_cmd.CommandText = "Update Titles Set DownloadedVideo = 'Yes' Where VideoTitle = '" + songName + "' AND PlaylistID = '"+UserGetSet.selectedPlaylis+"'; ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_conn.Close();
        }
    }
}
