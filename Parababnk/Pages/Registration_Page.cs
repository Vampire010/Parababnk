using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Parababnk.Browsersetup;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Parababnk.Pages 
{
    public class Registration_Page 

    {



        public void RG_TC01_POS()
         {
            IWebElement Reg_Link_Page = Service.driver.FindElement(By.XPath("//*[@id='loginPanel']/p[2]/a"));
            Reg_Link_Page.Click();

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

           
            First_Name.SendKeys("Girish");
            Last_Name.SendKeys("Rathode");
            Address.SendKeys("Church Street,Avennue Parker");
            City.SendKeys("NewYork");
            State.SendKeys("Albama");
            Thread.Sleep(2);
            Zip_Code.SendKeys("10006");
            Phone.SendKeys("+91987654123");
            Thread.Sleep(2);
            SSN.SendKeys("SEL120");
            Thread.Sleep(2);
            Username.SendKeys("Devil_242");
            Thread.Sleep(2);
            Password.SendKeys("Devil@24");

            Confirm_Password.SendKeys("Devil@24");
            Thread.Sleep(2);
            Register_Button.Click();


            String Title= Service.driver.Title;
            if (Title.Equals("ParaBank | Customer Created"))
            {
                Console.WriteLine("RG_TC01_POS : - Test Passed");

            }



        }
        public void RG_TC01_NEG()
        {
            IWebElement Reg_Link_Page = Service.driver.FindElement(By.XPath("//*[@id='loginPanel']/p[2]/a"));
            Reg_Link_Page.Click();

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

            First_Name.SendKeys("Girish");
            Last_Name.SendKeys("Rathode");
            Address.SendKeys("Church Street,Avennue Parker");
            City.SendKeys("NewYork");
            State.SendKeys("Albama");
            Thread.Sleep(2);
            Zip_Code.SendKeys("10006");
            Phone.SendKeys("+91987654123");
            Thread.Sleep(2);
            SSN.SendKeys("SEL120");
            Thread.Sleep(2);
            Username.SendKeys("Devil_24");
            Thread.Sleep(2);
            Password.SendKeys("Devil@24");
            Confirm_Password.SendKeys("Devil@24");
            Thread.Sleep(2);
            Register_Button.Click();

            //String Title = "ParaBank | Customer Created";
            String Title = Service.driver.Title;
            Console.WriteLine(Title);

            if (Title.Equals("ParaBank | Customer Created"))
            {
                Console.WriteLine("RG_TC01_NEG : - Negative Test Failed - Because Customer Registerd Successfully  ");

            }
            else 
            {
                Console.WriteLine("RG_TC01_NEG : - Negative Test Passed");
            }
        }
    }
}