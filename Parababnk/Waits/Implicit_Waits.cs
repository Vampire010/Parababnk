using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Parababnk.Browsersetup;
using Parababnk.Reports;

namespace Parababnk.Waits
{
    class Implicit_Waits
    {

    
       
     
        public   void main( )
        {
            IWebDriver driver;

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://parabank.parasoft.com");

            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(time_in_seconds);
          //  driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5000);

            IWebElement Username = Service.driver.FindElement(By.XPath("//*[@id='loginPanel']/form/div[1]/input"));

            IWebElement Password = Service.driver.FindElement(By.XPath("//*[@id='loginPanel']/form/div[2]/input"));

            IWebElement Login_Button = Service.driver.FindElement(By.XPath("//*[@id='loginPanel']/form/div[3]/input"));

            Username.SendKeys("AL202107");

    

            Password.SendKeys("Devil@1234");
            Login_Button.Click();


        }
    }
}
