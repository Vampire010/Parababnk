using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parababnk.Examples
{
    class Enabled_EX
    {
        IWebDriver driver;




        [Test]
        public void Test1()
        {
            driver = new ChromeDriver();
           
            driver.Navigate().GoToUrl("file:///C:/Users/91973/source/repos/Parababnk/Parababnk/Frames_Html/Example.html");

           IWebElement ClickME = driver.FindElement(By.XPath("/html/body/button"));
            
           Boolean clk = ClickME.Enabled;

             Console.WriteLine("Element Enabled  " +clk);

            IWebElement Imputtxt = driver.FindElement(By.XPath("/html/body/input"));



        }

    }
}
