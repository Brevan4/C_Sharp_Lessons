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
        static int[] A = { 124, 117, 478, 786, 111, 325, 422, 145, 523, 33 };
        static int[] B = { 8, 9, 17, 4, 68, 56, 38, 77, 81, 2 };
        
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
                Console.WriteLine("******** Array C ********");
                Array.ForEach(C, Console.WriteLine);                                    //Prints out entire Array C
            }
        }          
        public static void PrintArrays()                                                //Method to print our Array details
            {
            Console.WriteLine(@"******** Array details ********");
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

