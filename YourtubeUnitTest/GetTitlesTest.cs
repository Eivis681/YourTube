using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using YourTube.DataClass;
using YourTube.GetDataFromYoutubeClasses;

namespace YourtubeUnitTest
{
    public class GetTitlesTest
    {
        [Test]
        public void videoTitlesFromYoutubeDataApi_goodData()
        {
            GetTitles getTitles = new GetTitles();
            UserGetSet.input();
            UserGetSet.apiKey = "AIzaSyCBYx5nDeHanit6rpvzhZLSDy52diu7ecI";

            List<string> list = getTitles.getTitles("https://www.youtube.com/playlist?list=PLYQ21GguN2ssJfHlwxZxzepHaiu3t798Y");
            CollectionAssert.AreEqual(list, getTitles.getTitles("https://www.youtube.com/playlist?list=PLYQ21GguN2ssJfHlwxZxzepHaiu3t798Y"));
        }
    }
}
