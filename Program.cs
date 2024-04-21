using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Additional Calculator");

            Console.Write("Enter the first number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int result = a + b;

            Console.WriteLine("The total is: " + result);
            Console.WriteLine("\n\n  press the 'Enter' key to escape this window"); 

            Console.Read(); 
        }
    }
}
