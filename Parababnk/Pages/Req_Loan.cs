using OpenQA.Selenium;
using Parababnk.Browsersetup;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parababnk.Pages
{
    public class Req_Loan:Login
    {
       

        public void Req_FORlOan()
        {
           

            User_Login();

            IWebElement req_loans = Service.driver.FindElement(By.XPath("//*[@id='leftPanel']/ul/li[7]/a"));
            req_loans.Click();

            IWebElement Loan_Page = Service.driver.FindElement(By.XPath("//*[@id='rightPanel']/div/div/h1"));

            String Loan_Pages = Loan_Page.Text;
            Console.WriteLine(Loan_Pages);

            IWebElement Loan_Amount = Service.driver.FindElement(By.XPath("//*[@id='amount']"));
            Loan_Amount.SendKeys("200");

            IWebElement Down_Payment = Service.driver.FindElement(By.XPath("//*[@id='downPayment']"));
            Down_Payment.SendKeys("100");

            IWebElement Applay_Now = Service.driver.FindElement(By.XPath("//*[@id='rightPanel']/div/div/form/table/tbody/tr[4]/td[2]/input"));
            Applay_Now.Submit();

            IWebElement Request_Processed = Service.driver.FindElement(By.XPath("//*[@id='rightPanel']/div/div/div/p[1]"));

            String Request_Processed_Text = Loan_Page.Text;
            Console.WriteLine(Request_Processed_Text);
        }

    }
}
