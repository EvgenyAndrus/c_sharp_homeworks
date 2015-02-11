using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4
{
    class Parallelogram:Figure
    {
        private double a, b, alpha;

        public Parallelogram(double a, double b, double alpha)
        {
            this.a = a;
            this.b = b;
            this.alpha = alpha;
        }

        public override double Perimeter()
        {
            return (2*(a + b));
        }

        public override double Square()
        {
            return (a*b*Math.Sin((alpha*Math.PI)/180));//угол в градусах
        }
    }
}
