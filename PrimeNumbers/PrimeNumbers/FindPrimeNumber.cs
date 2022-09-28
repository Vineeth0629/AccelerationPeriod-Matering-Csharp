using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasteringCSharp.Assignment
{
    internal class FindPrimeNumber
    {
        public void IsPrimeNumber()
        {
            //Declaration  
            bool isPrime = true;
            int i, j;
            //Calculate and display the Prime number  
            Console.WriteLine("Prime Numbers are : ");
            for (i = 2; i <= 100; i++)
            {
                //loop until the main number
                for (j = 2; j <= i; j++)
                {
                    //i not equal to j and number should be divisible by other numbers 
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write("\t" + i);
                }
                isPrime = true;
            }
            Console.ReadKey();
        }
    }
}

