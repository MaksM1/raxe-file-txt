using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_Learn
{
    public delegate bool Operation( int  x);
    public delegate int Operation2( int x);
    class Program
    {
        delegate bool IsEqual(int x);
        static void Main(string[] args)
        {
           
            

           
            int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // найдем сумму чисел больше 5
            int result1 = Sum(integers, x => x > 5);

            Console.WriteLine(result1);
            Console.Read();
        }
        private static int Sum(int[] numbers, Operation oper)
        {
            int result = 0;
            foreach (int i in numbers)
            {
                if (oper(i))
                {
                    result += i;
                }
            }
            return result;
        }
    }
}
