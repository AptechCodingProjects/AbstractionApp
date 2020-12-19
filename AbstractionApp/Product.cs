using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionApp
{
    abstract class Product
    {
        protected string name;
        protected int price;

        public abstract void sell(int quantity);

        public virtual void discount()
        {
            Console.WriteLine("Discount");
        }
    }
}
