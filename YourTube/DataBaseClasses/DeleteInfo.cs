using System.Data.SQLite;
using YourTube.DataClass;

namespace YourTube.DataBaseClasses
{
    public class DeleteInfo
    {
        SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=YourTubeDB.db; Version = 3; New = True; Compress = True; ");
        public void DeleteSong(string songName)
        {
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            UserGetSet.input();
            sqlite_cmd.CommandText = "DELETE FROM Titles WHERE VideoTitle = '"+songName+"' AND PlaylistID = '"+UserGetSet.selectedPlaylis+"'";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_conn.Close();
        }

        public void DeletePlaylist(string playlistName)
        {
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "DELETE FROM Playlist WHERE Name ='" + playlistName + "'";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "DELETE FROM Titles WHERE PlaylistID ='" + playlistName + "'";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "DELETE FROM PlaylistInfo WHERE PlaylistName ='" + playlistName + "'";
            sqlite_cmd.ExecuteNonQuery();
        }
    }
}
