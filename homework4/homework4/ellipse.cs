using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4
{
    class Ellipse:Figure
    {
        private double a, b;

       public Ellipse(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double Perimeter()
        {
            return (Math.PI*Math.Sqrt(2*(Math.Pow(a, 2) + Math.Pow(b, 2))));


        }

        public override double Square()
        {
            return (Math.PI*a*b);
        }
    }
}
