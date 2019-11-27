using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covariance_and_contravariance
{
    class CoContraVariance
    {
        //Этот метод возвращает объект класса X и имеет объект класса X в качестве параметра
        static X IncrA(X obj)
        {
            X temp = new X();
            temp.val = obj.val + 1;
            return temp;
        }

        //Этот метод возвращает объект класса Y и имеет объект класса Y в качестве параметра
        static Y IncrB(Y obj)
        {
            Y temp = new Y();
            temp.val = obj.val + 1;
            return temp;
        }

        public class Program
        {
            delegate X ChageIt(Y obj);
            static void Main(string[] args)
            {
                Y yob = new Y();
                ChageIt chage = IncrA;
                X xob = chage(yob);

                Console.WriteLine("Xob: {0}", xob.val);

                ChageIt change = IncrB;
                yob = (Y)change(yob);

                Console.WriteLine("Yob:{0}",yob.val);


            }
        }


    }
}
