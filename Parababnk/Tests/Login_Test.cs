using AventStack.ExtentReports;
using NUnit.Framework;
using Parababnk.Browsersetup;
using Parababnk.Pages;
using Parababnk.Reports;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parababnk.Tests
{

    [TestFixture]
    class Login_Test:Login
    {
        string Appurl = "https://parabank.parasoft.com";
       
    // [Test]
     //[Parallelizable]
        public void Login_TC01()
        {
            String[] Browsers = { "Chrome" };
            foreach (String drivers in Browsers)
            {
                Service.StartBrowser(drivers, Appurl);

                User_Login();             
            }
        }

     //[Test]
     //[Parallelizable]
        public void Login_TC02()
        {
            var drivers = "Firefox";
            
                Service.StartBrowser(drivers, Appurl);
                User_Login();
            
        }
    }
}
