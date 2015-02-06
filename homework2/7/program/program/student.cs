using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    public enum mark { programming, administration, design };

    class Student
    {
        private string firstName;
        private string lastName;
        private string patronymic;//отчество
        private string group;
        private int age;
        private int[][] marks;

        private int filledPr = 0;
        private int filledAd = 0;
        private int filledDe = 0;
        #region konstruktor
        public Student(string firstN, string lastN, string patr, string gr, int a)
        {
            firstName = firstN;
            lastName = lastN;
            patronymic = patr;
            group = gr;
            age = a;
            marks = new int[3][];
            marks[(int)mark.programming] = new int[100];
            marks[(int)mark.administration] = new int[70];
            marks[(int)mark.design] = new int[90];
        }
        #endregion
        public void printStudent()
        {
            Console.WriteLine("Имя: {0}\nФамилия: {1}\nОтчество: {2}\nГруппа: {3}\nВозраст: {4}\n", firstName, lastName, patronymic, group, age);
        }
        #region printMarks
        public void printMarks()
        {
            Console.WriteLine("Оценки по програмированию: ");
            for (int j = 0; j < filledPr; j++)
                Console.Write(" {0}", marks[(int)mark.programming][j]);
            Console.Write("\n");
            Console.WriteLine("Оценки по Администрираванию: ");
            for (int j = 0; j < filledAd; j++)
                Console.Write(" {0}", marks[(int)mark.administration][j]);
            Console.Write("\n");
            Console.WriteLine("Оценки по дизайну: ");
            for (int j = 0; j < filledDe; j++)
                Console.Write(" {0}", marks[(int)mark.design][j]);
            Console.Write("\n");
        }
        #endregion
        #region setMark
        public void setMark(mark lesson)
        {
            int m;
            switch (lesson)
            {
                case mark.programming:
                    Console.WriteLine("Введи оценку: ");
                    m = Convert.ToInt32(Console.ReadLine());
                    marks[(int)mark.programming][filledPr] = m;
                    filledPr++;
                    break;
                case mark.administration:
                    Console.WriteLine("Введи оценку: ");
                    m = Convert.ToInt32(Console.ReadLine());
                    marks[(int)mark.administration][filledAd] = m;
                    filledAd++;
                    break;
                case mark.design:
                    Console.WriteLine("Введи оценку: ");
                    m = Convert.ToInt32(Console.ReadLine());
                    marks[(int)mark.design][filledDe] = m;
                    filledDe++;
                    break;
            }
        }
        #endregion
        #region menu
        public void menu()
        {
            int lesson;
            do
            {
                Console.WriteLine("По какому предмету ставим оценку? ");
                Console.WriteLine("\t\t\t\t 1 - Програмирование ");
                Console.WriteLine("\t\t\t\t 2 - Администриравание ");
                Console.WriteLine("\t\t\t\t 3 - Дизайн ");
                lesson = Convert.ToInt32(Console.ReadLine());
                switch (lesson)
                {
                    case 1:
                        setMark(mark.programming);
                        break;
                    case 2:
                        setMark(mark.administration);
                        break;
                    case 3:
                        setMark(mark.design);
                        break;
                    default:
                        Console.WriteLine("Не верный ввод");
                        break;
                }
            } while (lesson < 1 || lesson > 3);
        }
        #endregion
        #region menuAverage
        public void menuAverage()
        {
            int lesson;
            do
            {
                Console.WriteLine("По какому предмету показать средний бал? ");
                Console.WriteLine("\t\t\t\t 1 - Програмирование ");
                Console.WriteLine("\t\t\t\t 2 - Администриравание ");
                Console.WriteLine("\t\t\t\t 3 - Дизайн ");
                lesson = Convert.ToInt32(Console.ReadLine());
                switch (lesson)
                {
                    case 1:
                        aver(mark.programming);
                        break;
                    case 2:
                        aver(mark.administration);
                        break;
                    case 3:
                        aver(mark.design);
                        break;
                    default:
                        Console.WriteLine("Не верный ввод");
                        break;
                }
            } while (lesson < 1 || lesson > 3);
        }
        #endregion
        #region aver
        public void aver(mark lesson)
        {
            switch (lesson)
            {
                case mark.programming:
                    double pr = 0;
                    for (int i = 0; i < filledPr; i++)
                    {
                        pr += marks[(int)mark.programming][i];
                    }
                    Console.WriteLine("Средний бал по програмированию: {0}", (pr / filledPr));
                    break;

                case mark.administration:
                    double ad = 0;
                    for (int i = 0; i < filledAd; i++)
                    {
                        ad += marks[(int)mark.administration][i];
                    }
                    Console.WriteLine("Средний бал по администрированию: {0}", (ad / filledAd));
                    break;

                case mark.design:
                    double de = 0;
                    for (int i = 0; i < filledDe; i++)
                    {
                        de += marks[(int)mark.design][i];
                    }
                    Console.WriteLine("Средний бал по дизайну: {0}", (de / filledDe));
                    break;
                default:
                    Console.WriteLine("Не верный ввод");
                    break;
            }
        }
        #endregion
    }
}
