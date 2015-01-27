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
            Random rand = new Random();
            int[] arr = new int[30];
            for (int i = 0; i < arr.Count(); ++i)
            {
                arr[i] = rand.Next(-10, 10);
            }
            Console.WriteLine("введи число");
            int y = Convert.ToInt32(Console.ReadLine());
            PrintArr("Массив", arr);
            Console.WriteLine("число {0} встречается в массиве {1} раз", y, NumInArr(y, arr));
            Console.ReadLine();
        }
        static int NumInArr(int y, int[] arr)
        {
            int num = 0;
            foreach (int n in arr)
            {
                if (n == y)
                {
                    num++;
                }
            }
            return num;
        }
        static void PrintArr(string text, int[] arr)
        {
            Console.Write(text + ": ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
        }
    }
}