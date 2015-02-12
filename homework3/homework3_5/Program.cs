using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Russia.moskow.getPop() > Germany.Berlin.getPop())
            {
                if (Russia.moskow.getPop() > France.Paris.getPop())
                    Console.WriteLine("В Москве население больше чем в Берлине и Париже");

            }
            else if (Germany.Berlin.getPop() > Russia.moskow.getPop())
            {
                if (Germany.Berlin.getPop() > France.Paris.getPop())
                    Console.WriteLine("В Берлине население больше чем в Москве и Париже");
            }
            else Console.WriteLine("В Париже население больше чем в Москве и Берлине");
            Console.Read();
        }
    }
}
