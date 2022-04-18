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

            Console.WriteLine("1. Find maximum of three Integer number\n2.Find maximum of three Float number");
            Console.WriteLine("Enter your choice : ");
            int ch = Convert.ToInt32(Console.ReadLine());   // Storing user's choice
            switch (ch)
            {
                case 1:
                    int first, second, third;
                    //Get the 3 integers from the user
                    Console.WriteLine("Enter first integer number : ");
                    first = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second integer number : ");
                    second = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter third integer number : ");
                    third = Convert.ToInt32(Console.ReadLine());
                    int maxInteger = FindMaximum.FindMaxInteger(first, second, third); // Storing value as maximum which is returned by Method
                    Console.WriteLine($"\nMaximum integer number of ({first},{second},{third}) is : {maxInteger}");
                    break;

                case 2:
                    float f, s, t;
                    //Get the 3 float number from the user
                    Console.WriteLine("Enter first float number : ");
                    f = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second float number : ");
                    s = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter third float number : ");
                    t = float.Parse(Console.ReadLine());
                    float maxFloat = FindMaximum.FindMaxFloat(f, s, t); // Storing value as maximum which is returned by Method
                    Console.WriteLine($"Maximum float number of ({f},{s},{t}) is : {maxFloat}");
                    Console.ReadLine();
                    break;
            }

        }
    }
}
