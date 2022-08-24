using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String str = "Welcome to the world of C# Programming";

            String[] spearator = { "# " };
            Int32 count = 1;

            
            String[] strlist = str.Split(spearator, count,
                   StringSplitOptions.RemoveEmptyEntries);

            foreach (String s in strlist)
            {
                Console.WriteLine(s);
            }
        }
    }
}
