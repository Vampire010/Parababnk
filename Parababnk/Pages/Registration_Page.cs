using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Parababnk.Browsersetup;
using Parababnk.Reports;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace Parababnk.Pages 
{
    public class Registration_Page 

    {
        static ExtentReports rep = ExtentManager.getInstance();
        static ExtentTest test;

        public void RG_TC01_POS()
         {
            test = rep.CreateTest("RG_TC01_POS");

            test.Log(Status.Pass, "Parbank Welcome Page Loaded");
            IWebElement Reg_Link_Page = Service.driver.FindElement(By.XPath("//*[@id='loginPanel']/p[2]/a"));
            Reg_Link_Page.Click();
            test.Log(Status.Pass, "Parabank Registartion Page Loaded");

            IWebElement First_Name = Service.driver.FindElement(By.XPath("//input[@id='customer.firstName' or @name='customer.firstName']"));
            IWebElement Last_Name = Service.driver.FindElement(By.XPath("//input[@id='customer.lastName' and @name='customer.lastName']"));
            IWebElement Address = Service.driver.FindElement(By.XPath("//input[starts-with(@name,'customer.address.street')]"));
            IWebElement City = Service.driver.FindElement(By.XPath("//*[@id='customer.address.city']"));
            IWebElement State = Service.driver.FindElement(By.XPath("//*[@id='customer.address.state']"));
            IWebElement Zip_Code = Service.driver.FindElement(By.XPath("//*[@id='customer.address.zipCode']"));
            IWebElement Phone = Service.driver.FindElement(By.Id("customer.phoneNumber"));
            IWebElement SSN = Service.driver.FindElement(By.XPath("//*[@id='customer.ssn']"));
            IWebElement Username = Service.driver.FindElement(By.XPath("//*[@id='customer.username']"));
            IWebElement Password = Service.driver.FindElement(By.XPath("//*[@id='customer.password']"));
            IWebElement Confirm_Password = Service.driver.FindElement(By.XPath("//*[@id='repeatedPassword']"));
            IWebElement Register_Button = Service.driver.FindElement(By.XPath("//*[@id='customerForm']/table/tbody/tr[13]/td[2]/input"));
           
            //Service.driver.

            First_Name.SendKeys("Girish");
            test.Log(Status.Pass, " First Name Enterd");
            Last_Name.SendKeys("Rathode");
            test.Log(Status.Pass, " Last Name Enterd" );

            Address.SendKeys("Church Street,Avennue Parker");
            test.Log(Status.Pass, " Address Enterd" );

            City.SendKeys("NewYork");
            test.Log(Status.Pass, " City Name Enterd" );

            State.SendKeys("Albama");
            test.Log(Status.Pass, " State Name Enterd" );

            Thread.Sleep(2);
            Zip_Code.SendKeys("10006");
            test.Log(Status.Pass, " Zip Code  Enterd" );

            Phone.SendKeys("+91987654123");
            test.Log(Status.Pass, " Phone Number  Enterd" );
            Thread.Sleep(2);
         
            SSN.SendKeys("SEL120");
            test.Log(Status.Pass, " SSN Number  Enterd" );
            Thread.Sleep(2);
          
            Username.SendKeys("Devil_260203012");
            test.Log(Status.Pass, " USERNAME  Enterd");
            Thread.Sleep(2);

            Password.SendKeys("Devil@260203");
            test.Log(Status.Pass, " PASSWORD  Enterd");

            Confirm_Password.SendKeys("Devil@260203");
            test.Log(Status.Pass, " Confirm_Password  Enterd");
            Thread.Sleep(2);

            Register_Button.Click();
            
            Thread.Sleep(2);
            String Title= Service.driver.Title;
            if (Title.Equals("ParaBank | Customer Created"))
            {
                test.Log(Status.Pass, "User Successfully Created");
            }
            else
            {
                test.Log(Status.Fail, "User Not Registerd ");
                ITakesScreenshot ts = Service.driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();

                screenshot.SaveAsFile(@"C:\Users\91973\source\repos\Parababnk\Parababnk\Reports\Registartion.jpeg");
            }

            rep.Flush();
        }

        public void lOGout()
        {
            test = rep.CreateTest("RG_TC01_POS");
            IWebElement Logout = Service.driver.FindElement(By.XPath("//*[@id='leftPanel']/ul/li[8]/a"));
            Thread.Sleep(5000);
            Logout.Click();
            test.Log(Status.Pass, "User Loged Out ");
        }

    }
}