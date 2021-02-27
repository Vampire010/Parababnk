using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parababnk.Examples
{
    class SUBMITBTN
    {
        IWebDriver driver;

        //[Test]
        public void Test1()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://parabank.parasoft.com");



            /*

            IWebElement Username = driver.FindElement(By.XPath("//*[@id='loginPanel']/form/div[1]/input"));
            IWebElement Password = driver.FindElement(By.XPath("//*[@id='loginPanel']/form/div[2]/input"));
            IWebElement Login_Button = driver.FindElement(By.XPath("//*[@id='loginPanel']/form/div[3]/input"));

            Username.SendKeys("Devil_260223");
            Password.SendKeys("Devil@260223");
            Login_Button.Submit();
            */

            IWebElement TEXTER = driver.FindElement(By.XPath("//*[@id='topPanel']/p"));


            string texts = TEXTER.Text;

            Console.WriteLine(texts);


        }

    }
}
