using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_properties
{
    public class AccountEventArgs
    {
        public int Sum { get; }
        public string Massage  { get; }

        public AccountEventArgs(int sum,string massage)
        {
            Sum = sum;
            Massage = massage;
        }
    }
}
