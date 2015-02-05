using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    class Program
    {
       static void InfoStr(string str)
        {
           /*Общее количество символов*/
            Console.WriteLine("Общее количество символов: {0}", str.Count());
           /*В верхнем и нижнем регистре*/
            int upperRegister = 0;
            int lowerRegister = 0;
            int numbDigits = 0;
            int numSpaces = 0;
            int punctuation = 0;
            for (int i = 0; i < str.Count();i++ )
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    upperRegister++;
                }
                else if (str[i] >= 'a' && str[i] <= 'z')
                {
                    lowerRegister++;
                }
                /*количество цифр*/
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    numbDigits++;
                }
                /*количество пробелов*/
                else if (str[i] == ' ')
                {
                    numSpaces++;
                }
                else punctuation = str.Count() - (upperRegister + lowerRegister + numbDigits + numSpaces);
            }
            Console.WriteLine("Количество символов в верхнем регистре: {0}\nКоличество символов нижнем регистре: {1}\nКоличество цифр: {2}\nКоличество пробелов: {3}\nКоличество символов пунктуации: {4}", upperRegister, lowerRegister, numbDigits, numSpaces,punctuation);

        }
        static void Main(string[] args)
        {
            Console.Write("Введи строку: ");
            string str=Console.ReadLine();
            InfoStr(str);


            Console.Read();
        }
       
    }
}
