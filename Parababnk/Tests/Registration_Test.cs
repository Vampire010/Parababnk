using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Parababnk.Browsersetup;
using Parababnk.Pages;
using System;
using System.Collections.Generic;
using System.Text;


namespace Parababnk.Tests
{
    [TestFixture]
   public  class Registration_Test : Registration_Page
    {


      //  [SetUp]
        public void Register_User()
        {
            string Appurl = "https://parabank.parasoft.com";
            String[] Browsers = { "Chrome" };

            foreach (String drivers in Browsers)
            {
                Service.StartBrowser(drivers, Appurl);

                RG_TC01_POS();
                lOGout();
            }
        }

     //   [Test]       
        public  void Register()
        {
           Login l = new Login();
            l.User_Login();
        }

      //  [TearDown]
        public  void End_mETHOD()
        {
            Login l = new Login();
            l.Account_Overview();
        }



    }
}

