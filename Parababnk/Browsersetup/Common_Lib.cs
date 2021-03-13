using System;
using System.Collections.Generic;
using System.Text;

namespace Parababnk.Browsersetup
{
    public class Common_Lib
    {


        public  void Get_Title()
        {
            String Title = Service.driver.Title;
            
            if (Title.Equals("PARABANK"))

            Console.WriteLine(Title);


        }
    }
}
