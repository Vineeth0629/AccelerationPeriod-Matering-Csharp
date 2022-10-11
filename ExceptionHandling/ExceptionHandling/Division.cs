using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Division
    {
        private string[] val = new string[3];
        // this - is the keyword having a parameters list
        public string this[int index]
        {

            get
            {

                return val[index];
            }


            set
            {

                val[index] = value;
            }
        }

        public int devideTwoNumbers(int a, int b)
        {
            int c = 0;
            try
            {
                c = a / b;
            }
            catch (DivideByZeroException exception)
            {
                throw exception;
            }

            catch (Exception ex)
            {

                return 0;
            }
            return c;
        }
    }
}
