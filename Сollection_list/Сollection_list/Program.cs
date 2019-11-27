using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Сollection_list
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(3.4);
            list.Add(12);
            list.AddRange(new string[] { "Hello", "World!" });
            list.AddRange(new object[] { "sssss" ,233,123.123});

            foreach(object o in list)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("------");
            list.RemoveRange(4,3);
            list.Reverse();
            for (int i = 0; i < list.Count; i++) {
                Console.WriteLine(list[i]);
            }
            Console.ReadLine();
        }
    }
}
