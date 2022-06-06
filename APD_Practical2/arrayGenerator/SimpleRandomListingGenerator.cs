using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APD_Practical2.arrayGenerator
{
    public class SimpleRandomListingGenerator : RandomListingGenerator
    {
        public SimpleRandomListingGenerator(int size) : base(size) { }

        protected override void randomise()
        {
            int[] copy = new int[getSize()];                        //Set up of "copy" array
            bool[] used = new bool[getSize()];                      //Set up of "used" array
            for (int index = 0; index < getArray().Length;)
            {
                int randomIndex = getRandomIndex();
                if (used[randomIndex] == false)                     //if randomIndex of used array shows false, proceed
                {
                    copy[index] = randomIndex;                      //Set index value to randomIndex value
                    used[randomIndex] = true;                       //Set value of used randomIndex to True
                    index++;                                        //Increment index by 1
                }
            }
            Array.Copy(copy, array, getSize());                     //Copy the array "copy" to "array"
        }
    }   
}
