using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourTube.DataClass;

namespace YourTube.DataBaseClasses
{
    public class GetPlaylistVideos
    {
        public List<string> getData()
        {
            SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=YourTubeDB.db; Version = 3; New = True; Compress = True; ");
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            UserGetSet.input();
            sqlite_cmd.CommandText = "Select VideoTitle, DownloadedVideo from Titles WHERE PlaylistID = '" + UserGetSet.selectedPlaylis + "'";
            SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();
            List<string> playlistData = new List<string>();
            while (sqlite_datareader.Read())
            {
                string title = sqlite_datareader.GetString(0);
                string downloaded = sqlite_datareader.GetString(1);
                playlistData.Add(title);
                playlistData.Add(downloaded);
            }
            sqlite_conn.Close();
            return playlistData;
        }
    }
}
