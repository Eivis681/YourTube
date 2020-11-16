using System;
using System.Collections.Generic;
using System.Net;
using YourTube.DataClass;
using YourTube.GetDataFromYoutubeClasses;

namespace YourTube
{
    public class LinksFromPlaylist
    {
        public List<string> getLinks(string uri)
        {
            try
            {
                string[] playlistId = uri.Split('=');
                UserGetSet.input();
                string url = "https://www.googleapis.com/youtube/v3/playlistItems?part=contentDetails&maxResults=50&playlistId=" + playlistId[1] + "&key="+UserGetSet.apiKey+"";
                WebClient wc = new WebClient();
                //Calls google ur to get JSON file with an address
                string urlData = wc.DownloadString(url);
                List<string> videoIdList = new List<string>();
                string[] data = urlData.Split('"');
                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i].Contains("videoId"))
                    {
                        videoIdList.Add(data[i + 2]);
                    }
                }
                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i].Contains("nextPageToken"))
                    {
                        string nextPage = data[i + 2];
                        string[] dataArray = nextPage.Split('"');
                        string nextPageToken = dataArray[0];
                        DataFromNextPage dataFromNextPage = new DataFromNextPage();
                        videoIdList = dataFromNextPage.getData(nextPageToken, videoIdList, uri);
                    }
                }
                return videoIdList;
            }
            catch (Exception e)
            {
                List<string> error = new List<string>();
                error.Add("error");
                return error;
            }
        }
    }
}
