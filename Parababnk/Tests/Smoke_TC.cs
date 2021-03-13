using AventStack.ExtentReports;
using NUnit.Framework;
using Parababnk.Browsersetup;
using Parababnk.Pages;
using Parababnk.Reports;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parababnk.Tests
{
    class Smoke_TC
    {
        string Appurl = "https://parabank.parasoft.com";

       // [Test, Order(2)]

        public void TC01()
        {
            String[] Browsers = { "Chrome" };
            foreach (String drivers in Browsers)
            {
                Service.StartBrowser(drivers, Appurl);
                Registration_Page Rp = new Registration_Page();
                Rp.RG_TC01_POS();
                Rp.lOGout();
               
            }
        }

        //[Test, Order(1)]
        //[Ignore("Ignore TCO2")]
        public void TC02()
        {
            String[] Browsers = { "Chrome" };
            foreach (String drivers in Browsers)
            {
                Service.StartBrowser(drivers, Appurl);
              
                Login lg = new Login();
                lg.User_Login();
            }
        }


        //[Test, Order(3)]
        public void TC03()
        {
            String[] Browsers = { "Chrome" };
            foreach (String drivers in Browsers)
            {
                Service.StartBrowser(drivers, Appurl);

                Login lg = new Login();
                lg.User_Login();
            }
        }

    }

}
