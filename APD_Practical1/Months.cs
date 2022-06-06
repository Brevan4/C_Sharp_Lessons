using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APD_Practical1
{
    class Months
    {
        //1) create Enum for months e.g JAN, FEB ect
        enum Month
        {
            JAN, FEB, MAR, APR, MAY, JUN, JUL, AUG, SEP, OCT, NOV, DEC
        }

        //2) create a function that takes a Month e.g JAN and
        //prints out the full month name (maybe add a message such as "It is currently *month*)
        static void PrintMonth(Month m)
        {
            switch (m)
            {
                case Month.JAN:
                    Console.WriteLine("It is currently January");
                    break;
                case Month.FEB:
                    Console.WriteLine("It is currently February");
                    break;
                case Month.MAR:
                    Console.WriteLine("It is currently March");
                    break;
                case Month.APR:
                    Console.WriteLine("It is currently April");
                    break;
                case Month.MAY:
                    Console.WriteLine("It is currently May");
                    break;
                case Month.JUN:
                    Console.WriteLine("It is currently June");
                    break;
                case Month.JUL:
                    Console.WriteLine("It is currently July");
                    break;
                case Month.AUG:
                    Console.WriteLine("It is currently August");
                    break;
                case Month.SEP:
                    Console.WriteLine("It is currently September");
                    break;
                case Month.OCT:
                    Console.WriteLine("It is currently October");
                    break;
                case Month.NOV:
                    Console.WriteLine("It is currently November");
                    break;
                case Month.DEC:
                    Console.WriteLine("It is currently December");
                    break;
            }
        }
    }
}