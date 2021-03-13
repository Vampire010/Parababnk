using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Parababnk.Mouse_KeyBoard
{
    class Mouse_Over
    {
        IWebDriver driver;
       [Test]
        public void RTCLICK()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.snapdeal.com/");

            IWebElement src = driver.FindElement(By.XPath("//*[@id='leftNavMenuRevamp']/div[1]/div[2]/ul/li[1]/a/span[1]"));
            
            Actions act = new Actions(driver);
            act.MoveToElement(src).Perform();
            
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id=\'category1Data\']/div[1]/div/div/p[2]/a")).Click();
        }
    }
}
