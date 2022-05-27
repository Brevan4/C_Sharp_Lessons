nusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APD_Practical1
{

    class BaseTypes
    {
        //1) Remove comments and assign correct datatypes bellow.
        
        bool one = true;
        bool two = false;
        char three = 'Z';
        string four = '\\';
        int five = 100;
        int six = 10000;
        int seven = 1000000;
        long eight = 10000000000L;
        float nine = 3.14f;
        double ten = 2.71828d;


        // 2) Attempted to cast each into types of boolean, char, integer, long, float.
        //one
        int cast1 = one;
        char cast2 = one;
        long cast3 = one;
        float cast4 = one;

        //three
        bool cast5 = three;
        int cast6 = three;
        long cast7 = three;
        float cast8 = three;

        //four
        bool cast9 = four;
        int cast10 = four;
        long cast11 = four;
        float cast12 = four;
        char cast13 = four;

        //five
        bool cast14 = five;
        int cast15 = five;
        long cast16 = five;
        float cast17 = five;
        char cast18 = five;

        //eight
        bool cast14 = five;
        int cast15 = five;
        long cast16 = five;
        float cast17 = five;
        char cast18 = five;

        // Comment which type of casting is applicable Ie implicit, explicit Not possible  


        // add function to print each casting out
        static void printCast()
        {
            Console.WriteLine(cast1);
            Console.WriteLine(cast2);
            
        } 

    }
}
