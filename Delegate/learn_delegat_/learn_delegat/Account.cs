using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_delegat
{

    public delegate void AccountStateHandler(string mess);
    class Account
    {

        AccountStateHandler _del;


        public void RegisterHandler (AccountStateHandler del)
        {
            _del += del;
        }

        public void UnRegisterHandler(AccountStateHandler del)
        {
            _del -= del;
        }

        int _sum;

        public Account(int sum)
        {
            _sum = sum;
        }

        public int CurrentSum
        {
           get { return _sum; }
        }

        public void Put(int sum) 
        {
            _sum += sum;
        }

        public void Withdraw (int sum)
        { 
            if (sum < _sum)
            {
                _sum -= sum;
             if (_del != null)
                {
                    _del($"Сумма была снято со счета: {sum}");
                }
            }else if(_del != null)
                {
                _del($"Не достаточно денег на счете.");
                }
        }
    }
}
