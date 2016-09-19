using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ClassLibrary1.Class1 c1 = new ClassLibrary1.Class1();
            string s = "dragon luo";

            Assert.AreEqual(s.ToUpper(), c1.Upper(s));
        }
    }
}
