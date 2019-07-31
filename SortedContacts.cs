using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class SortedContacts
    {
        static void Main(string[] args)
        {
            var contacts = new SortedDictionary<string,string>();

            while (true)
            {
                Console.Write("Enter name [end to stop] :");
                string name = Console.ReadLine();
                if (name == "end")
                    break;
                Console.Write("Enter mobile number :");
                string mobile = Console.ReadLine();
                contacts.Add(name, mobile);
            }

            foreach (string name in contacts.Keys)
                Console.WriteLine("{0} - {1}", name, contacts[name]);
        }
    }
}
