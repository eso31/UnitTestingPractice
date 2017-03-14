using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingPractice;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Int64 x = Program.Hash("leepadg");

            Assert.AreEqual(x, 680131659347);
        }
    }
}
