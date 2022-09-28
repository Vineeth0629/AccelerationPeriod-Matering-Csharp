using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasteringCSharp
{
    internal class TypeCasting
    {
        public void ImplicitExplisit()
        {
            //implicit conversion - no data loss lower to higher data type like int to string or decimal
            //explicit conversion  - data loss higher to lower - decimal to int
            string abc = "123";
            int a = Convert.ToInt32(abc);
            char xcv = 'c';
            float f = 123.23f;
            int val = (int)f;
            val= Convert.ToInt32(val);
            string x=Convert.ToString(f);
            string d = Convert.ToString(xcv);
            Console.WriteLine("converting the string to int :" +abc);
            Console.WriteLine("converting the char to float :" + x);


        }
    }
}
