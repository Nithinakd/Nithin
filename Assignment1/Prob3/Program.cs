using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 25;
            int num2 = 4;
            int result;
            result = num1 + num2;
            Console.WriteLine("value is {0}", result);
            result = num1 - num2;
            Console.WriteLine("Value is {0}", result);
            result = num1 * num2;
            Console.WriteLine("Value is {0}", result);
            result = num1 / num2;
            Console.WriteLine("Value is {0}", result);
            result = num1 % num2;
        
            Console.WriteLine("Value is {0}", result);
            Console.ReadLine();
        }
    }
}
