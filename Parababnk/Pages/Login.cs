using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
            //ImplicitWait
            //Service.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5000);

            //WebDriverWait wait = new WebDriverWait(Service.driver, TimeSpan.FromSeconds(5));
            IWebElement Username = Service.driver.FindElement(By.XPath("//*[@id='loginPanel']/form/div[1]/input"));

            IWebElement Password = Service.driver.FindElement(By.XPath("//*[@id='loginPanel']/form/div[2]/input"));
            //Explicit Wait
            //IWebElement Login_Button = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='loginPanel']/form/div[3]/input")));

            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(Service.driver);

            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            
            fluentWait.PollingInterval = TimeSpan.FromSeconds(250);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element to be NoSuchElementException not found";


            IWebElement Login_Button = fluentWait.Until(x=>x.FindElement(By.XPath("//*[@id='loginPanel']/form/div[3]/input")));

            Username.SendKeys("Girish2021");
            test.Log(Status.Pass, "UserName Enterd");
           
            Password.SendKeys("Girish010");
            test.Log(Status.Pass, "Password Enterd");

            Login_Button.Click();
            test.Log(Status.Pass, "Clicking  on Login Button");

           // rep.Flush();

            try
            {
                IWebElement Usernames = Service.driver.FindElement(By.XPath("//*[@id='loginPanel']/form/div[1]/input"));

                Usernames.SendKeys("Girish2021");

            }

            catch
            {
                ITakesScreenshot ts = Service.driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();

                screenshot.SaveAsFile(@"C:\Users\91973\source\repos\Parababnk\Parababnk\Reports\Login.jpeg");

            }
        }

        public void Account_Overview()
        {
            IWebElement Account_Overview_btn = Service.driver.FindElement(By.XPath("//*[@id='leftPanel']/ul/li[2]/a"));
            Account_Overview_btn.Click();
        }

    }
}
