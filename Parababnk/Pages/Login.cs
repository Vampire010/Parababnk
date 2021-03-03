using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using AventStack.ExtentReports;
using OpenQA.Selenium;
using Parababnk.Browsersetup;
using Parababnk.Reports;

namespace Parababnk.Pages
{
    public class Login
    {
        ExtentReports rep = ExtentManager.getInstance();
        ExtentTest test;
        
        public void User_Login()
        {

            test = rep.CreateTest("Login_Test");

            test.Log(Status.Pass, "Page Loaded Successfully");

            IWebElement Username = Service.driver.FindElement(By.XPath("//*[@id='loginPanel']/form/div[1]/input"));
            

            IWebElement Password = Service.driver.FindElement(By.XPath("//*[@id='loginPanel']/form/div[2]/input"));            
            IWebElement Login_Button = Service.driver.FindElement(By.XPath("//*[@id='loginPanel']/form/div[3]/input"));
           
            Username.SendKeys("Devil_260223");
            test.Log(Status.Pass, "UserName Enterd");

            Password.SendKeys("Devil@260223");
            test.Log(Status.Pass, "Password Enterd");


            Login_Button.Click();
            test.Log(Status.Pass, "Clicking on on Login Button");

            rep.Flush();
        }


        public void Account_Overview()
        {

            IWebElement Account_Overview_btn = Service.driver.FindElement(By.XPath("//*[@id='leftPanel']/ul/li[2]/a"));
            Account_Overview_btn.Click();

        }

    }
}
