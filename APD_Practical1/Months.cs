using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APD_Practical1
{
    
    public enum Month                                       //Enum of months
        {
            January, February, March, April, May, June, July, August, September, October, November, December
        }
    class Months
    {
        public static void WhatMonth()                      //Method for user input
        {

            Console.WriteLine("Please enter the first 3 letters of any month of the year (eg. Jan, Feb, Mar): ");
            string userInput = Console.ReadLine();
            userInput = userInput.ToLower();
                                    
            switch (userInput)                              //Switch to select correct Enums and sentences
            {
                case "jan":
                    {
                        Console.WriteLine($"The first month of every year. It's {Month.January}.");
                    }
                    break;

                case "feb":
                    {
                        Console.WriteLine($"The shortest month of the year. It's {Month.February}.");
                    }
                    break;

                case "mar":
                    {
                        Console.WriteLine($"Heading forwards with a spring in your step. It's {Month.March}.");
                    }
                    break;

                case "apr":
                    {
                        Console.WriteLine($"Fools get to play, but for only half a day. It's {Month.April}.");
                    }
                    break;

                case "may":
                    {
                        Console.WriteLine($"Summer is right around the corner. It's {Month.May}.");
                    }
                    break;

                case "jun":
                    {
                        Console.WriteLine($"Happy Birthday to me and the boss. It's {Month.June}.");
                    }
                    break;

                case "jul":
                    {
                        Console.WriteLine($"Its marching season in my wee country. It's {Month.July}.");
                    }
                    break;

                case "aug":
                    {
                        Console.WriteLine($"Enjoy the last few weeks of your time off kids, back to school soon. It's {Month.August}.");
                    }
                    break;

                case "sep":
                    {
                        Console.WriteLine($"Do you remember? The 21st night of {Month.September}");
                    }
                    break;

                case "oct":
                    {
                        Console.WriteLine($"Time for some Halloween Spooktacular fun in {Month.October}");
                    }
                    break;

                case "nov":
                    {
                        Console.WriteLine($"Where I am from we burn bonfires in July, for normal people it's {Month.November}");
                    }
                    break;

                case "dec":
                    {
                        Console.WriteLine($"Holidays are coming, holidays are coming... It's {Month.December}.");
                    }
                    break;

                default:                                        //Default set as error for invalid user input
                    {
                        Console.WriteLine("Invalid month selected.");
                    }
                    break;
            }
        }
    }
}
