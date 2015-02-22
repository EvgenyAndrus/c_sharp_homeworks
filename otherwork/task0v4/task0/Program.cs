using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task0
{
    static class Program
    {
        static void Main(string[] args)
        {

            List<Item> list = new List<Item>()
            {
                new Computer(2, 21),
                new Computer(4, 10, new PercentDiscont()),
                new Computer(1, 17, new PercentDiscont()),
                new Computer(3, 1),
                new Computer(1, 2, new DiscountTransportCosts()),
                new Computer(1, 12, new BonusDiscount()),
                new Computer(1, 10),
                new Computer(7, 30, new BonusDiscount()),
                new Computer(1, 23, new DiscountTransportCosts()),
                new Computer(5, 17, new PercentDiscont())
            };

            Console.WriteLine("\n{0,10} {1,7} {2,14} {3,17} {4,14} {5,22}\n", "Name", "Count", "Price", "Day Of month", "Total price","Discont");
            int k = 0;

            foreach (var item in list)
            {
                Console.WriteLine(item);
                if (item.DayOfMonth == 10)
                    k++;
            }
            Console.WriteLine();
            Console.WriteLine("There was {0} purchase(s) at 10th of this month", k);

            list.Sort();
            Console.WriteLine();
            Console.WriteLine("After sorting by date:");
            

            foreach (var item in list)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine();
            Console.WriteLine("After sorting by type discount:");
            var groupBy = list.GroupBy(x => x.Discount != null ? x.Discount.GetType().Name : "No discount").ToList();

              foreach (var v in groupBy)
              {
                foreach (var item in v)
                      {
                          if (v.Key == "No discount")
                          {
                              Console.WriteLine(item);
                          }
                      }
                      foreach (var item in v)
                      {
                          if (v.Key == "PercentDiscont")
                          {
                              Console.WriteLine(item);
                          }
                      }
                      foreach (var item in v)
                      {
                          if (v.Key == "DiscountTransportCosts")
                          {
                              Console.WriteLine(item);
                          }
                      }
                      foreach (var item in v)
                      {
                          if (v.Key == "BonusDiscount")
                          {
                              Console.WriteLine(item);
                          }
                      }
                  
                  //Console.WriteLine();
              }
          
            Console.ReadKey();
        }
    }
}
