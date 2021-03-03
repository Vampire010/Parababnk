using System;
using System.Collections.Generic;
using System.Text;

namespace Parababnk.Browsersetup
{
    public class Common_Lib
    {


        public static string Get_Title(string a)
        {
            String Title = Service.driver.Title;
            Console.WriteLine(Title);
            return a;
        
        }
    }
}
