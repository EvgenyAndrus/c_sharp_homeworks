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
            int[] arr = new int[10];
            for (int i = 0; i < arr.Count(); ++i)
            {
                arr[i] = rand.Next(-5,6);
            }
            PrintArr("массив", arr);
            Array.Sort(arr);
            PrintArr("преобразованный", arr);
            Console.ReadLine();
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
