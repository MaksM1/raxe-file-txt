using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extion
{
   
    class Program
    {
       

        static void Main(string[] args)
        {
            AllBook allBook = new AllBook();

            allBook.EvBook += Display;


            allBook.AddBook(25, "история");

            allBook.AddBook(25, "Математика");

            allBook._EvBook += Display;
            Console.ReadLine();
        }

        public static void Display(object sender, AllBookArgs allBook)
        {
            Console.WriteLine($"{allBook.Mess} и их количтво {allBook.AmountBook}");
        }
    }
}
