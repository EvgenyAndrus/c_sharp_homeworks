using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите А и В через запятую или пробел");
            try
            {
                Parse.parse(Console.ReadLine());
            }
            catch (FormatException exc)
            {
                Console.WriteLine(exc.Message);
                Console.ReadLine();
                return;
            }
            Console.WriteLine("{0} * X + {1} * Y = 0", Parse.a, Parse.b);
            Console.ReadLine();
        }
    }
}
