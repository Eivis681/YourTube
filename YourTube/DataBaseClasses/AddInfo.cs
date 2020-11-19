using System.Collections.Generic;
using System.Data.SQLite;
using YourTube.DataClass;
using YourTube.GetDataFromYoutubeClasses;
using YoutubeExplode;

namespace YourTube.DataBaseClasses
{
    public class AddInfo
    {
        SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=YourTubeDB.db; Version = 3; New = True; Compress = True; ");
        public void addNewUser(string username, string password, string apiKey)
        {
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            username = username.Replace(" ", string.Empty);
            password = password.Replace(" ", string.Empty);
            apiKey = apiKey.Replace(" ", string.Empty);
            sqlite_cmd.CommandText = "INSERT INTO User (Username, Password, ApiKey) VALUES('" + username + "' ,'" + password + "' ,'" + apiKey + "'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_conn.Close();
        }

        public async void addUpdatedSongs(List<string> videoId, string rrr)
        {
            sqlite_conn.Open();
            foreach (string id in videoId)
            {
                var youtube = new YoutubeClient();
                string url = "https://www.youtube.com/watch?v=" + id;
                var vid = await youtube.Videos.GetAsync(url);
                SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
                UserGetSet.input();
                sqlite_cmd.CommandText = "INSERT INTO Titles (PlaylistID, VideoTitle, VideoId, DownloadedVideo, VideoUrl) VALUES('" + UserGetSet.selectedPlaylis + "' ,'" + vid.Title.Replace("\"", "").Replace("'", "") + "' ,'" + id + "', 'No', '"+rrr+"'); ";
                sqlite_cmd.ExecuteNonQuery();
            }
            sqlite_conn.Close();
        }
        public void addSongs(string playlistName, string url, string yesNo)
        {
            LinksFromPlaylist linksFromPlaylist = new LinksFromPlaylist();
            GetTitles getTitles = new GetTitles();
            List<string> videoId = linksFromPlaylist.getLinks(url);
            List<string> videoTitle = getTitles.getTitles(url);
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            for (int i = 0; i < videoId.Count; i++)
            {
                videoTitle[i] = videoTitle[i].Replace("\"", "").Replace("'", "");
                sqlite_cmd.CommandText = "INSERT INTO Titles (PlaylistID, VideoTitle, VideoId, DownloadedVideo, VideoUrl) VALUES('" + playlistName + "' ,'" + videoTitle[i] + "' ,'" + videoId[i] + "', '" + yesNo + "', '"+url+"'); ";
                sqlite_cmd.ExecuteNonQuery();
            }
            sqlite_cmd.CommandText = "INSERT INTO PlaylistInfo (PlaylistName, PlaylistID) VALUES('" + playlistName + "','" + url + "')";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_conn.Close();
        }
        public async void addSong(string url)
        {
            var youtube = new YoutubeClient();
            var vid = await youtube.Videos.GetAsync(url);
            string[] videoId = vid.Url.Split('=');
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            UserGetSet.input();
            sqlite_cmd.CommandText = "INSERT INTO Titles (PlaylistID, VideoTitle, VideoId, DownloadedVideo) VALUES('" + UserGetSet.selectedPlaylis + "' ,'" + vid.Title.Replace("\"", "").Replace("'", "") + "' ,'" + videoId[1] + "', 'No'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_conn.Close();
        }

        public void addNewPlaylist(string playlistName, string url, string yesNo)
        {
            AddInfo addInfo = new AddInfo();
            addInfo.addSongs(playlistName, url, yesNo);
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            UserGetSet.input();
            sqlite_cmd.CommandText = "INSERT INTO Playlist (UserId, Name, PlaylistUrl) VALUES('" + UserGetSet.username + "' ,'" + playlistName + "' ,'" + url + "'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_conn.Close();
        }
    }
}
