using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extion
{
    public class AllBookArgs
    {
        public string Name { get;  }
        public string Mess { get;  }
        public int AmountBook { get;  }
        public AllBookArgs(string name, string mess, int amountBook)
        {
            Name = name;
            Mess = mess;
            AmountBook = amountBook;
        }

    }
}
