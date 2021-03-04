using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Parababnk.Browsersetup;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parababnk.Examples
{
    class Enabled_EX
    {
     //  [Test]
        public static void Test1()
        {

            string Appurl = "file:///C:/Users/91973/source/repos/Parababnk/Parababnk/Frames_Html/Example.html";

                String[] Browsers = { "Chrome" };
                foreach (String drivers in Browsers)
                {
                    Service.StartBrowser(drivers, Appurl);

                    IWebElement ClickME = Service.driver.FindElement(By.XPath("/html/body/button"));
                    Boolean clk = ClickME.Enabled;
                    try
                    {
                        IWebElement Imputtxt = Service.driver.FindElement(By.XPath("/html/body/input"));
                        bool inp = ClickME.Displayed;
                    }
                    catch
                    {
                        Console.WriteLine("Element is Not Displayed");
                    }
              
                }
        }
    }
}
