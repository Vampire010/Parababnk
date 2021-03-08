using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Parababnk.Reports;
using System;
using System.Collections.Generic;
using System.Text;
namespace Parababnk.Browsersetup
{
   public class Service
    {
        static ExtentReports rep = ExtentManager.getInstance();
        static ExtentTest test;

        public static IWebDriver driver { get; set; }
        public static void StartBrowser(string BrowserType,string url)
        {

            test = rep.CreateTest("Browser_Test");

            if (BrowserType.Equals("Chrome"))
            {
                
                test.Log(Status.Info, "Strting the Chrome Browser");

                Service.driver = new ChromeDriver();
                
                test.Log(Status.Pass, "Navigating to URL " + url);
                
                
                driver.Navigate().GoToUrl(url);
            }

            else if (BrowserType.Equals("Firefox"))
            {
               
                Service.driver = new FirefoxDriver();
                driver.Navigate().GoToUrl(url);
            }


        }
     
    }
}
