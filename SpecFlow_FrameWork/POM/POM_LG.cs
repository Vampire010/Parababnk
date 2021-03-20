using NUnit.Framework;
using Parababnk.Browsersetup;
using System;

namespace Parababnk.POM
{
    public  class POM_LG
    {


     // [Test]
        public void Post_Login_TC01()
        {
          
            string Usr = ExcelOperations.ReadData(1, "USERNAME");
            string Psw = ExcelOperations.ReadData(2, "PASSWORD");

            Console.WriteLine(Usr);
            Console.WriteLine(Psw);
        }



    }
}
