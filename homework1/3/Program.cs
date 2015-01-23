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
            int a = 1, b = 11;
            int x = a;
            do
            {
                for (int i = 0; i < x; i++)
                {
                    Console.Write("{0} ", x);
                }
                x++;
                Console.Write("\n\n");
            } while (x <= b);
            


        }
    }
}
