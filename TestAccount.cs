using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class TestAccount
    {
        static void Main(string[] args)
        {
            Account a; // object reference

            a = new Account(101, "Steve");
            a.Deposit(5000);
            a.Deposit(-3000);
            a.Print();

            Account a2 = new Account();


        }
    }

}
