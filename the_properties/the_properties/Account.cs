using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_properties
{
   // public delegate void AccountHadler(object sender, AccountEventArgs e);

 
    class Account
    {
        public delegate void AccountHadler(object sender, AccountEventArgs e);
        public event AccountHadler Notify;       // Событие обЪявлено
        public int Sum { get; private set; }

        public Account (int sum)
        {
            Sum = sum;

        }
      public void Put (int sum)
        {
            Sum += sum;
            Notify?.Invoke(this,new AccountEventArgs(Sum, $"Сумма { sum } добавлена до счета"));
           
        }

        public void Take(int sum)
        {
            if (Sum > sum)
            {
                Sum -= sum;
                Notify?.Invoke(this, new AccountEventArgs(Sum, $"Сумма { sum } снята со счета"));
            }
        }

    }
}
