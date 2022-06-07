using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APD_Practical1
{
    class Months
    {
        public enum Month                                       //Enum of months
        {
            JAN, FEB, MAR, APR, MAY, JUN, JUL, AUG, SEP, OCT, NOV, DEC
        }

        public static void WhatMonth()                      //Method for user input
        {

            Console.WriteLine("Please enter the first 3 letters of any month of the year (eg. JAN, FEB, MAR...): ");
            string userInput = Console.ReadLine();
            userInput = userInput.ToUpper();
            Month month = Enum.Parse<Month>(userInput);
            switch (month)                              //Switch to select correct Enums and sentences
            {
                case Month.JAN: { Console.WriteLine("The first month of every year. It's January."); } break;
                case Month.FEB: { Console.WriteLine("The shortest month of the year. It's February."); } break;
                case Month.MAR: { Console.WriteLine("Heading forwards with a spring in your step. It's March."); } break;
                case Month.APR: { Console.WriteLine("Fools get to play, but for only half a day. It's April."); } break;
                case Month.MAY: { Console.WriteLine("Summer is right around the corner. It's May."); } break;
                case Month.JUN: { Console.WriteLine("Happy Birthday to me and the boss. It's June."); } break;
                case Month.JUL: { Console.WriteLine("Its marching season in my wee country. It's July."); } break;
                case Month.AUG: { Console.WriteLine("Enjoy the last few weeks of your time off kids, back to school soon. It's August."); } break;
                case Month.SEP: { Console.WriteLine("Do you remember? The 21st night of September."); } break;
                case Month.OCT: { Console.WriteLine("Time for some Halloween Spooktacular fun in October"); } break;
                case Month.NOV: { Console.WriteLine("Where I am from we burn bonfires in July, for normal people it's November."); } break;
                case Month.DEC: { Console.WriteLine("Holidays are coming, holidays are coming... It's December."); } break;
                default: { Console.WriteLine("Invalid month selected."); } break;
            }
        }
    }
}
