using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Parababnk.Examples
{
    class Mul_WInHandle
    {
        IWebDriver driver;

       // [Test]
        public void Win()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.snapdeal.com/");
            //Switch to Frame 1
            //driver.SwitchTo().Frame(0);
            //ParentWinTitle = "Online Shopping Site India - Shop Electronics, Mobiles, Men & Women Clothing, Shoes - www. Snapdeal.com";
            // string ChildnewWinTitle = "bhawna collection Loard Shiv Trishul Damru Locket With Puchmukhi Rudraksha Mala Gold-plated Brass, Wood: Buy bhawna collection Loard Shiv Trishul Damru Locket With Puchmukhi Rudraksha Mala Gold-plated Brass, Wood at Best Price in India on Snapdeal";
            //String Name = driver.CurrentWindowHandle;

            String ParentWinTitle = driver.Title;
            Console.WriteLine(ParentWinTitle);

            //Parent window
            driver.FindElement(By.XPath("//*[@id='content_wrapper']/section/div[4]/section/div[2]/div[1]/div/div[5]/a/div[3]")).Click();
            Thread.Sleep(5000);

            //Switching Back to Parent Window 
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Thread.Sleep(5000);

            //in Parent window clicking About Us link
            driver.FindElement(By.XPath("//*[@id='sdFooter']/div[2]/div[1]/div/div[2]/ul/li[1]/a")).Click();

            //Switching Back to Child Window 
            Thread.Sleep(15000);
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            Thread.Sleep(5000);

            IWebElement P_name = driver.FindElement(By.XPath("//*[@id='productOverview']/div[2]/div/div[1]/div[1]/div[1]/h1"));
            String Produvt_name = P_name.Text;
            Console.WriteLine(Produvt_name);


        }

    }
}
