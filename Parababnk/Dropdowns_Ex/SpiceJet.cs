using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parababnk.Dropdowns_Ex
{
    class SpiceJet
    {

        IWebDriver driver;

        public void book()
        {
             driver = new ChromeDriver();
            driver.Navigate().GoToUrl("file:///C:/Users/91973/source/repos/Parababnk/Parababnk/Frames_Html/DropDown_Code.html");
            System.Threading.Thread.Sleep(4000);
            IWebElement element = driver.FindElement(By.XPath("//*[@id='example']/div[4]/div/div[2]/div[4]/div[1]/div[46]/div"));

            element.Click();

            SelectElement select_elem = new SelectElement(element);

          System.Threading.Thread.Sleep(4000);
            select_elem.SelectByIndex(5);
        
        
        
        }
    }
}
