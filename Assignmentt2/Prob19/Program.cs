using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string c;
            int s = 100;
            Console.WriteLine("Enter 'HIT' or 'MISS':");
            for (int q = 0; q < 4; q++)
            {
                c = Console.ReadLine();
                if (c == "HIT" || c == "hit")
                {
                    s += 10;
                }
                else if (c == "MISS" || c == "miss")
                {
                    s -= 20;
                }
            }
            Console.WriteLine("Score: " + s);
        }
    }
}
