using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourTube.DataBaseClasses
{
    public class SongDownloadUpate
    {
        public void updateStatus(string playlistName)
        {
            SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=YourTubeDB.db; Version = 3; New = True; Compress = True; ");
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "Update Titles Set DownloadedVideo = 'Yes' Where PlaylistID = '" + playlistName + "'; ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_conn.Close();
        }
    }
}
