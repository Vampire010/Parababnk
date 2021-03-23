using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parababnk.Collection_Practice
{
  public  class LogInTest: User
    {
        String test_url = "http://mykidsbank.org/";

        IWebDriver driver;
        //[FindsBy(How = How.TagName, Using = "a")]
        public IWebElement hrefClick { get; set; }

        [Test]
        public void TestT2Links()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(test_url);

            foreach (IWebElement item in driver.FindElements(By.TagName("a")))
            {              
                Console.WriteLine(item.GetAttribute("href"));    
          }        
        }
    }
}
