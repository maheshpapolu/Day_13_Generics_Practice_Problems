using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class FindMaximum
    {
        public static int FindMaxInteger(int first, int second, int third) // Class Method to find maximum of three integer number
        {
            //Checking that first number is maximum or not
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0 || first.CompareTo(second) >= 0 && first.CompareTo(third) > 0 || first.CompareTo(second) > 0 && first.CompareTo(third) >= 0)
            {
                return first; // Retrun first as maximum
            }
            //Checking that second number is maximum or not
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0 || second.CompareTo(first) >= 0 && second.CompareTo(third) > 0 || second.CompareTo(first) > 0 && second.CompareTo(third) >= 0)
            {
                return second; // Retrun second as maximum
            }
            //Checking that third number is maximum or not
            if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0 || third.CompareTo(first) >= 0 && third.CompareTo(second) > 0 || third.CompareTo(first) > 0 && third.CompareTo(second) >= 0)
            {
                return third; // Retrun third as maximum
            }
            return first; // Return first if all the integer are same 
        }

        public static float FindMaxFloat(float first, float second, float third) // Class Method to find maximum of three float number
        {
            //Checking that first number is maximum or not
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0 || first.CompareTo(second) >= 0 && first.CompareTo(third) > 0 || first.CompareTo(second) > 0 && first.CompareTo(third) >= 0)
            {
                return first; // Retrun first as maximum
            }
            //Checking that second number is maximum or not
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0 || second.CompareTo(first) >= 0 && second.CompareTo(third) > 0 || second.CompareTo(first) > 0 && second.CompareTo(third) >= 0)
            {
                return second; // Retrun second as maximum
            }
            //Checking that third number is maximum or not
            if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0 || third.CompareTo(first) >= 0 && third.CompareTo(second) > 0 || third.CompareTo(first) > 0 && third.CompareTo(second) >= 0)
            {
                return third; // Retrun third as maximum
            }
            return first; // Return first if all the float number are same 
        }
    }
}
