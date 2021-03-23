using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parababnk.Collection_Practice
{
 public   class MyLogin
    {
        IWebDriver driver;
        [Test]
        public void test_login()
        {


            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://mykidsbank.org/");

            List<User> user_data = new List<User>()
                        {
                        new User{BID= 55778, UserName= "john24", UsrPswd= "devil2456"},
                        new User{BID = 55779, UserName = "smith101", UsrPswd = "vampire142"},
                        new User { BID = 55780, UserName = "james007", UsrPswd = "gunner12" },
                        new User { BID = 55781, UserName = "rony12", UsrPswd = "king89" }
                     };

            foreach (User u in user_data)
            {

                int bid = u.BID;  
             
                  IWebElement BankerID = driver.FindElement(By.Name("bank_id"));
                  BankerID.Clear();
                  BankerID.SendKeys(bid.ToString());
                 
                  IWebElement Username =driver.FindElement(By.Name("username"));
                  Username.Clear();
                  Username.SendKeys(u.UserName); ;

                  IWebElement Password = driver.FindElement(By.Name("password"));
                  Password.Clear();
                  Password.SendKeys(u.UsrPswd);

                  IWebElement Login_btn = driver.FindElement(By.XPath("//*[@id='clicked_when_enter_id']"));
                  Login_btn.Click();  
                  
                Console.WriteLine(u.BID +"  "  + u.UserName +"  " + u.UsrPswd);
            }
        }
    }
}
