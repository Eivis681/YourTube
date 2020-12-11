using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace YourTube.GetDataFromYoutubeClasses
{
    public class TestApiKey
    {
        public string testApiKey(string apiKey)
        {
            try
            {
                string url = "https://www.googleapis.com/youtube/v3/playlistItems?part=contentDetails&maxResults=50&playlistId=PLYQ21GguN2ssJfHlwxZxzepHaiu3t798Y&key="+apiKey+"";
                WebClient wc = new WebClient();
                string urlData = wc.DownloadString(url);
                return "good";
            }catch(Exception e)
            {
                return "Bad";
            }
        }
    }
}
