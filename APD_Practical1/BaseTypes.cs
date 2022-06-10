using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APD_Practical1
{

    class BaseTypes
    {

        static void Casting()
        {
            //1) Remove comments and assign correct datatypes bellow.
            bool One = true;
            bool Two = false;
            char Three = 'Z';
            char Four = '\\';
            int Five = 100;
            int Six = 10000;
            int Seven = 1000000;
            long Eight = 10000000000L;
            float Nine = 3.14f;
            double Ten = 2.71828d;

            // 2) Attempted to cast each into types of boolean, char, integer, long, float.
            //bool
            //bool cast19 = Six;
            //bool cast5 = Three;
            //bool cast9 = Four;
            //bool cast14 = Five;

            //integer
            //int cast1 = One;
            int cast6 = Three;
            int cast10 = Four;
            int cast15 = Five;
            int cast20 = Six;

            //char
            //char cast2 = One;
            char cast13 = Four;
            char cast18 = (char) Five;
            char cast23 = (char) Six;

            //long
            //long cast3 = One;
            long cast7 = Three;
            long cast11 = Four;
            long cast16 = Five;
            long cast21 = Six;

            //float
            //float cast4 = One;
            float cast8 = Three;
            float cast12 = Four;
            float cast17 = Five;
            float cast22 = Six;

        }
        

        // Comment which type of casting is applicable Ie implicit, explicit Not possible  


        // add function to print each casting out
        static void printCast<T>() //ask alex for help
        {
            //Console.WriteLine(cast1);
            //Console.WriteLine(cast2);
            //look at generic methods

            char[] charArray =
            {
                Three, Four, 
            }; 

        }
    }
}