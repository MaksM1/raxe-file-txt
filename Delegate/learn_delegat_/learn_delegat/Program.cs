using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_delegat
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(300);

            account.RegisterHandler(show_mes);
            account.RegisterHandler(Color_mes);

            account.Withdraw(200);
            account.Withdraw(100);

            account.UnRegisterHandler(Color_mes);
            account.Withdraw(100);
            Console.Read();

        }
        private static void show_mes(string mess)
        {
            Console.WriteLine(mess);
        }

        private static void Color_mes(string mess)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(mess);
            Console.ResetColor();
        }
       
    }
}
