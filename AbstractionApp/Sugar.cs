using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionApp
{
    class Sugar : Product
    {
        public Sugar()
        {
            name = "Deewan Sugar";
            price = 110;
        }

        public override void sell(int quantity)
        {
            Console.WriteLine("{0} Rs. {1}/kg {2}qty: Rs. {3}", name, price, quantity, (price * quantity));
        }
    }
}
