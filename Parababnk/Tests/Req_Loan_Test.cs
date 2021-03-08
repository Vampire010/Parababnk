using NUnit.Framework;
using Parababnk.Browsersetup;
using Parababnk.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parababnk.Tests
{
   public class Req_Loan_Test: Req_Loan
    {

        string Appurl = "https://parabank.parasoft.com";

       //[Test]
        public void Login_TC01()
        {
            String[] Browsers = { "Chrome" };
            foreach (String drivers in Browsers)
            {
                Service.StartBrowser(drivers, Appurl);
                Req_FORlOan();


            }
        }

    }
}
