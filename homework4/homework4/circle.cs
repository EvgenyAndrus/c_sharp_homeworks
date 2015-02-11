using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4
{
    class Circle:Figure
    {
        private double r;

        public Circle(double r)
        {
            this.r = r;
        }

        public override double Perimeter()
        {
            return (2*Math.PI*r);
        }

        public override double Square()
        {
            return (Math.PI*Math.Pow(r, 2));
        }
    }
}
