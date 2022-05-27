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
        double[] C = new double[10];

        //The Average of all values
        // The Total Sum of all Values
        //The Smallest value
        //The Largest value
        public void processArrays()
        {
            double Total = 0.0d;
            double Smallest = (double)A[0]/B[0];
            double Largest = (double)A[0]/B[0];
            for(int i = 0; i < 10; i++)
            {
                C[i] = (double) A[i] / B[i];
                Total += C[i];
                if (C[i] < Smallest) { Smallest = C[i]; }
                if(C[i] > Largest) { Largest = C[i]; }                

            }
            Console.WriteLine($"Total of C is:  {Total}");
            Console.WriteLine($"Average of C is: {Total / 10}");
            Console.WriteLine($"Smallest in C is: {Smallest}");
            Console.WriteLine($"Largest in C is: {Largest}");
        }
    }
}
