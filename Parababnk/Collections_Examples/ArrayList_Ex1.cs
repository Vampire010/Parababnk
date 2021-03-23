using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parababnk.Collections_Examples
{
    class ArrayList_Ex1
    {
      //  [Test]
        public void arrlist_ex()
        {
            ArrayList arrlist = new ArrayList();
            arrlist.Add("Welcome");
            arrlist.Add(100);
            arrlist.Add(20.5);
            arrlist.Add('A');

            Console.WriteLine("ArrayList Count: " + arrlist.Count);
            Console.WriteLine("ArrayList Capacity: " + arrlist.Capacity);
            Console.WriteLine("*********ArrayList Elements********");
            
            foreach (var item in arrlist)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }
}
