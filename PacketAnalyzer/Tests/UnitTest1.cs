using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string hexString = "00 00 00 19"; // 25
            byte[] ba = Penis.ConvertHexStringToByteArray(hexString);
            int result = BitConverter.ToInt32(ba, 0);
            Assert.AreEqual(25, result);

            hexString = "00 00 04 BE"; // 1214
            ba = Penis.ConvertHexStringToByteArray(hexString);
            result = BitConverter.ToInt32(ba, 0);//Penis.IntFromByteArray(ref ba, 0, 4);
            Assert.AreEqual(1214, result);
        }
    }
}
