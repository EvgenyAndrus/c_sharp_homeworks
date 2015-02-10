using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    static class StructType
    {
        internal static int a { get; set; }
        internal static int b { get; set; }
        internal static void Parse(string str)
        {
            string[] split = str.Split(",".ToCharArray());
            if (split.Length != 2)
                split = str.Split(" ".ToCharArray());
            if (split.Length != 2)
                throw new FormatException();
            try
            {
                a = int.Parse(split[0]);
                b = int.Parse(split[1]);
            }
            catch (FormatException)
            {
                throw new FormatException();
            }
        }
    }
}
