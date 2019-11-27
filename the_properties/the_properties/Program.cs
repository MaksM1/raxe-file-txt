using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(300);

            acc.Notify += new Account.AccountHadler(Display);
            acc.Put(20);
            acc.Take(70);
            acc.Take(1750);
            Console.Read();
        }

        private static void Display (object sender, AccountEventArgs e)
        {
            Console.WriteLine($"Сумма транзакции {e.Sum}");
            Console.WriteLine(e.Massage);
        }
    }
}

