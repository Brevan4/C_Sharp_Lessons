using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APD_Practical2.arrayGenerator
{
    public class CleverRandomListingGenerator : RandomListingGenerator
    {
        public CleverRandomListingGenerator(int size) : base(size) { }

        protected override void randomise()
        {
            int[] tempArray = getArray();
            for (int index = 0; index < getArray().Length;)
            {
                int randomIndex = getRandomIndex();
                if (used[randomIndex] == false)                     //if randomIndex of used array shows false, proceed
                {
                    array[index] = randomIndex;                     //Set index value to randomIndex value
                    used[randomIndex] = true;                       //Set value of used randomIndex to True
                    index++;                                        //Increment index by 1
                }
            }
        }      
    }    
}
