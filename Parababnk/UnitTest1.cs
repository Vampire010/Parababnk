using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Parababnk
{
   // [TestFixture]
    public class Test2s
    {
        IWebDriver driver;
     

       [Test]
        public void Test1()
        {
            driver = new ChromeDriver();
            //driver.Url = "https://parabank.parasoft.com";
            driver.Navigate().GoToUrl("https://www.google.com/");
            string Page_title = driver.Title;
            Console.WriteLine(Page_title);

            string page_source = driver.PageSource;
            Console.WriteLine(page_source);


            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[2]/div[1]/div[1]/div/div[2]/input")).SendKeys("Hello");
            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[2]/div[1]/div[3]/center/input[1]")).Click();

            driver.Navigate().Refresh();

            Thread.Sleep(5000);


           driver.Navigate().Back();

            Thread.Sleep(5000);

           driver.Navigate().Forward();
        }


    }
}