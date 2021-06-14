using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_25
{
    public class Ticket<T>
    {
        public T Passenger { get; set; }

        public T Getpassenger()
        {
            return this.Passenger;
        }

        public int GetPrice()
        {
            var price = 100;
            if (typeof(T) == typeof(Animal))
            {
                price = price / 2;
            }
            return price;
        }
    }
}
