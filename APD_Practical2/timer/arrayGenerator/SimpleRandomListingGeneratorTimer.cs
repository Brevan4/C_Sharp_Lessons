using APD_Practical2.arrayGenerator;
using APD_Practical2.timer.timer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APD_Practical2.timer.arrayGenerator
{
    class SimpleRandomListingGeneratorTimer : SimpleRandomListingGenerator, Timer
    {
        public SimpleRandomListingGeneratorTimer(int size) : base(size) { }
        /**
         * Cease timing when the runtime exceeds 5 seconds.
         *
         * @return 5 seconds as the maximum permitted runtime.
         */
        public long getMaximumRuntime() { return 5L; }

        /**
        * Cease timing when the array size exceeds 10^9.
        *
        * @return  10^9 as the maximum permitted array size.
        */
        public int getMaximumTaskSize() { return 1000000000; }

        /**
         * Start timing with an array size of 1.
         *
         * @return 1, as the initial array size.
         */
        public int getMinimumTaskSize() { return 1; }
        /**
         * We are timing CleverRandomListings.
         *
         * @param size the size of the task to be timed.
         * @return a CleverRandomListingGenerator of the required size.
         */
        public Timer getTimer(int size) { return new CleverRandomListingGeneratorTimer(size); }
        /**
         * We are timing the randomise() method.
         */
        public void timedMethod() { randomise(); }

        public static void Run()
        {
            SimpleRandomListingGeneratorTimer timer = new SimpleRandomListingGeneratorTimer(0);
            ((Timer)timer).timingSequence();
        }
    }
}