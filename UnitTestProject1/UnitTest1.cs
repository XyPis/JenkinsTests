using System;
using Xunit;

namespace UnitTestProject1
{
 
    public class UnitTest1
    {           
        [Fact]
        public void TestMethod1()
        {
            ClassLibrary1.Class1 c1 = new ClassLibrary1.Class1();
            string s = "dragon luo";

            Assert.Equal(s.ToUpper(), c1.Upper(s));
        }
    }
}
