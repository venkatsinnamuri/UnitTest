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
        [TestCategory("DevOps")]
        public void TestMethod1()
        {

            Console.WriteLine("First Unit test case1");

        }
        [TestMethod]
        [TestCategory("DevOps")]
        public void TestMethod2()
        {

            Console.WriteLine("Second Unit test case2");

        }
        [TestMethod]
        [TestCategory("DevOps")]
        public void TestMethod3()
        {

            Console.WriteLine("Third Unit test case3");

        }

        [TestMethod]
        [TestCategory("DevOps")]
        public void TestMethod4()
        {

            Console.WriteLine("Fourth test case4");

        }

        [TestMethod]
        [TestCategory("DevOps")]
        public void TestMethod5()
        {

            Console.WriteLine("Five test case5");

        }

        [TestMethod]
        [TestCategory("DevOps")]
        public void TestMethod6()
        {

            Console.WriteLine("Five test case6");

        }

        [TestMethod]
        [TestCategory("DevOps")]
        public void TestMethod7()
        {

            Console.WriteLine("Five test case7");

        }
        [TestMethod]
        [TestCategory("DevOps")]
        public void TestMethod8()
        {

            Console.WriteLine("Five test case8");

        }
        public void AfterTest()
            {
                //
            }
        }
    }

