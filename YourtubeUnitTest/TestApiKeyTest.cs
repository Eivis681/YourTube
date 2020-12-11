using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using YourTube.GetDataFromYoutubeClasses;

namespace YourtubeUnitTest
{
    public class TestApiKeyTest
    {
        

        [Test]
        public void ApiKeyTest_BadApiKey()
        {
            TestApiKey testApiKey = new TestApiKey();
            Assert.AreEqual("good", testApiKey.testApiKey("AIzaSyCBYx5nDeHanit6rpvzhZLSDy52diu7ecI"));
        }

        [Test]
        public void ApiKeyTest_GoodKey()
        {
            TestApiKey testApiKey = new TestApiKey();
            Assert.AreEqual("Bad", testApiKey.testApiKey("6432adasd84"));
        }
    }
}
