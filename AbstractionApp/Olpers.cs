using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionApp
{
    class Olpers : Product
    {
        public Olpers()
        {
            name = "Olpers Milk";
            price = 145;
        }

        public override void sell(int quantity)
        {
            Console.WriteLine("{0} Rs. {1}/ltr {2}qty: R. {3}", name, price, quantity, (price * quantity));
        }
    }
}
