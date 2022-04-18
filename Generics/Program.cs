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
                Console.WriteLine("Welcome to generics");

                Console.WriteLine("1.Find maximum of three Integer number\n2.Find maximum of three Float number");
                Console.WriteLine("3.Find maximum of string");
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
                        int maxInteger = FindMaximum.FindMax(first, second, third); // Calling generic mehthod with integer parameter and Storing value as maximum which is returned by Method
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
                        float maxFloat = FindMaximum.FindMax(f, s, t); //  Calling generic mehthod with float parameter and Storing value as maximum which is returned by Method
                        Console.WriteLine($"Maximum float number of ({f},{s},{t}) is : {maxFloat}");
                        Console.ReadLine();
                        break;
                    case 3:
                        string a, b, c;
                        //Get the 3 string from the user
                        Console.WriteLine("Enter first string : ");
                        a = Console.ReadLine();
                        Console.WriteLine("Enter second string : ");
                        b = Console.ReadLine();
                        Console.WriteLine("Enter third string : ");
                        c = Console.ReadLine();
                        string maxString = FindMaximum.FindMax(a, b, c); // Calling generic mehthod with string parameter and Storing value as maximum which is returned by Method
                        Console.WriteLine($"Maximum float number of ({a},{b},{c}) is : {maxString}");
                        Console.ReadLine();
                        break;

                }

            }
        }
    }
