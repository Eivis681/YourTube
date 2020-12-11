using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;
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
            if (format == "1")
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
            else
            {
                var youtube = new YoutubeClient();
                var vid = await youtube.Videos.GetAsync(uri);
                

                // Get stream manifest
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(uri);

                // Select streams (1080p60 / highest bitrate audio)
                var audioStreamInfo = streamManifest.GetAudioOnly().WithHighestBitrate();
                var videoStreamInfo = streamManifest.GetVideoOnly().Where(s => s.Container == Container.Mp4).WithHighestVideoQuality();
                
                var streamInfos = new IStreamInfo[] { audioStreamInfo, videoStreamInfo };
                
                // Download and process them into one file
                string data = Directory.GetCurrentDirectory() + "\\";
                await youtube.Videos.DownloadAsync(streamInfos, new ConversionRequestBuilder("a").Build());
            }

        }
    }
}
