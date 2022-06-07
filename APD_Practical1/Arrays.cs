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
        public static void ProcessArrays()
        {
            int arrayDivision;
            int i = 0;

            double[] C = new double[10];                                                //Creates Array of 10
            for (i = 0; i < A.Length; i++)                                              //For loop 
            {
                arrayDivision = A[i] / B[i];                                            //Sum required - A / B
                C[i] = arrayDivision;
            }
            {
                Console.WriteLine("\n\n******** Array C ********");
                Array.ForEach(C, Console.WriteLine);                                    //Prints out entire Array C
            }
        }
        public static void PrintArrays()                                                //Method to print our Array details
        {
            Console.WriteLine("\n\n******** Array details ********");
            Console.WriteLine("The average of array A: " + A.Average());
            Console.WriteLine("The highest value in array A: " + A.Max());
            Console.WriteLine("The lowest value in array A: " + A.Min());
            Console.WriteLine("The sum of all values in array A: " + A.Sum());
            Console.WriteLine("The average of array B: " + B.Average());
            Console.WriteLine("The highest value in array B: " + B.Max());
            Console.WriteLine("The lowest value in array B: " + B.Min());
            Console.WriteLine("The sum of all values in array B: " + B.Sum());
        }
    }
    }
}