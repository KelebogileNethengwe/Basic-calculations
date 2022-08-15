using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1, value2;
            
            Console.WriteLine("Basic Mathematical calculations");

            Console.WriteLine("Enter your first Value:");
            value1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second value: ");
            value2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Addition: " + (value1 + value2));
            Console.WriteLine("Subtraction: " + (value1 - value2));
            Console.WriteLine("Multiplication: " + value1 * value2);
            Console.WriteLine("Division: " + (value1/value2));

            Console.ReadLine();
        }
    }
}
