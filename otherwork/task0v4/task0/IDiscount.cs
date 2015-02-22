using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task0
{
    public interface IDiscount
    {
        double SetPrice(double price, int count);
    }
}
