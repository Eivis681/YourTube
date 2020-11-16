using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using YourTube.DataClass;

namespace YourTube.GetDataFromYoutubeClasses
{
    public class GetTitles
    {
        public List<string> getTitles(string uri)
        {
            try
            {
                string[] playlistId = uri.Split('=');
                UserGetSet.input();
                string url = "https://www.googleapis.com/youtube/v3/playlistItems?part=snippet&maxResults=50&playlistId=" + playlistId[1] + "&key="+UserGetSet.apiKey+"";
                WebClient wc = new WebClient();
                //Calls google ur to get JSON file with an address
                string urlData = wc.DownloadString(url);
                List<string> titleList = new List<string>();
                string[] data = urlData.Split('"');
                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i].Contains("title"))
                    {
                        titleList.Add(data[i + 2]);
                    }
                }
                for (int i =0; i<data.Length;i++)
                {
                    if(data[i].Contains("nextPageToken"))
                    {
                        string nextPage = data[i + 2];
                        string[] dataArray = nextPage.Split('"');
                        string nextPageToken = dataArray[0];
                        GetTileFromNextPage getTileFromNextPage = new GetTileFromNextPage();
                        titleList = getTileFromNextPage.getData(nextPageToken, titleList, uri);
                    }
                }
                return titleList;
            }
            catch(Exception e)
            {
                List<string> error = new List<string>();
                error.Add("error");
                return error;
            }
        }
    }
}
