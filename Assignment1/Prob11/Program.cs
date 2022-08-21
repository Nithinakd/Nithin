using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nullStr = null;
           
            Console.WriteLine(String.IsNullOrEmpty(nullStr));
            string str = "Hello";
            
            Console.WriteLine(String.IsNullOrEmpty(str));


        }
    }
}
