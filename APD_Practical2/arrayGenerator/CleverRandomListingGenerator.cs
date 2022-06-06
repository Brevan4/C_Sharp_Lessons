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
            Array.Clear(array, 0, getArray().Length);
            /*for (int i = 0; i < getArray().Length;)
            {
                int randomValue = getRandomIndex();
                if (!array.Contains(randomValue))
                { 
                    array[i] = randomValue;
                    i++;
                }
            } */
            bool[] used = new bool[getSize()];                      //Set up of "used" array
            for (int index = 0; index < getArray().Length;)
            {
                int randomIndex = getRandomIndex();
                if (used[randomIndex] == false)                     //if randomIndex of used array shows false, proceed
                {
                    array[index] = randomIndex;                      //Set index value to randomIndex value
                    used[randomIndex] = true;                       //Set value of used randomIndex to True
                    index++;                                        //Increment index by 1
                }
            }
        }      
    }    
}
