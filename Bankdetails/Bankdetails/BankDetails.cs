using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bankdetails
{

    internal class Bank : IBankDetails
    {
        //variable dec --private
        string bankName;
        string branchName;
        //property dec

        public string BankName
        {
            get { return bankName; }
            set { bankName = value; }
        }
        public string BranchName
        {
            get { return branchName; }
            set { branchName = value; }
        }
        public void getBankDetails(int id)
        {
            //set the value to pro

            Console.WriteLine("bank Details");
            Console.WriteLine("Bank name: {0}", bankName);
            Console.WriteLine("Branch name: {0}", branchName);

        }

      
      

        public int updateBankDetails()
        {
            return 0;
        }
    }

}

