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
            while (i < getSize())
            {
                int randomIndex = getRandomIndex();
                int origIndex = array[i];
                array[i] = array[randomIndex];
                array[randomIndex] = origIndex;
                i++;
            } 
        }      
    }    
}