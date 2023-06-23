﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            
            Console.WriteLine("First Unit test case");

        }
        [TestMethod]
        [TestCategory("DevOps")]
        public void TestMethod2()
        {

            Console.WriteLine("Second Unit test case");

        }
        [TestMethod]
        [TestCategory("DevOps")]
        public void TestMethod3()
        {

            Console.WriteLine("Third Unit test case");

        }

        public void AfterTest()
        {
            //
        }
    }
}
