using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APD_Practical1
{

    class BaseTypes
    {
        static bool bool1 = true;
        static bool bool2 = false;
        static char myChar1 = 'Z';
        static char myChar2 = '\\';
        static byte myByte = 100;
        static short myShort = 10000;
        static int myInt = 1000000;
        static long myLong = 10000000000L;
        static float myFloat = 3.14f;
        static double myDouble = 2.71828d;
        public static void BoolCast()
        {

            bool b1 = bool1;                    //Already bool
            bool b2 = bool2;                    //Already bool
            /*
            bool b3 = myChar1;                  //Cannot implicitly convert
            bool b4 = myChar2;                  //Cannot implicitly convert
            bool b5 = myByte;                   //Cannot implicitly convert
            bool b6 = myShort;                  //Cannot implicitly convert
            bool b6 = myInt;                    //Cannot implicitly convert
            bool b8 = myLong;                   //Cannot implicitly convert
            bool b8 = myFloat;                  //Cannot implicitly convert
            bool b9 = myDouble;                 //Cannot implicitly convert
            */
            Console.WriteLine($@"******** BoolCast ********
The only casts available for Booleans were b1 - {b1} and b2 - {b2}, which were already booleans.

");
        }

        public static void CharCast()
        {
            char c1 = myChar1;                  //Already char
            char c2 = myChar2;                  //Already char
            char c3 = (char)myByte;             //Explicit
            char c4 = (char)myShort;            //Explicit
            char c5 = (char)myInt;              //Explicit
            char c6 = (char)myLong;             //Explicit
            char c7 = (char)myFloat;            //Explicit
            char c8 = (char)myDouble;           //Explicit
            Console.WriteLine($@"******** CharCast ********
Implicit cast
c1 - {c1}
c2 - {c2} 
Explicit cast 
c3 - {c3}
c4 - {c4}
c5 - {c5}
c6 - {c6}
c7 - {c7}
c8 - {c8}

");
        }

        public static void IntCast()
        {
            int i1 = myChar1;                   //Implicit
            int i2 = myChar2;                   //Implicit
            int i3 = myByte;                    //Implicit
            int i4 = myShort;                   //Implicit
            int i5 = myInt;                     //Already int
            int i6 = (int)myLong;               //Explicit
            int i7 = (int)myFloat;              //Explicit
            int i8 = (int)myDouble;             //Explicit
            Console.WriteLine($@"******** IntCast ********
Implicit cast
i1 - {i1}
i2 - {i2}
i3 - {i3}
i4 - {i4}
i5 - {i5}
Explicit cast
i6 - {i6}
i7 - {i7}
i8 - {i8}

");
        }

        public static void LongCast()
        {
            long l1 = myChar1;                  //Implicit
            long l2 = myChar2;                  //Implicit
            long l3 = myByte;                   //Implicit
            long l4 = myShort;                  //Implicit
            long l5 = myInt;                    //Implicit
            long l6 = myLong;                   //Already long
            long l7 = (long)myFloat;            //Explicit
            long l8 = (long)myDouble;           //Explicit
            Console.WriteLine($@"******** LongCast ********
Implicit cast
l1 - {l1}
l2 - {l2}
l3 - {l3}
l4 - {l4}
l5 - {l5}
l6 - {l6}
Explicit cast
l7 - {l7}
l8 - {l8}

");
        }

        public static void FloatCast()
        {
            float f1 = myChar1;                 //Implicit
            float f2 = myChar2;                 //Implicit
            float f3 = myByte;                  //Implicit
            float f4 = myShort;                 //Implicit
            float f5 = myInt;                   //Implicit
            float f6 = myLong;                  //Implicit
            float f7 = myFloat;                 //Already float
            float f8 = (float)myDouble;         //Explicit
            Console.WriteLine($@"******** FloatCast ********
Implicit cast
f1 - {f1}
f2 - {f2}
f3 - {f3}
f4 - {f4}
f5 - {f5}
f6 - {f6}
f7 - {f7}.
Explicit cast
f8 - {f8}

");
        }
    }
}

