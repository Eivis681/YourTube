using MediaToolkit;
using MediaToolkit.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using VideoLibrary;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace YourTube
{
    public delegate void ProgressBarSong(int data);
    public class SongDownload
    {
        public readonly ProgressBarSong progressBar1;
        public SongDownload(ProgressBarSong progressBar)
        {
            progressBar1 = progressBar;
        }
        public async void DownloadSong(string uri, string directory)
        {
            try
            {
                YourTube yourTube = new YourTube();
                var youtube = new YoutubeClient();
                var vid = await youtube.Videos.GetAsync(uri);
                if (File.Exists(directory + "\\" + vid.Title + ".mp3"))
                {
                    yourTube.YouHaveSong();
                }
                else
                {
                    var streamManifest = await youtube.Videos.Streams.GetManifestAsync(vid.Id);
                    var streamInfo = streamManifest.GetAudioOnly().WithHighestBitrate();
                    if (streamInfo != null)
                    {
                        await youtube.Videos.Streams.GetAsync(streamInfo);
                        await youtube.Videos.Streams.DownloadAsync(streamInfo, vid.Title + ".mp3");
                    }
                    string data = Directory.GetCurrentDirectory() + "\\";
                    File.Move(data + vid.Title + ".mp3", directory + "\\" + vid.Title + ".mp3");
                    int index = 1;
                    progressBar1.Invoke((int)index);
                    yourTube.DownloadEn();
                }
            }
            catch (Exception e)
            {
                DownloadSong(uri, directory);
            }
        }
    }
}
