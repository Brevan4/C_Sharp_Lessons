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
        public enum Month
        {
            JAN, FEB, MAR, APR, MAY, JUN, JUL, AUG, SEP, OCT, NOV, DEC
        };

        public static void printCurrentMonth(Month currentMonth)
        {

            Console.Write("Current month is: ");

            switch (currentMonth)
            {
                case Month.JAN: Console.WriteLine("January"); break;
                case Month.FEB: Console.WriteLine("February"); break;
                case Month.MAR: Console.WriteLine("March"); break;
                case Month.APR: Console.WriteLine("April"); break;
                case Month.MAY: Console.WriteLine("May"); break;
                case Month.JUN: Console.WriteLine("June"); break;
                case Month.JUL: Console.WriteLine("July"); break;
                case Month.AUG: Console.WriteLine("August"); break;
                case Month.SEP: Console.WriteLine("September"); break;
                case Month.OCT: Console.WriteLine("October"); break;
                case Month.NOV: Console.WriteLine("November"); break;
                case Month.DEC: Console.WriteLine("December"); break;
                default: Console.WriteLine("Error!"); break;
            }
        }
        //2) create a function that takes a months e.g JAN and
        //prints out the full month name (maybe add a message such as "It is currently *month*)
    }
}
