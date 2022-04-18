using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class FindMaximum<T> where T : IComparable // Creating a generic class
    {
        public static T[] SortValue(T[] arr) // creating generic method to sort the values in ascending order
        {
            Array.Sort(arr); // Sorting values
            return arr; // return sorted array
        }
        public static T FindMax(params T[] arr)// Creating generic Method to find maximum of three having any data type
        {
            var sorted_values = SortValue(arr); // Calling Sortvalue generic method to sort value
            return sorted_values[sorted_values.Length - 1]; // Returning last element as a Maximum
        }

    }
}
