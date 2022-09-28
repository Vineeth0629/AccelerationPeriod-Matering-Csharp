using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasteringCSharp.Assignment
{
    internal class FindCharacterInAString
    {
        public void FindString()
        {

            Console.WriteLine("Enter the string or word : \n");
            string mainString = Console.ReadLine();
            Console.WriteLine("Enter Char to find: \n");
            //converting string to char
            char find =  Convert.ToChar( Console.ReadLine());
            //contains is a predefined string function
            if (mainString.Contains(find))
            {
                Console.WriteLine("{0} is there in given {1}", find, mainString);
            }
            else
                Console.WriteLine("{0} is not there in given {1}", find, mainString);
        }
    }
}
