﻿using AventStack.ExtentReports;
using NUnit.Framework;
using Parababnk.Browsersetup;
using Parababnk.Pages;
using Parababnk.POM;
using Parababnk.Reports;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parababnk.Tests
{

    [TestFixture]
    class Login_Test: ReadFromExcelEngine
    {
        string Appurl = "http://mykidsbank.org";
       
 //   [Test]
        public void Login_TC01()
        {
            String[] Browsers = { "Chrome" };
            foreach (String drivers in Browsers)
            {
                
                    Service.StartBrowser(drivers, Appurl);

                    im_Ready();
                
            }
        }

    }
}
