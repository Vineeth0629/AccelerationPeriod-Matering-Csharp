using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasteringCSharp
{
    internal class MethodsAndProsOfConsole
    {
        public void MethodsOfConsoleClass()
        {
           string name= Console.ReadLine();//Reads the entire line
            Console.Read();//read the key value of given char
            Console.WriteLine(name);    //it comes with line terminator
            Console.Write(name);//no line terminator
        }
    }
}
