using Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Helpers_Test
{
    [TestClass]
    public class StringLibrayTest
    {
        [TestMethod]
        public void CutStringTest()
        {
            string strCut = "Hello World, This is a sentence";
            int intChar = 15;

            var expected = "Hello World,...";
            var actual = StringLibray.CutString(strCut, intChar);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CutStringUnicodeTest()
        {
            string strCut = "안녕하세요. 부경대학교입니다.";
            int intChar = 9;

            var expected = "안녕하세요....";
            var actual = StringLibray.CutString(strCut, intChar);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void AddTest()
        {
            var expected = 10;
            var actual = (5 + 5);
            Assert.AreEqual(expected, actual);
        }
    }
}
