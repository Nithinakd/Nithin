using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b;
            Console.WriteLine("Enter an Integer:");
            b = Convert.ToInt32(Console.ReadLine());
            switch (b)
            {
                case 0:
                    Console.WriteLine("{0} is zero.", b);
                    break;
                case int n when n % 2 != 0 && b < 100:
                    Console.WriteLine("{0} is odd.", b);
                    break;
                case int n when n % 2 == 0 && b < 100:
                    Console.WriteLine("{0} is even.", b);
                    break;
                case int n when n % 10 == 0 && b < 100:
                    Console.WriteLine("{0} is multiple of 10.", b);
                    break;
                case int n when n > 100:
                    Console.WriteLine("{0} is too large.", b);
                    break;
                default:
                    break;
            }
        }
    }
}
