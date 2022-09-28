using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasteringCSharp
{
    internal class ControlStatements
    {
        public void IfStatements()
        {
            int num;
            Console.WriteLine("Enter a Number: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > 10)
            {
                Console.WriteLine($"{num} is greater than 10 ");
            }
            else
                Console.WriteLine($"{num} is less than 10 ");

        }
    }
}
