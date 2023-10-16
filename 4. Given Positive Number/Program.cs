using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Given_Positive_Number
{
    internal class Program
    {
        static bool IsMultipleOf3Or7(int number)
        {
            return (number % 3 == 0) || (number % 7 == 0);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Sample Input:");
            Console.Write("3: ");
            bool result1 = IsMultipleOf3Or7(3);
            Console.WriteLine(result1);

            Console.Write("14: ");
            bool result2 = IsMultipleOf3Or7(14);
            Console.WriteLine(result2);

            Console.Write("12: ");
            bool result3 = IsMultipleOf3Or7(12);
            Console.WriteLine(result3);

            Console.Write("37: ");
            bool result4 = IsMultipleOf3Or7(37);
            Console.WriteLine(result4);
            Console.ReadLine();
        }
    }
}
