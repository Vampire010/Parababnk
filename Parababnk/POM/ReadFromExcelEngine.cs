using GemBox.Spreadsheet;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Parababnk.Browsersetup;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CacheLookupAttribute = SeleniumExtras.PageObjects.CacheLookupAttribute;
using FindsByAttribute = SeleniumExtras.PageObjects.FindsByAttribute;
using How = SeleniumExtras.PageObjects.How;

namespace Parababnk.POM
{
    
    public class ReadFromExcelEngine
    {
      
        public  void im_Ready()
        {
            ExcelOperations.PopulateInCollection(@"C:\Users\91973\source\repos\Parababnk\Parababnk\Reports\UserTestData.xlsx");

            for (int i = 1; i <= 5; i++)
            {

                string BankerIDS = ExcelOperations.ReadData(i, "BANKER_ID");

                string Usr = ExcelOperations.ReadData(i, "USERNAME");
               // Thread.Sleep(2000);
                string Psw = ExcelOperations.ReadData(i, "PASSWORD");

                //Thread.Sleep(2000);
                Thread.Sleep(2000);
                IWebElement Banker_ID = Service.driver.FindElement(By.XPath("/html/body/table/tbody/tr[1]/td/table/tbody/tr/td[2]/form/table/tbody/tr[2]/td[2]/span/input"));
                IWebElement Username = Service.driver.FindElement(By.XPath("/html/body/table/tbody/tr[1]/td/table/tbody/tr/td[2]/form/table/tbody/tr[2]/td[4]/span/input"));
                IWebElement Password = Service.driver.FindElement(By.XPath("/html/body/table/tbody/tr[1]/td/table/tbody/tr/td[2]/form/table/tbody/tr[2]/td[6]/span/input"));
                IWebElement Login_Button = Service.driver.FindElement(By.XPath("//*[@id='clicked_when_enter_id']"));

                Banker_ID.SendKeys(BankerIDS);
                Username.SendKeys(Usr);

                Password.SendKeys(Psw);
                Login_Button.Click();
            }

        }
    }
}
