using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlow_FrameWork.Reports;
using System;
using TechTalk.SpecFlow;

namespace SpecFlow_FrameWork.Step_Def
{
    [Binding]
    public class Login_KidsbankSteps: Create_Report
    {


        String test_url = "http://mykidsbank.org";

        IWebDriver driver;
        ExtentReports rep = ExtentManager.getInstance();
        ExtentTest test;

        [Given(@"User should be on Kidsbank Login page")]
        public void GivenUserShouldBeOnKidsbankLoginPage()
        {
            test = rep.CreateTest("User_Login");
            test.Log(Status.Pass, "Browser Opend");

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(test_url);
            test.Log(Status.Pass, "User logInpage");
        }

        [Then(@"Enter Banker_ID")]
        public void ThenEnterBanker_ID()
        {
            test = rep.CreateTest("User_Login");
            driver.FindElement(By.XPath("/html/body/table/tbody/tr[1]/td/table/tbody/tr/td[2]/form/table/tbody/tr[2]/td[2]/span/input")).SendKeys("123456");
            test.Log(Status.Pass, "User Eneterd Banker Id");

        }

        [Then(@"Enter UserName")]
        public void ThenEnterUserName()
        {
            test = rep.CreateTest("User_Login");

            driver.FindElement(By.XPath("/html/body/table/tbody/tr[1]/td/table/tbody/tr/td[2]/form/table/tbody/tr[2]/td[4]/span/input")).SendKeys("girish010");

            test.Log(Status.Pass, "User Eneterd UserName");

        }

        [Then(@"Enter the Usr_Password")]
        public void ThenEnterTheUsr_Password()
        {
            driver.FindElement(By.XPath("/html/body/table/tbody/tr[1]/td/table/tbody/tr/td[2]/form/table/tbody/tr[2]/td[6]/span/input")).SendKeys("pass010");
            test.Log(Status.Pass, "User Eneterd Password");

        }

        [Then(@"Click Login_Button")]
        public void ThenClickLogin_Button()
        {
            test = rep.CreateTest("User_Login");

            driver.FindElement(By.XPath("//*[@id='clicked_when_enter_id']")).Click();

            test.Log(Status.Pass, "User Clicked on ligin Button");


        }
    }
}
