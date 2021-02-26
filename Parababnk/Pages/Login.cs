using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using Parababnk.Browsersetup;
namespace Parababnk.Pages
{
    public class Login
    {

        public void User_Login()
        {



            IWebElement Username = Service.driver.FindElement(By.XPath("//*[@id='loginPanel']/form/div[1]/input"));
            IWebElement Password = Service.driver.FindElement(By.XPath("//*[@id='loginPanel']/form/div[2]/input"));            
            IWebElement Login_Button = Service.driver.FindElement(By.XPath("//*[@id='loginPanel']/form/div[3]/input"));
           
            Username.SendKeys("Devil_260223");
            Password.SendKeys("Devil@260223");
            Login_Button.Click();
        }


        public void Account_Overview()
        {

            IWebElement Account_Overview_btn = Service.driver.FindElement(By.XPath("//*[@id='leftPanel']/ul/li[2]/a"));
            Account_Overview_btn.Click();

        }

    }
}
