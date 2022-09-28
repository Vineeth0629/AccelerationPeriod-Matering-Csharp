using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasteringCSharp
{
    internal class OperatorsClass
    {
        public void OperatorFunc()
        {
            int a = 10;
            int b = 5;
            int c = a + b;

            a += b; //a=a+b; That means (a += b) can be written as (a = a + b);//Add asignment operator
            //relational operators == < > != <= >=
            int d = a == b ? 23 : 45;

            //logical operators || &&  !
            int j = !(a == b || a <= b) ? 56 : 67;
            //Bitwise operator & - and  | - or ^ - nor - it converts the values to binary 
            int result = a & b;
        }
    }
}
