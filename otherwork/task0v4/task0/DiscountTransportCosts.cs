using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task0
{
    class DiscountTransportCosts:IDiscount
    {
        private const int transportCosts = 450000;
            public double SetPrice(double price, int count)
            {
                return ((price*count) - transportCosts);
            }

            public override string ToString()
            {
            return string.Format("\t{0} BYR transport costs", transportCosts);
            }
    }
}
