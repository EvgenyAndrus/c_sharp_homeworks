using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4
{
    class Triangle:Figure
    {
        private double a, b, c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Perimeter()
        {
            return (a+b+c);
        }

        public override double Square()
        {
            double p = Perimeter()/2;
            return Math.Sqrt(p*(p - a)*(p - b)*(p - c));
        }
    }
}
