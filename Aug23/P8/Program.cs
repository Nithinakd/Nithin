using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8
public class Example
{
    public static void Main()
    {
        int number1 = 3000;
        int number2 = 0;
        try
        {
            Console.WriteLine(number1 / number2);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Division of {0} by zero.", number1);
        }
    }
}
}