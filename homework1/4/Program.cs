using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 123456789;
            int n1 = n;
            int x = 0;
            while (n > 0)
            {
                if (n > 10)
                {
                    x += (n % 10);
                    x *= 10;
                    n = (n - n % 10) / 10;

                }
                else
                {
                    x += n;
                    n = 0;
                }
            }
            Console.WriteLine("Было число {0}, а стало {1}.", n1, x);
        }
    }
}
