using System.Collections.Generic;
using System.Data.SQLite;
using YourTube.DataClass;

namespace YourTube.DataBaseClasses
{
    public class GetInfo
    {
        SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=YourTubeDB.db; Version = 3; New = True; Compress = True; ");
        public int checkUserCredentials(string username, string password)
        {
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "Select Username, Password, ApiKey from User where Username ='" + username + "'";
            SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();
            string myreader = null;
            string myreaderr = null;
            string myreaderrr = null;
            while (sqlite_datareader.Read())
            {
                myreader = sqlite_datareader.GetString(0);
                myreaderr = sqlite_datareader.GetString(1);
                myreaderrr = sqlite_datareader.GetString(2);
            }
            if (myreader == username)
            {
                if (myreaderr == password)
                {
                    sqlite_conn.Close();
                    UserGetSet.input();
                    UserGetSet.username = myreader;
                    UserGetSet.password = myreaderr;
                    UserGetSet.apiKey = myreaderrr;
                    return 1;
                }
            }
            else
            {
                sqlite_conn.Close();
                return 0;
            }
            sqlite_conn.Close();
            return 6969;
        }

        public List<string> getData()
        {
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

        public List<string> getPlaylists()
        {
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            UserGetSet.input();
            sqlite_cmd.CommandText = "Select Name, PlaylistUrl from Playlist WHERE UserId = '" + UserGetSet.username + "'";
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
        public List<string> getUserUsername()
        {
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "Select Username from User";
            SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();
            List<string> usernames = new List<string>();
            while (sqlite_datareader.Read())
            {
                string myreader = sqlite_datareader.GetString(0);
                usernames.Add(myreader);
            }
            sqlite_conn.Close();
            return usernames;
        }

        public string oneVideoId(string videoName)
        {
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            UserGetSet.input();
            sqlite_cmd.CommandText = "Select VideoId from Titles Where VideoTitle = '"+videoName+"' AND PlaylistID = '"+UserGetSet.selectedPlaylis+"'";
            SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();
            string myreader=null;
            while (sqlite_datareader.Read())
            {
                myreader = sqlite_datareader.GetString(0);
            }
            sqlite_conn.Close();
            return myreader;
        }

        public List<string> getNewSongVideoId()
        {
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            UserGetSet.input();
            sqlite_cmd.CommandText = "Select VideoId from Titles Where DownloadedVideo='No' And PlaylistID = '"+UserGetSet.selectedPlaylis+"'";
            SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();
            List<string> videoId = new List<string>();
            while (sqlite_datareader.Read())
            {
                string myreader = sqlite_datareader.GetString(0);
                videoId.Add(myreader);
            }
            sqlite_conn.Close();
            return videoId;
        }

    }
}
