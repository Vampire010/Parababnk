using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Parabank_POM.PageObjects;

using System.Configuration;

namespace Parabank_POM.TestCases
{
    class LogInTest
    {
       // [Test]
        public void Test()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Url = ConfigurationManager.AppSettings["URL"];

            var homePage = new HomePage(driver);
            homePage.ClickOnMyAccount();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication("LogInTest");

            driver.Close();
        }
    }
}
