﻿using AccountApp.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            Account account = new Account(7020, "xyz", 1200);
            Account a = (account);
            Account account1 = new Account(9090, "abc",7000);
            //      InsufficientFundsException excep = new InsufficientFundsException(a);
            //    account.Deposit(100);
           
            PrintDetails(account);
          //  account.Details(account);
            try
            {
                account.Withdraw(1000);
               
            }
           catch(InsufficientFundsException e)
            {
               
                Console.WriteLine("Exception:{0}", e.Message);
                 Console.WriteLine("Balance :{0}",e.ac.Balance);
               
            }
            PrintDetails(account);

            Console.WriteLine("");
         //   account1.Deposit(500);
          //  account1.Withdraw(200);
          //  PrintDetails(account1);
            //    PrintDetails(account1);

        }

       private static void PrintDetails(Account acc)
        {
            Console.WriteLine("Acc no:{0}", acc.Accno);
            Console.WriteLine("Name:{0}", acc.Name);
            Console.WriteLine("Balance:{0}", acc.Balance);
        }
    }
}
