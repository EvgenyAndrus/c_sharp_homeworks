using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4
{
    class Rectangle:Figure
    {
        private double a, b;

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double Perimeter()
        {
            return (2*(a + b));
        }

        public override double Square()
        {
            return (a*b);
        }
    }
}
