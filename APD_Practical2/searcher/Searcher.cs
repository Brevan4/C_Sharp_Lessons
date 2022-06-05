using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * A class that owns an int array, and an index.  The array may, or may not be sorted.
 *
 * Implementing classes must implement a findElement method, which will return the kth largest
 * element in the array.
 */
namespace APD_Practical2.searcher
{
    public abstract class Searcher
    {
        public int[] array; // the array in which this Searcher object will search
        public int K; // this Searcher object searches for the kth largest entry in the array

        protected  Searcher(int[] array, int K) 
        {
            if (K <=0 || K > array.Length)
            {
                throw new IndexingError();
            }
            this.array = array;
            this.K = K;
        }

        protected Searcher(int[] array)
        {
            this.array = array;
        }

        /**
     * Get this Searcher's array
     * @return the array in which this Searcher searches
     */
        public int[] getArray()
        {
            return array;
        }
        /**
     * Get this Searcher's index.
     * @return the index this searcher is searching for.
     */
        int getIndex() { return K; }

        /**
     * Find the kth largest entry in the array
     * @return the kth largest element in the array
     * @throws IndexingError if the index, k, is out of bounds
     */
        abstract public int findElement();
    }
}
