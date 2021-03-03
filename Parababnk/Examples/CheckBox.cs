using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parababnk.Examples
{
    class CheckBox
    {

        IWebDriver driver;

       //[Test]
        public void Test1()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://mykidsbank.org/");


            IWebElement CHeckBox1 = driver.FindElement(By.XPath("/html/body/table/tbody/tr[2]/td/table[1]/tbody/tr/td[2]/form/table[1]/tbody/tr[6]/td[2]/input"));
            bool selected_status1 = CHeckBox1.Selected;
            Console.WriteLine(selected_status1);


            IWebElement CHeckBox = driver.FindElement(By.XPath("/html/body/table/tbody/tr[2]/td/table[1]/tbody/tr/td[2]/form/table[1]/tbody/tr[6]/td[2]/input"));
            CHeckBox.Click();

            IWebElement CHeckBox2 = driver.FindElement(By.XPath("/html/body/table/tbody/tr[2]/td/table[1]/tbody/tr/td[2]/form/table[1]/tbody/tr[6]/td[2]/input"));
            bool selected_status2 = CHeckBox1.Selected;
            Console.WriteLine(selected_status2);

            Console.WriteLine(driver.Manage().Window.Size);




        }
    }
}
