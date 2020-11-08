using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xabe.FFmpeg;
using YourTube.Properties;

namespace YourTube.SongDownloadClasses
{
    public class AudioConverter
    {
        //public CSAudioConverter.AudioConverter audioConverter1 = new CSAudioConverter.AudioConverter();
        public void ConvertAudio(string path)
        {
            //string FILE = "the-file-you-want-to-process.webm";
            //FFmpeg - i "${FILE}" - vn - ab 128k - ar 44100 - y "${FILE%.webm}.mp3";
            //FFmpeg 
            //string inputVideoPath = Path.Combine(path);
            //string outputPathMp4 = Path.Combine(path+ ".mp3");

            //IMediaInfo info = await FFmpeg.GetMediaInfo(inputVideoPath);

            //IStream audioStream = info.AudioStreams.FirstOrDefault()
            //    ?.SetChannels(2);

            //return FFmpeg.Conversions.New()
            //    .AddStream(videoStream, audioStream)
            //    .SetOutput(outputPathMp4);

            //string output = path + ".mp3";
            //FFmpeg.Conversions.FromSnippet.ExtractAudio(path, output).Start();

            ////FFmpeg.Conversions.FromSnippet.ExtractAudio(path, path + ".mp3");
            //string output = path+ ".mp3";
            //var conversion = FFmpeg.Conversions.FromSnippet.ExtractAudio(path, output);
            //conversion.Start();

            //data.UserName = "Free@Usage";
            //data.UserKey = "d1200cee3a2f9f7aeddb37f9ea398592";
            //data.Format  = CSAudioConverter.Format.MP3;
            //Options.Core.SourceFile sourceFile = new Options.Core.SourceFile(path);
            //data.sourceFile;
            //data.Convert();
            //https://www.codeproject.com/Articles/8544/Aumplib-C-Namespace-And-Classes-For-Audio-Conversi
            CSAudioConverter.AudioConverter audioConverter1 = new CSAudioConverter.AudioConverter();
            audioConverter1.UserName = "Free@Usage";
            audioConverter1.UserKey = "d1200cee3a2f9f7aeddb37f9ea398592";
            audioConverter1.Format = CSAudioConverter.Format.MP3;
            Options.Core.SourceFile sourceFile =  new Options.Core.SourceFile(path);
            audioConverter1.Convert();
        }
    }
}
