using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4
{
    class Keystone:Figure//трапеция
    {
        private double a, b, c, d;
        public Keystone(double a, double b, double c, double d)
        {
            this.a = a;//3
            this.b = b;//7
            this.c = c;//4
            this.d = d;//5
        }

        public override double Perimeter()
        {
            return (a + b + c + d);
        }

        public override double Square()
        {
            return (((a + b)/2)*(Math.Sqrt((c*c) - (Math.Pow((((b-a)*(b-a) + c*c - d*d) / (2*(b-a))) ,2)))));
        }
    }
}
