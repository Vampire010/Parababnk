using NUnit.Framework;
using OpenQA.Selenium;
using Parababnk.Browsersetup;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Parababnk.Data_Engine
{
    public class LoginTest_Data
    {

       // [Test]
        public string test1(string username, string password)
        {
            IWebElement Username = Service.driver.FindElement(By.XPath("//*[@id='loginPanel']/form/div[1]/input"));

            IWebElement Password = Service.driver.FindElement(By.XPath("//*[@id='loginPanel']/form/div[2]/input"));
            IWebElement Login_Button = Service.driver.FindElement(By.XPath("//*[@id='loginPanel']/form/div[3]/input"));
            Username.SendKeys(username);
            Password.SendKeys(password);
            Login_Button.Click();
            return null;
        }
    }
}
