using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task0
{
    public class Computer : Item
    {
        public Computer(int count, int date, IDiscount discount)
            : base("NoteBook", count, date, discount)
        {
        }

        public Computer(int count, int date)
            : base("NoteBook", count, date)
        {
        }
    }
}
