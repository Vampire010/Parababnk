using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parababnk.Examples
{
    class GetCSSValue
    {


        IWebDriver driver;

        //  [Test]
        public void Test12()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://parabank.parasoft.com/");

            IWebElement Username = driver.FindElement(By.XPath("//*[@id='loginPanel']/form/div[1]/input"));

            IWebElement Password = driver.FindElement(By.XPath("//*[@id='loginPanel']/form/div[1]/input"));


    
        }
    }
}
