using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extion
{
    public delegate void BookHedler(object sender, AllBookArgs allBook );

   // public event BookHedler EvBook;
    class AllBook
    {
        public event BookHedler _EvBook;
        public event BookHedler EvBook
        {
            add
            {
                _EvBook += value;

                Console.WriteLine($"{value.Method.Name} добавлены");
            }
            remove
            {
                _EvBook -= value;

                Console.WriteLine($"{value.Method.Name} удалены");
            }
        }

        public void AddBook(int number,string name)
        {
            _EvBook?.Invoke(this, new AllBookArgs(name, $"Добавлена парития книжек '{name}'", number));
        }

        public void TakeBook(int number, string name)
        {
            _EvBook?.Invoke(this, new AllBookArgs(name, $"Партия книжка взята {name}", number));
        }

         
      

    }

    
}
