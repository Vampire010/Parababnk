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
 
        [Test]       
        public  void Register()
        {
            string Appurl = "https://parabank.parasoft.com";
            String[] Browsers = { "Chrome" };
           
            foreach (String drivers in Browsers)
            {             
                Service.StartBrowser(drivers, Appurl);

                
                RG_TC01_POS();
               
            }
        }
    }
}

