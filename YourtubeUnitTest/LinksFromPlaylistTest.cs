using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using YourTube;
using YourTube.DataClass;

namespace YourtubeUnitTest
{
   public class LinksFromPlaylistTest
    {
        [Test]
        public void getAllVideoId_goodData()
        {
            LinksFromPlaylist linksFromPlaylist = new LinksFromPlaylist();
            UserGetSet.input();
            UserGetSet.apiKey = "AIzaSyCBYx5nDeHanit6rpvzhZLSDy52diu7ecI";

            List<string> list = linksFromPlaylist.getLinks("https://www.youtube.com/playlist?list=PLYQ21GguN2ssJfHlwxZxzepHaiu3t798Y");
            CollectionAssert.AreEqual(list, linksFromPlaylist.getLinks("https://www.youtube.com/playlist?list=PLYQ21GguN2ssJfHlwxZxzepHaiu3t798Y"));
        }
    }
}
