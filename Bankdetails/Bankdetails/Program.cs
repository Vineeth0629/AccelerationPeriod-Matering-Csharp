using System;
namespace Bankdetails
{
    class program
    {
        static void Main(string[] args)
        {

            var b= new Bank();
            //b.getBankDetails();
            b.BankName = Console.ReadLine();
            b.BranchName = Console.ReadLine();
            Console.WriteLine(b.BankName);
            b.getBankDetails();

        }
    }
}