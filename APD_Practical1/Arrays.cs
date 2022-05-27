using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APD_Practical1
{
    class Arrays
    {
        // The two starting arrays of 10 integers
        int[] A = { 124, 117, 478, 786, 111, 325, 422, 145, 523, 33 };
        int[] B = { 8, 9, 17, 4, 68, 56, 38, 77, 81, 2 };

        // Bellow function should divid each corresponding index of A by B storing them as doubles in a new array.
        //It should print out:
        //The Average of all values
        // The Total Sum of all Values
        //The Smallest value
        //The Largest value
        public void processArrays()
        {
            double[] C = { };
            double average;
            double sum;
            double smallest = 10000000;
            double largest = -10000000;

            for (int i = 0, i <= A.Length, i++)
            {
                C[i] = A[i] / B[i];
            }

            //sum
            for (int i = 0, i <= A.Length, i++)
            {
                sum = sum + C[i] 
            }
            //average
            average = sum / C.Length;

            //smallest value
            foreach (double i in C)
            {
                if (i < smallest)
                {
                    smallest = i;
                }
            }

            //largest value
            foreach (double i in C)
            {
                if (i < smallest)
                {
                    smallest = i;
                }
            }

            Console.WriteLine("The average is " + average);
            Console.WriteLine("The sum is " + sum);
            Console.WriteLine("The smallest is" + smallest);
            Console.WriteLine("The largest is" + largest);
        }
    }
}
