using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APD_Practical1
{
    
    public enum Month
        {
            January, February, March, April, May, June, July, August, September, October, November, December
        }
    class Months
    {
        public static void WhatMonth()
        {

            Console.WriteLine("Please enter the first 3 letters of any month of the year (eg. Jan, Feb, Mar): ");
            string userInput = Console.ReadLine();
                                    
            switch (userInput)
            {
                case "Jan":
                    {
                        Console.WriteLine($"The first month of every year, {Month.January}");
                    }
                    break;

                case "Feb":
                    {
                        Console.WriteLine($"The shortest month of the year,{Month.February}");
                    }
                    break;

                case "Mar":
                    {
                        Console.WriteLine($"Heading forwards with a spring in your step, {Month.March}");
                    }
                    break;

                case "Apr":
                    {
                        Console.WriteLine($"Fools get to play, but for only half a day. {Month.April}");
                    }
                    break;

                case "May":
                    {
                        Console.WriteLine($"Summer is right around the corner, {Month.May}");
                    }
                    break;

                case "Jun":
                    {
                        Console.WriteLine($"Happy Birthday to me and the boss, {Month.June}");
                    }
                    break;

                case "Jul":
                    {
                        Console.WriteLine($"Its marching season in my wee country, {Month.July}");
                    }
                    break;

                case "Aug":
                    {
                        Console.WriteLine($"Enjoy the last few weeks of your time off kids, back to school soon. {Month.August}");
                    }
                    break;

                case "Sep":
                    {
                        Console.WriteLine($"Do you remember? The 21st night of {Month.September}");
                    }
                    break;

                case "Oct":
                    {
                        Console.WriteLine($"Time for some Halloween Spooktacular fun in {Month.October}");
                    }
                    break;

                case "Nov":
                    {
                        Console.WriteLine($"Where I am from we burn bonfires in July, for normal people its {Month.November}");
                    }
                    break;

                case "Dec":
                    {
                        Console.WriteLine($"Holidays are coming, holidays are coming...{Month.December}");
                    }
                    break;

                default:
                    {
                        Console.WriteLine("Invalid month selected.");
                    }
                    break;
            }
        }
    }
}
