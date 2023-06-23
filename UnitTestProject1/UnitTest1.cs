using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public void BeforeTest()
        {
            //
        }

        [TestMethod]
        [TestCategory ("DevOps") ]
        public void TestMethod1()
        {
              Console.WriteLine("First Unit test case");
            //changes
         
        }
        [TestMethod]
        [TestCategory("DevOps")]
        public void TestMethod2()
        {
      
            Console.WriteLine("Second Unit test case");
            //changes
        }
        public void AfterTest()
        {
            //
        }
    }
}
