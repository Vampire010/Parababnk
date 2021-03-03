using AventStack.ExtentReports;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parababnk.Reports
{
    class SeleniumExtentReport
    {
        ExtentReports rep = ExtentManager.getInstance();


        //[SetUp]
        public void setups()
        {
            Console.WriteLine("In Setup Method");
            Assert.Ignore("Skipping the TestCase");

        }
      //  [Test]
        public void testRecive()
        {
            Console.WriteLine("In Setup Method");
            Assert.Ignore("Test Recive");

        }



    }
}
