using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APD_Practical2.arrayGenerator
{
    /**
    * A simple array generator, that generates a sorted array [0,1,2,..,n-1]
    */
    public class SortedListingGenerator : IListingGenerator
    {
        protected int[] array;
    /**
     * Create an array of ints of size <tt>size</tt>, and populate it
     * with the values 0..<tt>size</tt>-1.
     *
     * @param size the size of the array to be created
     */

        public SortedListingGenerator(int size)
        {
            array = new int[size];//create the array
            {
                for(int index = 0; index < array.Length; index++)
                {
                    array[index] = index;
                }
            }
        }
    /**
     * Get this ArrayGenerator's array.
     *
     * @return the array created by this ArrayGenerator
     */
    public int[] getArray(){return array;}
    /**
     * Get the size of this ArrayGenerator's array.
     *
     * @return the size of the array
     */
    public int getSize() { return array.Length; }
    }
}
