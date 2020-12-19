using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Olpers o = new Olpers();
            o.sell(5);

            Sugar s = new Sugar();
            s.sell(4);

            Console.ReadKey();

        }
    }
}
