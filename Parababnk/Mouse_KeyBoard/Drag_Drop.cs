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
    class Drag_Drop
    {
        IWebDriver driver;
       // [Test]
        public void Drag_Drops()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://demo.guru99.com/test/drag_drop.html");
            
            IWebElement sourse = driver.FindElement(By.XPath("//*[@id='fourth']/a"));
            Thread.Sleep(5000);

            IWebElement dest = driver.FindElement(By.XPath("//*[@id='amt7']/li"));

            Actions act = new Actions(driver);
            act.DragAndDrop(sourse , dest).Perform();
       

        }
    }
}
