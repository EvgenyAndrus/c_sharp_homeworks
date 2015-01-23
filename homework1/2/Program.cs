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
            int deposit = 1000;
            int k = 0;
            double s=deposit;
            Console.Write("Введи проценты по вкладу: ");
            double p= Convert.ToDouble(Console.ReadLine());
            while (s < 1100)
            {
                s *= 1 + p / 100;
                ++k;
            }
            Console.WriteLine("за {0} месяцев итоговый размер вклада составит {1}руб. ", k, s);

            Console.Read();
        }
    }
}
