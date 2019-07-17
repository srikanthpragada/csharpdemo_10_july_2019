using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class Account
    {
        // Instance variables
        private int acno;
        private string ahname;
        private double balance;

        // Constructor
        public Account(int ano, string name, double bal = 0)
        {
            acno = ano;
            ahname = name;
            balance = bal;
        }

        public Account()
        {
        }

        // Methods 
        public void Deposit(double amount)
        {
            if (amount > 0)
                balance += amount;
            else
                Console.WriteLine("Invalid amount!");
        }

        public void Withdraw(double amount)
        {
            if (amount <= balance)
                balance -= amount;
            else
                Console.WriteLine("Insufficient Balance!");
        }


        public void Print()
        {
            Console.WriteLine(acno);
            Console.WriteLine(ahname);
            Console.WriteLine(balance);
        }
    }
}
