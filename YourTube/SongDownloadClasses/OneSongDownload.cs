using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace YourTube.SongDownloadClasses
{
    public delegate void ProgressBar(int data);
    public class OneSongDownload
    {
        public readonly ProgressBar progressBar1;
        public OneSongDownload(ProgressBar progressBar)
        {
            progressBar1 = progressBar;
        }
        public async void DownloadSong(List<string> videoId, string directory)
        {
            int index=0;
            YourTube yourTube = new YourTube();
            var youtube = new YoutubeClient();
            foreach (string id in videoId)
            {
                string url = "https://www.youtube.com/watch?v=" + id;
                var vid = await youtube.Videos.GetAsync(url);
                if (File.Exists(directory + "\\" + vid.Title + ".mp3"))
                {
                    index++;
                }
                else
                {
                    index++;
                    var streamManifest = await youtube.Videos.Streams.GetManifestAsync(id);
                    var streamInfo = streamManifest.GetAudioOnly().WithHighestBitrate();
                    if (streamInfo != null)
                    {
                        await youtube.Videos.Streams.GetAsync(streamInfo);
                        await youtube.Videos.Streams.DownloadAsync(streamInfo, vid.Title + ".mp3");
                    }
                    string data = Directory.GetCurrentDirectory() + "\\";
                    //AudioConverter audioConverter = new AudioConverter();
                    //audioConverter.ConvertAudio(data + vid.Title);
                    File.Move(data + vid.Title + ".mp3", directory + "\\" + vid.Title + ".mp3");
                    progressBar1.Invoke((int)index);
                }
            }
        }
    }
}
