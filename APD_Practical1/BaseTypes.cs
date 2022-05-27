using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APD_Practical1
{

    class BaseTypes
    {
        //1) Remove comments and assign correct datatypes bellow.

        bool aBool = true;
        bool bBool = false;
        char aChar = 'Z';
        char bChar = '\\';
        int aInt = 100;
        int bInt = 10000;
        int cInt = 1000000;
        long aLong = 10000000000L;
        float aFloat = 3.14f;
        double aDouble = 2.71828d;

        public void RunBaseTypes()
        {
            char[] aCharArray = { aChar, bChar, (char)aInt, (char)bInt, (char)cInt, (char)aLong, (char)aFloat,(char)aDouble};
            int[] aIntArray = { aChar, bChar, (int)aInt, (int)bInt, (int)cInt, (int)aLong, (int)aFloat, (int)aDouble };
            long[] aLongArray = { aChar, bChar, (long)aInt, (long)bInt, (long)cInt, (long)aLong, (long)aFloat, (long)aDouble };
            float[] aFloatArray = { aChar, bChar, (float)aInt, (float)bInt, (float)cInt, (float)aLong, (float)aFloat, (float)aDouble };
            double[] aDoubleArray = { aChar, bChar, (double)aInt, (double)bInt, (double)cInt, (double)aLong, (double)aFloat, (double)aDouble };

            Console.Write("This is the Char Array: ");
            printer(aCharArray);
            Console.Write("This is the Int Array: ");
            printer(aIntArray);
            Console.Write("This is the Long Array: ");
            printer(aLongArray);
            Console.Write("This is the Float Array: ");
            printer(aFloatArray);
            Console.Write("This is the Double Array: ");
            printer(aDoubleArray);

        }
        private void printer<T>(T[] rhsArray)
        {
            foreach (T element in rhsArray)
            {
                Console.Write($"{element}, ");
            }
            Console.WriteLine("");
        }

        public void otherPrinter<T>(T[] rhsArray)
        {
            Console.Write("This is the Char Array: ");
            printer(CharArray);
            Console.Write("This is the Int Array: ");
            printer(IntArray);
            Console.Write("This is the Long Array: ");
            printer(LongArray);
            Console.Write("This is the Float Array: ");
            printer(FloatArray);
            Console.Write("This is the Double Array: ");
            printer(DoubleArray);
        }

        char[] CharArray =
        {
            'Z',
            '\\',
            (char)100,
            (char)10000,
            //(char)1000000,// cannot explicitly cast
            //(char)10000000000L,// can't explicitly cast
            (char)3.14f,
            (char)2.71828d,
        };

        int[] IntArray =
        {
            'Z',
            '\\',
            100,
            10000,
            1000000,
            //(int)10000000000L, Doesn't allow explict cast
            (int)3.14f,
            (int)2.71828d,
        };
        long[] LongArray =
        {
            'Z',
            '\\',
            100,
            10000,
            1000000,
            10000000000L,
            (long)3.14f,
            (long)2.71828d,
        };
        float[] FloatArray =
        {
            'Z',
            '\\',
            100,
            10000,
            1000000,
            10000000000L,
            3.14f,
            (float)2.71828d,
        };
        double[] DoubleArray =
       {
            'Z',
            '\\',
            100,
            10000,
            1000000,
            10000000000L,
            3.14f,
            2.71828d,
        };

        // 2) Attempted to cast each into types of boolean, char, integer, long, float.
        // Comment which type of casting is applicable Ie implicit, explicit Not possible  


        // add function to print each casting out
    }
}
