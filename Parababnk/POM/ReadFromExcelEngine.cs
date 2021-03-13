using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Parababnk.Browsersetup;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CacheLookupAttribute = SeleniumExtras.PageObjects.CacheLookupAttribute;
using FindsByAttribute = SeleniumExtras.PageObjects.FindsByAttribute;
using How = SeleniumExtras.PageObjects.How;

namespace Parababnk.POM
{
    
    public class ReadFromExcelEngine
    {
       


        public void im_Ready()
        {
            ExcelOperations.PopulateInCollection(@"C:\Users\91973\source\repos\Parababnk\Parababnk\Reports\TestData.xlsx");
            string Usr = ExcelOperations.ReadData(1, "USERNAME");
            string Psw = ExcelOperations.ReadData(2, "PASSWORD");


            IWebElement Username = Service.driver.FindElement(By.XPath("//*[@id='loginPanel']/form/div[1]/input"));

            IWebElement Password = Service.driver.FindElement(By.XPath("//*[@id='loginPanel']/form/div[2]/input"));
            
            IWebElement Login_Button = Service.driver.FindElement(By.XPath("//*[@id='loginPanel']/form/div[3]/input"));

            Username.SendKeys(Usr);

            Password.SendKeys(Psw);

            Login_Button.Click();

        }
     
    }
}
