using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the dividend");
            int.TryParse(Console.ReadLine(), out int dividend);

            Console.WriteLine("Enter the divisor");
            int.TryParse(Console.ReadLine(), out int divisor);

            Console.WriteLine(Divide(dividend, divisor));
        }

        static int Divide(int dividend, int divisor)
        {
            try
            {
                return dividend / divisor;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by 0");
                throw; 
            }
        }
    }
}