using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_traning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter speech:");

            string speech = Console.ReadLine();

            string[] word = speech.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            string first;


            for(int i = 0; i < word.Length; i++)
            {
                first = word[i].Substring(0, 1);
                Console.Write(first.Insert(1,"."));
            }

            Console.ReadLine();

        }
    }
}
