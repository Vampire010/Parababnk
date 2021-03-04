using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Parababnk.Examples
{
    class SCENARIO_FRAMES
    {
        IWebDriver driver;

       //[Test]
        public void tests()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("file:///C:/Users/91973/source/repos/Parababnk/Parababnk/Frames_Html/SCENARIO_1.html");
            
            //Switch to Frame 1
            driver.SwitchTo().Frame(0);
            driver.FindElement(By.Id("Fname1")).SendKeys("Smith");

            //Switch to Main Frame  
            driver.SwitchTo().DefaultContent();
            IWebElement IFrame2 = driver.FindElement(By.XPath("//*[@id='Frame2']"));
            driver.SwitchTo().Frame(IFrame2);
            driver.FindElement(By.Id("Fname2")).SendKeys("John");

            //Switch to  Frame 3 *--
            driver.SwitchTo().DefaultContent();           
            driver.SwitchTo().Frame("Frame3");
            driver.FindElement(By.Id("Fname3")).SendKeys("Ken");

        }
    }
}
