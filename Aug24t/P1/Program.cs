using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string author1 = "Hello";
            string author2 = "Hi";
            

           
            if (String.Equals(author1, author2))
                Console.WriteLine($"{author1} and {author2} have same value.");
            else
                Console.WriteLine($"{author1} and {author2} are different.");

        
        }
    }
}
