using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Введи размер стороны А:");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введи размер стороны B:");
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введи размер стороны квадрата C:");
            c = Convert.ToInt16(Console.ReadLine());

            if (a > c || b > c)
            {
                int aX = a / c;//cколько квадратов поместится по стороне А.
                int bY = b / c;//cколько квадратов поместится по стороне B.
                int aRest = a % c;//cколько места осталось по стороне А.
                int bRest = b % c;//cколько места осталось по стороне B.

                Console.WriteLine("количество квадратов в прямоугольнике = {0} \n", aX * bY);
                Console.WriteLine("площадь незанятой части прямоугольника = {0} \n", aRest * b + bRest * (a - aRest));
            }
            else Console.WriteLine("Квадрат со стороной {0} не вмещается в прямоугольник со сторонами {1} и {2} \n", c, a, b);
            Console.Read();
        }
    }
}
