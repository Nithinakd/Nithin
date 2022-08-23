using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hashtable numberNames = new Hashtable();
            numberNames.Add(1, "One"); 
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");

           
            foreach (DictionaryEntry kvp in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
        }
    }
}
