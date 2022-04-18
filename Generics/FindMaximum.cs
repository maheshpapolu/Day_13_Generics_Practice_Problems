using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class FindMaximum
    {
            // Creating generic Method to find maximum of three having any data type
        public static T FindMax<T>(T first, T second, T third) where T : IComparable
           
        {
            //Checking that first is maximum or not
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0 || first.CompareTo(second) >= 0 && first.CompareTo(third) > 0 || first.CompareTo(second) > 0 && first.CompareTo(third) >= 0)
            {
                return first; // Retrun first as maximum
            }
            //Checking that second is maximum or not
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0 || second.CompareTo(first) >= 0 && second.CompareTo(third) > 0 || second.CompareTo(first) > 0 && second.CompareTo(third) >= 0)
            {
                return second; // Retrun second as maximum
            }
            //Checking that third is maximum or not
            if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0 || third.CompareTo(first) >= 0 && third.CompareTo(second) > 0 || third.CompareTo(first) > 0 && third.CompareTo(second) >= 0)
            {
                return third; // Retrun third as maximum
            }
            return first; // Return first if all values are same 
        }
    }
}
