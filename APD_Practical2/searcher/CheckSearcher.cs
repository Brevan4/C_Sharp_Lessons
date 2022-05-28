using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APD_Practical2.arrayGenerator;
namespace APD_Practical2.searcher
{
    //This is an auxiliary class for checking searchers
    class CheckSearcher
    {
        public void RunCheckSearcher()
        {
            int size = 10;
            int index = 3; // kth largest element

            IArrayGenerator generator;

            Console.WriteLine("Search SortedListingGenerators: ");
            for(int i = 0; i < 15; i++)
            {
                generator = new SortedListingGenerator(size);
                Console.WriteLine(Print.Array(generator.getArray(), generator.getSize()));
                Searcher searcher = new SimpleSearcher(generator.getArray(), index);
                Console.WriteLine(Print.Ordinal(index) + " largest element: " + searcher.findElement());
            }
            Console.WriteLine("");

            Console.WriteLine("Search SimpleRandomListingGenerators: ");
            for (int i = 0; i < 15; i++)
            {
                generator = new SimpleRandomListingGenerator(size);
                Console.WriteLine(Print.Array(generator.getArray(), generator.getSize()));
                Searcher searcher = new SimpleSearcher(generator.getArray(), index);
                Console.WriteLine(Print.Ordinal(index) + " largest element: " + searcher.findElement());
            }
            Console.WriteLine("");

            Console.WriteLine("Search CleverRandomListingGenerator: ");
            for (int i = 0; i < 15; i++)
            {
                generator = new CleverRandomListingGenerator(size);
                Console.WriteLine(Print.Array(generator.getArray(), generator.getSize()));
                Searcher searcher = new SimpleSearcher(generator.getArray(), index);
                Console.WriteLine(Print.Ordinal(index) + " largest element: " + searcher.findElement());
            }            
        }
    }
}
