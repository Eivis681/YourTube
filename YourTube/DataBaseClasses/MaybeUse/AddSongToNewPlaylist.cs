using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourTube.DataClass;
using YourTube.GetDataFromYoutubeClasses;

namespace YourTube.DataBaseClasses
{
    public class AddSongToNewPlaylist
    {
        public void addSongs(string playlistName,string url,string yesNo)
        {
            LinksFromPlaylist linksFromPlaylist = new LinksFromPlaylist();
            GetTitles getTitles = new GetTitles();
            List<string> videoId = linksFromPlaylist.getLinks(url);
            List<string> videoTitle = getTitles.getTitles(url);
            SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=YourTubeDB.db; Version = 3; New = True; Compress = True; ");
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            for (int i = 0; i < videoId.Count; i++)
            {
                sqlite_cmd.CommandText = "INSERT INTO Titles (PlaylistID, VideoTitle, VideoId, DownloadedVideo) VALUES('" + playlistName + "' ,'" + videoTitle[i] + "' ,'" + videoId[i] + "', '"+yesNo+"'); ";
                sqlite_cmd.ExecuteNonQuery();
            }
        }
    }
}
