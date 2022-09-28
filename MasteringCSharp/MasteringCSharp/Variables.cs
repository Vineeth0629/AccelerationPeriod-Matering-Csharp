using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//data_type variable_name = value;
namespace MasteringCSharp
{
    internal class Variables
    {
      
        static int b = 10;
        const int id =123; // throught application we can't change the value
        readonly int empid; //
        public static void VariablesNames()
        {
        //instance of class is required to access Non static members
            TypeCasting obj = new TypeCasting();
            obj.ImplicitExplisit();
            //initialization
            string name = "hello";
            
            int a = b;//non static
           
            Console.WriteLine(b);
           
        }

    }
}
