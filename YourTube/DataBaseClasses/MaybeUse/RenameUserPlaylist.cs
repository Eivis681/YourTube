using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourTube.DataBaseClasses
{
    public class RenameUserPlaylist
    {
        public void renamePlaylist (string playlistname, string newPlaylistName)
        {
            SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=YourTubeDB.db; Version = 3; New = True; Compress = True; ");
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "Update Playlist Set Name = '"+newPlaylistName+"' Where Name = '"+playlistname+"'; ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "Update Titles Set PlaylistID = '" + newPlaylistName + "' Where PlaylistID = '" + playlistname + "'; ";
            sqlite_cmd.ExecuteNonQuery();
        }
    }
}
