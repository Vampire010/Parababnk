using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Parababnk.ALERT_POPUP_CONFIRM
{
    class Confirmation__ex1
    {
        IWebDriver driver;
       // [Test]
        public void Confirmation_box()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("file:///C:/Users/91973/source/repos/Parababnk/Parababnk/Frames_Html/Confirm_Popup_Box.html");
            IAlert alert = driver.SwitchTo().Alert();
            // Prints text and closes alert
            Thread.Sleep(5000);
            Console.WriteLine(alert.Text);
            //alert.Accept();

            alert.Dismiss();
        }
    }
}
