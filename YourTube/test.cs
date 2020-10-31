using System.IO;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace YourTube
{
    public class test
    {
        public async void DownloadSong(string uri, string directory)
        {
            //try
            //{
            //var youtube = YouTube.Default;
            var youtube = new YoutubeClient();
            var vid = await youtube.Videos.GetAsync(uri);
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(vid.Id);
            var streamInfo = streamManifest.GetAudioOnly().WithHighestBitrate();
            if (streamInfo!= null)
            {
                await youtube.Videos.Streams.GetAsync(streamInfo);
                await youtube.Videos.Streams.DownloadAsync(streamInfo,vid.Title+".mp3");
            }
            string data = Directory.GetCurrentDirectory() + "\\";
            File.Move(data + vid.Title + ".mp3", directory + "\\" + vid.Title + ".mp3");
            //var vid = await youtube.GetVideoAsync(uri);

            //File.WriteAllBytes(source + vid.Title, youtube.Videos.Streams.GetAsync(streamInfo));
            //var inputFile = new MediaFile { Filename = source + vid.FullName };
            //string filename = vid.FullName;
            //int filesTrim = vid.FullName.LastIndexOf(".");
            //if (filesTrim >= 0)
            //    filename = filename.Substring(0, filesTrim);
            //var outputFile = new MediaFile { Filename = $"{filename}.mp3" };
            //using (var engine = new Engine())
            //{
            //    engine.GetMetadata(inputFile);
            //    engine.Convert(inputFile, outputFile);
            //}
            //File.Delete(source + vid.FullName);
            //}
            //catch (Exception e)
            //{
            //    DownloadSong(uri, directory);
            //}
        }
    }
}
