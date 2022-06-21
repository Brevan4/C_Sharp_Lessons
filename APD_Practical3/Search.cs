using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APD_Practical3
{
    /*
    * Implements Sequential and Binary Search
    *
    */
    public class Search
    {
        /**
     * This method implements Sequential Search based on a given
     * value and array
     *
     * @param value An Integer value to search for
     * @param array An array of Integers
     * @return Index of the value within the array, -1 if not found
     */
        public static int sequentialSearch(int value, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].CompareTo(value) == 0)
                {
                    return i;
                }
            }
            return -1;
        }
        /**
             * This method implements Binary Search based on a given
             * value and array. Binary Search is called recursively
             * thus, bottom and top might be different in every call.
             *
             * @param bottom Current bottom within the array
             * @param top Current top within the array
             * @param value An Integer value to search for
             * @param array An array of Integers
             * @return Index of the value within the array, -1 if not found
             */
        public static int binarySearch(int bottom, int top, int value, int[] array)
        {
            if (bottom > top)
            {
                return -1;
            }
            else
            {
                int pivot = (bottom + top) / 2;
                if (value.CompareTo(array[pivot]) == 0)
                {
                    return pivot;
                }
                else if (value.CompareTo(array[pivot]) < 0)
                {
                    return binarySearch(bottom, pivot - 1, value, array);
                }
                else
                {
                    return binarySearch(pivot + 1, top, value, array);
                }
            }
        }

        /**
         * This method searches for a value within a given array.
         * However, the search algorithm depends of the properties of
         * the array. More specifically, Binary Search is applied on
         * sorted arrays, while Sequential Search is applied on random
         * (not sorted) arrays.
         *
         * @param value An Integer value to search for
         * @param array An array of Integers
         * @return Index of the value within the array, -1 if not found
         */
        public static int search(int value, int[] array)
        {
            // Implement search
            return -1;
        }

        /**
         * Run search for a given array and value
         *
         * @param args (ignored)
         */
        public static void main(String[] args)
        {
            int value = 2;
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int index = -1;

            Console.WriteLine("Searching value: " + value +
                    "\n\tin array: ");
            Array.ForEach(array, Console.Write);

            index = sequentialSearch(value, array);
            Console.WriteLine("Sequential Search: array[" + index + "] = " +
                    (index >= 0 ? array[index] : "?"));

            index = binarySearch(0, array.Length - 1, value, array);
            Console.WriteLine("Binary Search: array[" + index + "] = " +
                    (index >= 0 ? array[index] : "?"));

            index = search(value, array);
            Console.WriteLine("Search: array[" + index + "] = " +
                    (index >= 0 ? array[index] : "?"));
        }
    }
}