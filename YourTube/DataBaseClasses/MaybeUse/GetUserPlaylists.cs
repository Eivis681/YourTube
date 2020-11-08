using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourTube.DataClass;

namespace YourTube.DataBaseClasses
{
    public class GetUserPlaylists
    {
        public List<string> getPlaylists()
        {
            SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=YourTubeDB.db; Version = 3; New = True; Compress = True; ");
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            UserGetSet.input();
            sqlite_cmd.CommandText = "Select Name, PlaylistUrl from Playlist WHERE UserId = '"+ UserGetSet.username+"'";
            SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();
            List<string> playlistData = new List<string>();
            while (sqlite_datareader.Read())
            {
                string name = sqlite_datareader.GetString(0);
                string url = sqlite_datareader.GetString(1);
                playlistData.Add(name);
                playlistData.Add(url);
            }
            sqlite_conn.Close();
            return playlistData;
        }
    }
}
