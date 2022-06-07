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
            int i = 0;  
            while (i < getSize())                                   //While i is less than size of array
            {
                int randomIndex = getRandomIndex();                 //randomIndex is equal to random number
                int origIndex = array[i];                           //origIndex is a temp var set up for holding original array position
                array[i] = array[randomIndex];                      //array[i] changes to new array position of random number
                array[randomIndex] = origIndex;                     //random position becomes original position
                i++;                                                //increment i by one
            } 
        }      
    }    
}