using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task0
{
    public abstract class Item : IComparable<Item>
    {
        public string Name { get; private set; }
        public int Count { get; private set; }
        public int DayOfMonth { get; private set; }
        private static double Price = 1000000;

        public double TotalPrice
        {
            get
            {
                if (Discount == null)
                    return Price * Count;
                return  Discount.SetPrice(Price, Count);
            }
        }

        public IDiscount Discount { get; set; }
       
        protected Item(string name, int count, int date)
        {
            Name = name;
            Count = count;
            DayOfMonth = date;
        }

        protected Item(string name, int count, int date, IDiscount discount)
        {
            Name = name;
            Count = count;
            DayOfMonth = date;
            //Price = price;
            Discount = discount;
        }
        public int CompareTo(Item other)
        {
            return DayOfMonth.CompareTo(other.DayOfMonth);
        }
        public override string ToString()
        {
            string formatString = "{0,10}" + "{1,8}" + "{2,11} BYR" + "{3,12}" + "{4,17} BYR";
            return string.Format(formatString, Name, Count, Price, DayOfMonth, TotalPrice) + (Discount == null ? "\tNo discount" : Discount.ToString());
        }
    }
}
