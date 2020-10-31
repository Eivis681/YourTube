using System;
using System.Collections.Generic;
using System.IO;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace YourTube.VideoDownloadClasses
{
    public delegate void ProgressBarVid(int data);
    public class VideoPlaylistDownload
    {
        public readonly ProgressBarVid progressBar1;
        public VideoPlaylistDownload(ProgressBarVid progressBar)
        {
            progressBar1 = progressBar;
        }
        public async void downloadVideoPlaylist(List<string> mas, string directory, int index, string playlistID)
        {
            for (int i = index; i < mas.Count; i++)
            {
                try
                {
                    string url = "https://www.youtube.com/watch?v=" + mas[i] + "&list=" + playlistID + "&index=" + index + 1;
                    index++;
                    var youtube = new YoutubeClient();
                    var vid = await youtube.Videos.GetAsync(url);
                    YourTube yourTube = new YourTube();
                    if (File.Exists(directory + "\\" + vid.Title + ".mp3"))
                    {
                        progressBar1.Invoke((int)index);
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
                        progressBar1.Invoke((int)index);
                    }
                    if (index == mas.Count)
                    {
                        yourTube.DownloadEn();
                    }
                }
                catch (Exception e)
                {
                    downloadVideoPlaylist(mas, directory, index - 1, playlistID);
                }
            }
        }
    }
}
