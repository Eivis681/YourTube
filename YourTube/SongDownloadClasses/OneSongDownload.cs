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
    public class OneSongDownload
    {
        public async void DownloadSong(string uri, string directory)
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
                //AudioConverter audioConverter = new AudioConverter();
                //audioConverter.ConvertAudio(data + vid.Title);
                File.Move(data + vid.Title + ".mp3", directory + "\\" + vid.Title + ".mp3");
            }
        }
    }
}
