using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using WDSE;
using WDSE.Decorators;
using WDSE.ScreenshotMaker;

namespace Parababnk.ALERT_POPUP_CONFIRM
{
    class Alert_ex1
    {
        IWebDriver driver;
       //[Test]
        public void alertbox()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("file:///C:/Users/91973/source/repos/Parababnk/Parababnk/Frames_Html/Alert_Popup_box.html");
            
            IAlert alert = driver.SwitchTo().Alert();
            
            // Prints text and closes alert
            Thread.Sleep(5000);

            Console.WriteLine(alert.Text);

            alert.Accept();

        }
    }
}
