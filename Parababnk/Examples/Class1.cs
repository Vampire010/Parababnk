using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Parababnk.Examples
{
    class Class1
    {
        IWebDriver driver;

        //[Test]
        public void Runner()
        {
           driver = new ChromeDriver();
           driver.Navigate().GoToUrl("https://dev-online.dev.tsretail.co.za/landing");
            Thread.Sleep(10000);
            /*driver.FindElement(By.XPath("/html/body/app-root/div/div/top-navigation/div/div/div/div[1]/div[2]/button-with-notification[2]")).Click();
            driver.FindElement(By.Id("qa-input-login-username")).SendKeys("Abc@xyz.com");
            driver.FindElement(By.Id("qa-input-login-password")).SendKeys("Abc@xyz.com");
            driver.FindElement(By.Id("qa-sign-in-button")).Click();  */

            driver.FindElement(By.XPath("/html/body/app-root/div/div/top-navigation/div/div/div/div[1]/div[2]/button-with-notification[1]")).Click();

            driver.FindElement(By.XPath("/html/body/app-root/div/div/top-navigation/div/div/div/div[1]/div[2]/button-with-notification[1]")).Click();

            driver.FindElement(By.Id("qa-first-name")).SendKeys("Abc@xyz.com");
            driver.FindElement(By.Id("qa-surname")).SendKeys("Abc@xyz.com");
            driver.FindElement(By.Id("qa-identification-input")).SendKeys("Abc@xyz.com");
            driver.FindElement(By.Id("qa-password")).SendKeys("Abc@xyz.com");
            driver.FindElement(By.Id("qa-confirm-password")).SendKeys("Abc@xyz.com");
            driver.FindElement(By.Id("qa-next-on-personal-info")).Click();

        }

        
    }
}
