using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APD_Practical2.arrayGenerator
{
    /**
 * This is an auxiliary class for checking generators
 *
 */
    class CheckGenerator
    {
        public static void Run()
        {
            int size = 10;
            IArrayGenerator generator;

            Console.WriteLine("Print SortedListingGenerator: ");
            for (int i = 0; i < 15; i++)
            {
                generator = new SortedListingGenerator(size);
                Console.WriteLine(Print.Array(generator.getArray(), generator.getSize()));
            }

            Console.WriteLine("");
            Console.WriteLine("Print SimpleRandomListingGenerators: ");
            for (int i = 0; i < 15; i++)
            {
                generator = new SimpleRandomListingGenerator(size);
                Console.WriteLine(Print.Array(generator.getArray(), generator.getSize()));
            }
            Console.WriteLine("");
            Console.WriteLine("Print CleverRandomListingGenerators: ");
            for (int i = 0; i < 15; i++)
            {
                generator = new CleverRandomListingGenerator(size);
                Console.WriteLine(Print.Array(generator.getArray(), generator.getSize()));
            }
        }
    }
}