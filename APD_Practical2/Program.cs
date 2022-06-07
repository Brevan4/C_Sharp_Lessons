using APD_Practical2.arrayGenerator;
using APD_Practical2.searcher;
using APD_Practical2.timer.arrayGenerator;
using APD_Practical2.timer.searcher;
using APD_Practical2.timer.timer;
using System;

namespace APD_Practical2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CheckGenerator checkGenerator = new CheckGenerator();
            checkGenerator.Run();

        }
    }
}