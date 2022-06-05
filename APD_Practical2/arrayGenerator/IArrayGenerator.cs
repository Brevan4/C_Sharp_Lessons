﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APD_Practical2.arrayGenerator
{
    /**
 * Defines the interface for classes that generate arrays of ints
 * <p>
 * The constructor for implementations of this class should generate an array of
 * ints
 * <p>
 * <i>This is an interface, and specifies the signature(s) of method(s) that
 * should be implemented in (a) <b>separate</b> class(es).</i>
 *
 * See the tester class for tests of this interface's properties.
 */
    public interface IArrayGenerator
    {
        /**
    * @return the array of ints generated by this ArrayGenerator
    */
        public int[] getArray();

        /**
         * @return the size of array generated by this generator
         */
        public int getSize();
    }
}
