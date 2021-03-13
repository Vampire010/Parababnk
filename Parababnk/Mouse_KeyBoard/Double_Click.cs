using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parababnk.Mouse_KeyBoard
{
    class Double_Click
    {
        IWebDriver driver;
      //  [Test]
        public void DBCLICK()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("file:///C:/Users/91973/git/repository/Parbank/HTML_PAGES/dbclick.html");

            IWebElement ele = driver.FindElement(By.XPath("//*[@id='demo']"));
            Actions act = new Actions(driver);
            act.DoubleClick(ele).Perform();
        }
    }
}
