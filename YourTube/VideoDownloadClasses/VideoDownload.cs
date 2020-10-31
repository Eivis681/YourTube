using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace YourTube
{
    public delegate void ProgressBarVideo(int data);
    public class VideoDownload
    {
        public readonly ProgressBarVideo progressBar1;
        public VideoDownload(ProgressBarVideo progressBar)
        {
            progressBar1 = progressBar;
        }
        public async void DownloadVideo(string uri, string directory, string format)
        {
           
            var youtube = new YoutubeClient();
            var vid = await youtube.Videos.GetAsync(uri);
            YourTube yourTube = new YourTube();
            if (File.Exists(directory + "\\" + vid.Title + ".mp4"))
            {
                yourTube.YourHaveVideo();
            }
            else
            {
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(vid.Id);
                var streamInfo = streamManifest.GetMuxed().WithHighestVideoQuality();
                if (streamInfo != null)
                {
                    await youtube.Videos.Streams.GetAsync(streamInfo);
                    await youtube.Videos.Streams.DownloadAsync(streamInfo, vid.Title + ".mp4");
                }
                string data = Directory.GetCurrentDirectory() + "\\";
                File.Move(data + vid.Title + ".mp4", directory + "\\" + vid.Title + ".mp4");
                int index = 1;
                progressBar1.Invoke((int)index);
                yourTube.DownloadEn();
            }
        }
    }
}
