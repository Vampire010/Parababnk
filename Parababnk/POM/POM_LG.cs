using NUnit.Framework;
using Parababnk.Browsersetup;
using System;

namespace Parababnk.POM
{
    public  class POM_LG
    {

        string Appurl = "https://parabank.parasoft.com";
        
     //   [Test]
        private void Login_TC01()
        {
            String[] Browsers = { "Chrome" };
            foreach (String drivers in Browsers)
            {
              
                Service.StartBrowser(drivers, Appurl);
                
            }
        }
    }
}
