using APD_Practical2.arrayGenerator;
using APD_Practical2.timer.searcher;
using System;

namespace APD_Practical2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CheckGenerator checker = new CheckGenerator();
            checker.RunCheckerGenerator();
           
        }
    }
}
