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
                
               
                string Usr = ExcelOperations.ReadData(i, "USERNAME");
                //Thread.Sleep(2000);
                string Psw = ExcelOperations.ReadData(i, "PASSWORD");
              //  Thread.Sleep(2000);
                IWebElement Username = Service.driver.FindElement(By.XPath("//*[@id='loginPanel']/form/div[1]/input"));
                IWebElement Password = Service.driver.FindElement(By.XPath("//*[@id='loginPanel']/form/div[2]/input"));
                IWebElement Login_Button = Service.driver.FindElement(By.XPath("//*[@id='loginPanel']/form/div[3]/input"));
                string UsrNames = Usr;
                string UsrPaswd = Psw;
                Username.SendKeys(Usr);
                
                Password.SendKeys(Psw);
                Login_Button.Click();

                      
                string res = "Invalid Credentials";
                        UserData data = new UserData();
                        data.Credentials(ExcelOperations.ReadData(i, "USERNAME"), ExcelOperations.ReadData(i, "PASSWORD"), res);
          
            }              
        }
    }
}
