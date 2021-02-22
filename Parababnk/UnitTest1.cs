using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Parababnk
{
   // [TestFixture]
    public class Test2s
    {
        IWebDriver driver;
      // [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://parabank.parasoft.com");
        }

        //[Test]
        public void Test1()
        {
            // driver.FindElement(By.Id("autoclosable-btn-success")).Click();
            //driver.FindElement(By.Name("q")).SendKeys("Google");
            //driver.FindElement(By.ClassName("gNO89b")).Click();

            //Read more....
            //driver.FindElement(By.PartialLinkText("Read more")).Click();
            // driver.FindElement(By.TagName("input")).SendKeys("Hello");
            driver.FindElement(By.CssSelector("#loginPanel > p:nth-child(3) > a")).Click();


        }

  
    }
}