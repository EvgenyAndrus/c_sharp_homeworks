using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace task0
{
    class Program
    {
        public static void Main(string[] args)
        {
#region set purchases
            List<Item> list = new List<Item>()
            {
                new Computer(2, 21),
                new Computer(4, 10, new PercentDiscont()),
                new Computer(1, 17, new PercentDiscont()),
                new Computer(3, 1),
                new Computer(1, 2, new TransportCostsDiscount()),
                new Computer(1, 12, new BonusDiscount()),
                new Computer(1, 10),
                new Computer(7, 30, new BonusDiscount()),
                new Computer(1, 23, new TransportCostsDiscount()),
                new Computer(7, 10, new TransportCostsDiscount()),
                new Computer(5, 17, new PercentDiscont())
            };
#endregion
            StreamWriter file = File.CreateText("result.txt");
            file.Close();
            
            ToFile(file,list, Find10Day(list));

            Show(list,Find10Day(list));
            list.Sort();
            ToFile(file, list, txt:"\nAfter sorting by date:");
           

            Console.WriteLine("\nAfter sorting by date:");
           


            Show(list);
      
            Console.WriteLine("\nAfter sorting by type discount:\n");
            Show(DiscountType(list));
            ToFile(file, DiscountType(list), "\nAfter sorting by type discount:\n");
           
            Console.ReadKey();
             
        }

#region Metods
        private static IEnumerable<IGrouping<string, Item>> DiscountType(List<Item> list )
        {
            var groupBy = list.GroupBy(item => item.Discount != null ? item.Discount.GetType().Name : "No discount")
                .OrderBy(g => g.Key == "BonusDiscount")
                .ThenBy(g => g.Key == "TransportCostsDiscount")
                .ThenBy(g => g.Key == "PercentDiscont")
                .ThenBy(g => g.Key == "No discount");
            return groupBy;
        }
        private static int Find10Day(List<Item> list)
        {
            int k = 0;
            foreach (var item in list)
            {
                if (item.DayOfMonth == 10)
                    k++;
            }
            return k;
        }
        private static void Show(IEnumerable<IGrouping<string, Item>> groupBy)
        {
            foreach (var v in groupBy)
            {
                foreach (var item in v)
                {
                    Console.WriteLine(item);
                }
            }
        }
        private static void Show(List<Item> list,int k=0)
        {
            Console.WriteLine("\n{0,10} {1,7} {2,14} {3,17} {4,14} {5,22}\n", "Name", "Count", "Price", "Day Of month", "Total price", "Discont");
           foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            if (k != 0) Console.WriteLine("\nThere was {0} purchase(s) at 10th of this month", k);
        }
#endregion

        private static void ToFile(StreamWriter file, IEnumerable<IGrouping<string, Item>> groupBy, string txt = "")
        {
            file = File.AppendText("result.txt");
            if (txt.Any()) file.WriteLine(txt);
            using (file)
            {
                foreach (var v in groupBy)
                {
                    foreach (var item in v)
                    {
                        file.WriteLine(item);
                    }
                }
            }
            file.Close();
        }
        
        
        private static void ToFile(StreamWriter file,List<Item> list, int k = 0, string txt="")
        {
            file = File.AppendText("result.txt");
            using (file)
            {
                if (txt.Any()) file.WriteLine(txt);
                file.WriteLine("\n{0,10} {1,7} {2,14} {3,17} {4,14} {5,22}\n", "Name", "Count", "Price", "Day Of month",
                    "Total price", "Discont");
                foreach (var item in list)
                {
                    file.WriteLine(item);
                }
                if (k != 0) file.WriteLine("\nThere was {0} purchase(s) at 10th of this month", k);
                
            }
            file.Close();
        }
    }
}