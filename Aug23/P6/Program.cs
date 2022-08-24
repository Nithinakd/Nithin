using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6
{
    enum departmentname
    {

  
       Purchase,
       Sales,
       Training,
       Accounts,

    }

    class Program
    {

       
        static void Main(string[] args)
        {

            
            Console.WriteLine("Purchase= " + (int)departmentname.Purchase);
            Console.WriteLine("Sales= " + (int)departmentname.Sales);
            Console.WriteLine( "Training= " + (int)departmentname.Training);
            Console.WriteLine( "Accounts =" + (int)departmentname.Accounts);
          
        }
    }
}