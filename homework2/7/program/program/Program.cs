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
            Student st1 = new Student("Evgeny", "Andrus", "Viktorovich", "P32013", 34);
            int x;
            do
            {
            Console.WriteLine("1 - Добавить оценку");
            Console.WriteLine("2 - Посмотреть оценки");
            Console.WriteLine("3 - Посмотреть средний бал");
            Console.WriteLine("4 - Данные по студенту");
            Console.WriteLine("0 - Выход");
            x = Convert.ToInt32( Console.ReadLine());
                switch (x)
                {
                    case 1:
                        st1.menu();
                        break;
                    case 2:
                        st1.printMarks();
                        break;
                    case 3:
                        st1.menuAverage();
                        break;
                    case 4:
                        st1.printStudent();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Не верный ввод");
                        break;
                }
            } while (x != 0);
            Console.Read();
        }
    }
}
