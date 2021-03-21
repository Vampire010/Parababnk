using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parababnk.Examples
{
    class classadd
    {
        int a = 10;
        int b = 20;

        [Test]
        public void test()
        {
            int c = a + b;
            Console.WriteLine(c);
        
        }
    }
}
