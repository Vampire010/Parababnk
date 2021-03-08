using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Parababnk.ALERT_POPUP_CONFIRM
{
    class Prompt_EX
    {
        IWebDriver driver;
        [Test]
        public void Prompt_box()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("file:///C:/Users/91973/source/repos/Parababnk/Parababnk/Frames_Html/Prompt_popup.html");
            IAlert alert = driver.SwitchTo().Alert();
          
            // Prints text and closes alert
            Thread.Sleep(5000);
            Console.WriteLine(alert.Text);
           
            alert.SendKeys("SMITH");
            Thread.Sleep(5000);

            //alert.Accept();
            alert.Dismiss();
            Thread.Sleep(5000);


          Console.WriteLine(alert.Text);
           alert.Accept();
        }
    }
}
