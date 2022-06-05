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

            int[] copy = getArray();
            bool[] used = new bool [getSize()];

            for(int index = 0; index < getArray().Length;)
            {
                int randomIndex = getRandomIndex();
                if(used[randomIndex] == false)
                {
                    copy[randomIndex] = index;
                    used[randomIndex] = true;
                    index++;
                }                
            }
        }        
    }        
}
