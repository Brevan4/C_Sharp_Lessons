using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
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
            //Stopwatch sw = new S
            var watch =  System.Diagnostics.Stopwatch.StartNew();
            timedMethod();
            watch.Stop();
            return watch.Elapsed;
        }

        /**
     * Run a sequence of time tests of increasing size. Task sizes of size 1,2,..,9,
     * then 10,20,..,90 and so on for increasing powers of ten are timed. The sequence of
     * tests terminates when the execution time of the randomisation reaches or
     * surpasses the time limit, or the size of the generator reaches or
     * surpasses the maximum size.
     * @throws IndexingError if one of the timed searches has an indexing error.
     *                          This should not happen.
     */

    public void timingSequence()
        {            
            Console.WriteLine("Timg Sequence was called");
            //NumberFormatInfo formatter = new CultureInfo("en-US", false).NumberFormat;
            //formatter.NumberDecimalDigits = 3;
            int counter = getMinimumTaskSize();
            int power = 1;
            while (counter >= 10)
            {
                counter = counter / 10;
                power = power * 10;
            }
            for (; ; power = power * 10)
            {
                for (; counter < 10; counter++)
                {
                    Timer timer = getTimer(counter * power);
                    TimeSpan time = timer.time();
                    string timeString = time.ToString();
                    Console.WriteLine(timer.GetType().Name + " took " + timeString + " for a task of size " + String.Format("{0:n0}", power * counter));
                    if (counter * power >= getMaximumTaskSize())
                    {
                        Console.WriteLine("Maximum task size, " + getMaximumTaskSize() + ", reached. Ending timing sequence. ");
                        return;
                    }
                    if (time.TotalSeconds >= getMaximumRuntime())
                    {
                        Console.WriteLine("Time limit of " + getMaximumRuntime() + " seconds reached. Ending the timing sequence.");
                        return;
                    }
                }            
                counter = 1;
            }
        }
    }
}
