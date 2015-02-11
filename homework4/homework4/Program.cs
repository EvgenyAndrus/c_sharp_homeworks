using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure tr, re, sq, dia, pa, ke, ci, el;
            tr=new Triangle(2,3,4);
            re=new Rectangle(2,5);
            sq=new Box(3);
            dia=new Diamond(5,45);
            pa=new Parallelogram(3,4,33);
            ke=new Keystone(3,7,4,5);
            ci=new Circle(11);
            el=new Ellipse(4,7);

            Console.WriteLine("периметр треугольника: {0}",tr.Perimeter());
            Console.WriteLine("площадь треугольника: {0}", tr.Square());
            Console.WriteLine("периметр прямоугольника: {0}", re.Perimeter());
            Console.WriteLine("площадь прямоугольника: {0}", re.Square());
            Console.WriteLine("периметр квадрата: {0}", sq.Perimeter());
            Console.WriteLine("площадь квадрата: {0}", sq.Square());
            Console.WriteLine("периметр ромба: {0}", dia.Perimeter());
            Console.WriteLine("площадь ромба: {0}", dia.Square());
            Console.WriteLine("периметр параллелограмма: {0}", pa.Perimeter());
            Console.WriteLine("площадь параллелограмма: {0}", pa.Square());
            Console.WriteLine("периметр трапеции: {0}", ke.Perimeter());
            Console.WriteLine("площадь трапеции: {0}", ke.Square());
            Console.WriteLine("периметр круга: {0}", ci.Perimeter());
            Console.WriteLine("площадь круга: {0}", ci.Square());
            Console.WriteLine("периметр элипса: {0}", el.Perimeter());
            Console.WriteLine("площадь элипса: {0}", el.Square());
            


            Console.Read();
        }
    }
}
