using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Parababnk.Reports;
using System;
using System.Threading;

namespace Parababnk
{
   // [TestFixture]
    public class Test2s
    {
        


        ExtentReports rep = ExtentManager.getInstance();
        ExtentTest test;


      //  [Test]
        public void Test1()
        {

            rep.CreateTest("Login_Test");

            test.Log(Status.Info,"Strting the Browser");
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://parabank.parasoft.com";
           // driver.Navigate().GoToUrl("https://www.google.com/");
            string Page_title = driver.Title;
            Console.WriteLine(Page_title);

       /*     string page_source = driver.PageSource;
            Console.WriteLine(page_source);


            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[2]/div[1]/div[1]/div/div[2]/input")).SendKeys("Hello");
            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[2]/div[1]/div[3]/center/input[1]")).Click();

            driver.Navigate().Refresh();

            Thread.Sleep(5000);


           driver.Navigate().Back();

            Thread.Sleep(5000);

           driver.Navigate().Forward(); */

        }


    }
}