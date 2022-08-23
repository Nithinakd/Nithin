using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue my_queue = new Queue();

            my_queue.Enqueue("GFG");
            my_queue.Enqueue("Geeks");
            my_queue.Enqueue("GeeksforGeeks");
            my_queue.Enqueue("geeks");
            my_queue.Enqueue("Geeks123");

            Console.WriteLine("Total elements present in my_queue: {0}",
                                                        my_queue.Count);

           
            Console.WriteLine("Topmost element of my_queue"
                         + " is: {0}", my_queue.Dequeue());


            Console.WriteLine("Total elements present in my_queue: {0}",
                                                        my_queue.Count);

            Console.WriteLine("Topmost element of my_queue is: {0}",
                                                   my_queue.Peek());

            Console.WriteLine("Total elements present in my_queue: {0}",
                                                        my_queue.Count);
        }
    }
}
