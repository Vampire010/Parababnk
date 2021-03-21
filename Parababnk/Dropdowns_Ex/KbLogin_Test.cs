using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parababnk.Dropdowns_Ex
{
    class KbLogin_Test
    {
        String test_url = "http://mykidsbank.org/";
        String bank_id = "123456";
        String username = "girish010";
        String password = "abc1234";
        IWebDriver driver;
        [Test]
        public void tst()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(test_url);

            IWebElement BankerID = driver.FindElement(By.Name("bank_id"));
            BankerID.Clear();
            BankerID.SendKeys(bank_id);

            IWebElement Username = driver.FindElement(By.Name("username"));
            Username.Clear();
            Username.SendKeys(username);

            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.Clear();
            Password.SendKeys(password);

            IWebElement Login_btn = driver.FindElement(By.XPath("//*[@id='clicked_when_enter_id']"));
            Login_btn.Click();


        }
    }
}
