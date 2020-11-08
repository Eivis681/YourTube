using System;
using System.Collections.Generic;
using System.IO;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace YourTube
{
    public delegate void ProgressBar(int data);
    public class SongPlaylistDownload
    {
        public readonly ProgressBar progressBar1;
        public SongPlaylistDownload(ProgressBar progressBar)
        {
            progressBar1 = progressBar;
        }
        public async void DownloadSongPlaylist(List<string> mas, string directory, string playlistID, int index)
        {
            YourTube yourTube = new YourTube();
            for (int i = index; i < mas.Count; i++)
            {
                //try
                //{
                    string url = "https://www.youtube.com/watch?v=" + mas[i] + "&list=" + playlistID + "&index=" + index + 1;
                    index++;
                    var youtube = new YoutubeClient();
                    var vid = await youtube.Videos.GetAsync(url);
                    if (File.Exists(directory + "\\" + vid.Title + ".mp3"))
                    {
                        progressBar1.Invoke((int)index);
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
                        progressBar1.Invoke((int)index);
                    }
                    if (index == mas.Count)
                    {
                        yourTube.DownloadEn();
                    }
                //}
                //catch (Exception e)
                //{
                //    if (index < mas.Count)
                //    {
                //        DownloadSongPlaylist(mas, directory, playlistID, index - 1);
                //    }
                //}
            }
        }
    }
}
