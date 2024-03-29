using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APD_Practical2.arrayGenerator
{
    /**
     * An array generator that generates an array containing the values 0..n in
     * random order. This is achieved by using SortedListingGenerator, that
     * generates a sorted listing, and then randomising the array.
     * This abstract class does not specify how the contents of the
     * array are randomised - this must be implemented in concrete extensions of
     * this class.
     */
    public abstract class RandomListingGenerator : SortedListingGenerator
    {
        /**
         * Generate an array containing elements in a random order
         *
         * @param size the size of the array to be generated
         */   

        public RandomListingGenerator(int size) : base(size)
        {            
            randomise();
        }

        private Random random = new Random();

        /**
         * Randomise the order of the elements in the array
         */
        protected abstract void randomise();

    /**
     * A utility to provide a random index within the range of indices of the
     * array generated by this array generator.
     *
     * @return an integer index between 0 and <tt>size</tt>-1 inclusive, where
     *         <tt>size</tt> is the size of the array generated by this array
     *         generator.
     */

        protected int getRandomIndex()
        {
            return random.Next(getArray().Length);
        }
    }
}