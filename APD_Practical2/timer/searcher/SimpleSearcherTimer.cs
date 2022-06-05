using APD_Practical2.arrayGenerator;
using APD_Practical2.searcher;
using APD_Practical2.timer.timer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * A main.java.timer implementation for simple searchers that times the findElement method
 */
namespace APD_Practical2.timer.searcher
{
    class SimpleSearcherTimer : SimpleSearcher, Timer
    {
        // All timings will be done with an index of 5
        private static int K = 5;
        public SimpleSearcherTimer(int[] array) : base(array, K) { }       

        /**
* We are timing SimpleSearchers.
*
* @param size the size of the task to be timed.
* @return a SimpleSearcher of the required size.
*/
        public Timer getTimer(int size)
        {
            IArrayGenerator generator = new CleverRandomListingGenerator(size);
            return new SimpleSearcherTimer(generator.getArray());
        }
        /**
         * We are timing the findElement() method.
        */
        public void timedMethod()
        {
            try { findElement(); }
            catch(IndexingError indexingError)
            {
                // simply ignore indexing errors here
                // with K at 5, and a minimum task size (array size) of 10, indexing errors should not occur
                // during timing
            }
        }
        /**
         * Cease timing when the runtime exceeds 5 seconds.
         *
         * @return 5 seconds as the maximum runbtime.
         */
        public long getMaximumRuntime()
        {
            return 5L;
        }
        /**
         * Minimum task size (array size) is set to ten, to avoid indexing errors (index is always five).
         * @return minimum task size of ten
         */
        public int getMinimumTaskSize()
        {
            return 10;
        }
        /**
         * Cease timing when the array size exceeds 10^9
        *
         * @return 10^9 as the maximum array size.
        */
        public int getMaximumTaskSize()
        {
            return 1000000000;
        }
        /**
         * Run the sequence of timings specified by the methods above.
         *
         * @param args not usually used
        * @throws IndexingError should not happen
        */

        public static void RunSimpleSearchTimer() 
        {
            SimpleSearcherTimer timer = new SimpleSearcherTimer(new int[K]);
            ((Timer)timer).timingSequence();
        }

       
    }
}
