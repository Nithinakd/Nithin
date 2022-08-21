using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number1, number2, temp;
            //Console.Write("\nInput the First Number : ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.Write("\nInput the Second Number : ");
            //number2 = int.Parse(Console.ReadLine());
            //temp = number1;
            //number1 = number2;
            //number2 = temp;
            //Console.Write("\nAfter Swapping : ");
            //Console.Write("\nFirst Number : " + number1);
            //Console.Write("\nSecond Number : " + number2);
            //Console.Read();
            int x = 10;
            int y = 5;

            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("After swapping: x = " + x
                              + ", y = " + y);
        }
    }
}
