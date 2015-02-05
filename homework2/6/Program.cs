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
            string str;
            string symbol;
            Console.Write("Введи строку: "); str=Console.ReadLine();
            Console.Write("Введи символ: "); symbol = Console.ReadLine();
            if (str.Contains(symbol))
            {
                str=str.Replace(symbol,symbol.ToUpper());
                Console.WriteLine("Строка после смены регистра символа: {0}", str);
                str = str.Remove(str.LastIndexOf(symbol.ToUpper()));
                Console.WriteLine("Строка после удаления последнего вхождения символа: {0}", str);
           }
            else Console.WriteLine("Символ: {0} не входит в строку: {1}", symbol, str);

            Console.Read();
        }
    }
}
