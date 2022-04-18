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

            Console.WriteLine("1.Find maximum of three Integer number\n2.Find maximum of three Float number");
            Console.WriteLine("3.Find maximum of string");
            Console.WriteLine("Enter your choice : ");
            int ch = Convert.ToInt32(Console.ReadLine());   // Storing user's choice
            switch (ch)
            {
                case 1:
                    //Get the 3 integers from the user
                    Console.WriteLine("In how many numbers you want to find maximum : ");
                    int ci = Convert.ToInt32(Console.ReadLine());
                    int[] intArr = new int[ci]; // Creating a array to store integer
                    Console.WriteLine("Add integer one by one : ");
                    for (int i = 0; i < intArr.Length; i++)
                    {
                        intArr[i] = Convert.ToInt32(Console.ReadLine()); // Storing integers in array which is given by user
                    }
                    FindMaximum<int>.printValue(intArr); // Calling generic mehthod of generic class having int data type to print maximum value
                    break;

                case 2:
                    //Get the float numbers from the user
                    Console.WriteLine("In how many numbers you want to find maximum : ");
                    int cf = Convert.ToInt32(Console.ReadLine());
                    float[] floatArr = new float[cf]; // Creating a array to store float number
                    Console.WriteLine("Add float one by one : ");
                    for (int i = 0; i < floatArr.Length; i++)
                    {
                        floatArr[i] = float.Parse(Console.ReadLine()); // Storing float numbers in array which is given by user
                    }
                    FindMaximum<float>.printValue(floatArr); // Calling generic mehthod of generic class having float data type to print maximum value
                    break;
                case 3:
                    //Get the multiple string from the user
                    Console.WriteLine("In how many numbers you want to find maximum : ");
                    int cs = Convert.ToInt32(Console.ReadLine());
                    string[] stringArr = new string[cs]; // Creating a array to store string
                    Console.WriteLine("Add string one by one : ");
                    for (int i = 0; i < stringArr.Length; i++)
                    {
                        stringArr[i] = Console.ReadLine(); // Storing string in array which is given by user
                    }
                    FindMaximum<string>.printValue(stringArr); // Calling generic mehthod of generic class having string data type to print maximum value
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Enter valid choice");
                    break;
            }
            Console.ReadLine();
        }
    }
}
