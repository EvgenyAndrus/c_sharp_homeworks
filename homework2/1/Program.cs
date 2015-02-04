using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] mass = new int[10];
            for (int i = 0; i < mass.Count(); i++)
            {
                mass[i] = rand.Next(0, 5);
            }
            Console.WriteLine("массив до сжатия");

            for (int i = 0; i < mass.Count(); i++)
            {
                Console.Write(mass[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("массив после сжатия");
            int countNull = 0;
            for (int i = 0, j = 0; i < mass.Count(); i++)
            {
                if (mass[i] == 0)
                {
                    countNull++;
                    j = i;
                    while (mass[j] == 0)
                    {
                        if (j < mass.GetUpperBound(0)) j++;
                        else break;
                    }
                    mass[i] = mass[j];
                    mass[j] = 0;
                }
            }
            if (countNull > 0)
            {
                for (int i = 0; i < mass.Count(); i++)
                {
                    if (mass[i] == 0) mass[i] = -1;
                    Console.Write(mass[i] + " ");
                }
            }
            if (countNull == 0)
                Console.WriteLine("\nнет нулей в массиве");
            Console.ReadLine();
        }
    }
}
