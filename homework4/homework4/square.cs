using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4
{
    class Box:Figure
    {
        private double a;

        public Box(double a)
        {
            this.a = a;
        }

        public override double Perimeter()
        {
            return (4*a);
        }

        public override double Square()
        {
            return (a*a);
        }
    }
}
