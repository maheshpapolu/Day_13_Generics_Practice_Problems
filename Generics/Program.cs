using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            //Get the 3 integers from the user
            Console.WriteLine("Enter first integer number : ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second integer number : ");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third integer number : ");
            int third = Convert.ToInt32(Console.ReadLine());
            int maxValue = FindMaximum.FindMaxInteger(first, second, third); // Storing value as maximum which is returned by Method
            Console.WriteLine($"Maxium integer of ({first},{second},{third}) is : {maxValue}");
            Console.ReadLine();
        }
    }
}

