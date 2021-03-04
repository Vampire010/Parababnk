using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parababnk.Examples
{
    class GetAttributesex
    {
        IWebDriver driver;

      // [Test]
        public void GetAttr()
        {

            driver = new ChromeDriver();


            driver.Navigate().GoToUrl("https://parabank.parasoft.com/");

            IWebElement Atribute = driver.FindElement(By.XPath("//*[@id='loginPanel']/form/div[1]/input"));

            string atb = Atribute.GetAttribute("name");

            Console.WriteLine( atb);

        }

    }
}
