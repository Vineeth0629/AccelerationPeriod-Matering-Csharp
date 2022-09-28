using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasteringCSharp
{
    internal class Literals
    {
        public void LiteralFunction()
        {
            int b = 123;
            uint a = 123u;
            float f = 12.21f;
            double d = 1.45D;
            string s1 = "hellow world";
            string s2 = @"hellow\world\dgj3";
            Console.WriteLine(a);
            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine("The value of b is :" +b);
            Console.WriteLine("Given string :" +s1 );
            Console.WriteLine($"Given string :{s2} and second string is :{s1}"  );
            bool b1=true;
            bool b2=false;
          
            Console.WriteLine(b1);
            Console.WriteLine(b2);
          

        }

    }
}
