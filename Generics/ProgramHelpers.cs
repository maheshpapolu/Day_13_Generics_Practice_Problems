using System;

namespace Generics
{
    internal static class ProgramHelpers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");

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
                    int maxInteger = FindMaximum.FindMaximum<int>.FindMax(first, second, third); // Calling generic mehthod of generic class having int data type with integer parameter and Storing value as maximum which is returned by Method
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
                    float maxFloat = FindMaximum.FindMaximum<float>.FindMax(f, s, t); //  Calling generic mehthod of generic class having float data type with float parameter and Storing value as maximum which is returned by Method
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
                    string maxString = FindMaximum.FindMaximum<string>.FindMax(a, b, c); // Calling generic mehthod of generic class having string data type with string parameter and Storing value as maximum which is returned by Method
                    Console.WriteLine($"Maximum string of ({a},{b},{c}) is : {maxString}");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Enter valid choice");
                    break;
            }

        }
    }
}