using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourTube.DataClass;

namespace YourTube.DataBaseClasses
{
    public class SaveNewPlaylist
    {
        public void addNewPlaylist(string playlistName, string url,string yesNo)
        {
            SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=YourTubeDB.db; Version = 3; New = True; Compress = True; ");
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            UserGetSet.input();
            sqlite_cmd.CommandText = "INSERT INTO Playlist (UserId, Name, PlaylistUrl) VALUES('" +UserGetSet.username+ "' ,'" + playlistName + "' ,'" + url + "'); ";
            sqlite_cmd.ExecuteNonQuery();
            AddInfo addInfo = new AddInfo();
            addInfo.addSongs(playlistName,url,yesNo);
        }
    }
}
