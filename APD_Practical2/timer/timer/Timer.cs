using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APD_Practical2.timer.timer
{
    /**
 * We are interested in how long our implemented methods take to execute. This
 * interface defines a time method that can be used to time a given method in
 * implementing classes.  This is known as the <tt>timed method</tt>.
 *
 * Each main.java.timer.Timer object is expected to have some <tt>int</tt> measure of the "size" of
 * the task the timed method has to undertake.
 */
    public interface Timer
    {
        /**
     * Get a main.java.timer.Timer object with a task of the given size for the timed method.
     * @param size the size of the task to be timed.
     * @return a main.java.timer.Timer object with a task of that size
     * @throws IndexingError if one of the timed searcher has an indexing error.
     *                          This shouldn't happen.
     *
     */
        Timer getTimer(int size);

        /**
        * Nominate the timed method.  In an implementing class <tt>timedMethod</tt> will
        * be a wrapper method for the method to be timed.
        */
        void timedMethod();

        /**
        * A main.java.timer.Timer object should specify the maximum length of time that a time test should run
        * @return the maximum time that a single time test should run, in seconds
        */
        long getMaximumRuntime();

        /**
        * main.java.timer.Timer objects must also specify the minimum task size that they wish to see timed.
        * @return the maximum task size to be timed
        */
        int getMinimumTaskSize();

        /**
         * main.java.timer.Timer objects must also specify the maximum task size that they wish to see timed.
         * @return the maximum task size to be timed
         */
        int getMaximumTaskSize();

        /**
         * Run the timed method belonging to an implementing class, and time how
         * long it takes.
         *
         * @return the time taken to execute the method being timed, in nanoseconds
         */
        protected TimeSpan time()
        {
            long startTime = Stopwatch.GetTimestamp();
            timedMethod();
            long endTime = Stopwatch.GetTimestamp();
            return TimeSpan.FromMilliseconds(endTime - startTime);
        }
    }
}
