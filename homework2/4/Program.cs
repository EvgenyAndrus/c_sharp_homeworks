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
            /*Создание*/
            int[,] mass = new int[3, 5];
            /*Заполнение*/
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    mass[i, j] = rand.Next(0, 10);
                }
            }
            /*вывод на экран*/
            Console.WriteLine("Массив до смены столбцов\n");
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write(mass[i, j] +" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("какие столбцы менять?");
            int n, m;
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            /*Замена столбцов*/
            int[,] tempMass = (int[,])mass.Clone();
            //Console.WriteLine("n={0} m={1}",n,m);

            
                for (int i = 0; i < mass.GetLength(0); i++)
                {
                    mass[i, n] = tempMass[i, m];
                    mass[i, m] = tempMass[i, n];                
                }

                /*вывод на экран после смены сталбцов*/
                Console.WriteLine("Массив после смены столбцов\n");
                for (int i = 0; i < mass.GetLength(0); i++)
                {
                    for (int j = 0; j < mass.GetLength(1); j++)
                    {
                        Console.Write(mass[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            
            Console.Read();

        }
    }
}
