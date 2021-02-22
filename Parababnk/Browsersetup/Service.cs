﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;
namespace Parababnk.Browsersetup
{
   public class Service
    {
        public static IWebDriver driver { get; set; }
        public static void StartBrowser(string BrowserType,string url)
        {
            if (BrowserType.Equals("Chrome"))
            {
                Service.driver = new ChromeDriver();
                driver.Navigate().GoToUrl(url);
            }

            else if (BrowserType.Equals("Firefox"))
            {
                Service.driver = new FirefoxDriver();
                driver.Navigate().GoToUrl(url);
            }
        }
        public static void CloseDriver()
        {
            //// Service.driver.Close();        
        }
    }
}
