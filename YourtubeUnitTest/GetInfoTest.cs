using NUnit.Framework;
using System.Collections.Generic;
using YourTube.DataBaseClasses;

namespace YourtubeUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void checkUserCredentials_badData()
        {
            GetInfo getInfo = new GetInfo();
            Assert.AreEqual(0, getInfo.checkUserCredentials("aasd", "assad"));
        }
        [Test]
        public void checkUserCredentials_goodData()
        {
            GetInfo getInfo = new GetInfo();
            Assert.AreEqual(1, getInfo.checkUserCredentials("test", "test"));
        }

        [Test]
        public void getUserUsername_fromDatabase()
        {
            GetInfo getInfo = new GetInfo();
            List<string> list = getInfo.getUserUsername();
            CollectionAssert.AreEqual(list, getInfo.getUserUsername());
        }

        [Test]
        public void getPlaylistCount_goodData()
        {
            GetInfo getInfo = new GetInfo();
            Assert.AreEqual("14", getInfo.getSongCount("asd"));
        }

        [Test]
        public void getPlaylistCounts_goodData()
        {
            GetInfo getInfo = new GetInfo();
            Assert.AreEqual("21", getInfo.getSongCount("test"));
        }

        [Test]
        public void getAllVideoId_goodData()
        {
            GetInfo getInfo = new GetInfo();
            List<string> list = getInfo.getAllVideoId("asd");
            CollectionAssert.AreEqual(list, getInfo.getAllVideoId("asd"));
        }
    }
}