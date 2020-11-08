using System.Collections.Generic;
using System.Data.SQLite;
using YourTube.DataClass;
using YourTube.GetDataFromYoutubeClasses;

namespace YourTube.DataBaseClasses
{
    public class AddInfo
    {
        SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=YourTubeDB.db; Version = 3; New = True; Compress = True; ");
        public void addNewUser(string username, string password, string apiKey)
        {
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO User (Username, Password, ApiKey) VALUES('" + username + "' ,'" + password + "' ,'" + apiKey + "'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_conn.Close();
        }
        public void addSongs(string playlistName, string url, string yesNo)
        {
            LinksFromPlaylist linksFromPlaylist = new LinksFromPlaylist();
            GetTitles getTitles = new GetTitles();
            List<string> videoId = linksFromPlaylist.getLinks(url);
            List<string> videoTitle = getTitles.getTitles(url);
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            for (int i = 0; i < videoId.Count; i++)
            {
                sqlite_cmd.CommandText = "INSERT INTO Titles (PlaylistID, VideoTitle, VideoId, DownloadedVideo) VALUES('" + playlistName + "' ,'" + videoTitle[i] + "' ,'" + videoId[i] + "', '" + yesNo + "'); ";
                sqlite_cmd.ExecuteNonQuery();
            }
        }
        public void addSong(string url)
        {
            LinksFromPlaylist linksFromPlaylist = new LinksFromPlaylist();
            GetTitles getTitles = new GetTitles();
            List<string> videoId = linksFromPlaylist.getLinks(url);
            List<string> videoTitle = getTitles.getTitles(url);
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            UserGetSet.input();
            sqlite_cmd.CommandText = "INSERT INTO Titles (PlaylistID, VideoTitle, VideoId, DownloadedVideo) VALUES('" + UserGetSet.selectedPlaylis + "' ,'" + videoTitle[0] + "' ,'" + videoId[0] + "', 'No'); ";
            sqlite_cmd.ExecuteNonQuery();
        }

        public void addNewPlaylist(string playlistName, string url, string yesNo)
        {
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            UserGetSet.input();
            sqlite_cmd.CommandText = "INSERT INTO Playlist (UserId, Name, PlaylistUrl) VALUES('" + UserGetSet.username + "' ,'" + playlistName + "' ,'" + url + "'); ";
            sqlite_cmd.ExecuteNonQuery();
            AddInfo addInfo = new AddInfo();
            addInfo.addSongs(playlistName, url, yesNo);
            sqlite_conn.Close();
        }
    }
}
