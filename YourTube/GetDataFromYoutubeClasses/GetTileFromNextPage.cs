using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace YourTube.GetDataFromYoutubeClasses
{
    public class GetTileFromNextPage
    {
        public List<string> getData(string pageToken, List<string> videoId, string urll)
        {
            string[] playlistId = urll.Split('=');
            string url = "https://youtube.googleapis.com/youtube/v3/playlistItems?part=snippet&maxResults=50&pageToken=" + pageToken + "&playlistId=" + playlistId[1] + "&key=AIzaSyDmQnQcWyJfzAobgMogygmgwtNbgTvkUaY";
            WebClient wc = new WebClient();
            //Calls google ur to get JSON file with an address
            string urlData = wc.DownloadString(url);
            string[] data = urlData.Split('"');
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Contains("title"))
                {
                    videoId.Add(data[i + 2]);
                }
            }
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Contains("nextPageToken"))
                {
                    string nextPage = data[i + 2];
                    string[] dataArray = nextPage.Split('"');
                    string nextPageToken = dataArray[0];
                    videoId = getData(nextPageToken, videoId, urll);
                }
            }
            return videoId;
        }
    }
}
