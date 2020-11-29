using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RussinaGame_HarmanGarcha;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        public void Form1Test()
        {
            Form1 obj = new Form1();

            obj.generateNo();
            Assert.IsTrue(true);


        }
    }
}
