using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 8, 3, 5, -1, 2 };

            Array.Sort(arr);
            if (arr.Length > 0)
            {
                Console.WriteLine("Minimum number is " + arr[0]);
                Console.WriteLine("Maximum number is " + arr[arr.Length - 1]);
            }
        }
    }
}
