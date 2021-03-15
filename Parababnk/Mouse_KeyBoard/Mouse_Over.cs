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
            driver.Manage().Window.Maximize();

            IWebElement src = driver.FindElement(By.XPath("//*[@id='leftNavMenuRevamp']/div[1]/div[2]/ul/li[1]/a/span[1]"));
            
            Actions act = new Actions(driver);
            act.MoveToElement(src).Perform();
            
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id=\'category1Data\']/div[1]/div/div/p[2]/a")).Click();

            IWebElement search_text = driver.FindElement(By.XPath("//*[@id='inputValEnter']"));
            IWebElement pincode_text = driver.FindElement(By.XPath("//*[@id='content_wrapper']/div[9]/div[2]/div[2]/div[4]/div/div[2]/input"));

            search_text.SendKeys("560086");
            search_text.SendKeys(Keys.Control + "A");
            search_text.SendKeys(Keys.Control + "C");

            pincode_text.SendKeys(Keys.Control + "V");

        }
    }
}
