using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Parabank_POM.TsetDataAccess;
using System;


namespace Parabank_POM.TestCases
{
    [TestFixture]
   public   class DataEngine
    {

        IWebDriver driver;
        [Test]
        public   void Excel_Engine()
        {
            ExcelOperations exl = new ExcelOperations();
            exl.PopulateCollection(@"C:\Users\91973\source\repos\Parababnk\Parabank_POM\TsetDataAccess\TestData.xlsx");

            string UN = exl.ReadData(1,"Key");
           // Console.WriteLine(UN);

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.FindElement(By.Name("q")).SendKeys(UN);

        }
    }
}
