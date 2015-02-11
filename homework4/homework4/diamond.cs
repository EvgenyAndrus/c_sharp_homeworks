using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4
{
    class Diamond:Figure
    {
        private double a, alpha;// alpha - острый угол ромба

        public Diamond(double a, double alpha)
        {
            this.a = a;
            this.alpha = alpha;
        }

        public override double Perimeter()
        {
            return(4*a);
        }

        public override double Square()
        {
            return (a*a*Math.Sin(alpha));
        }
    }
}
