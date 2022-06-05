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
            int[] copy = getArray();
            for(int index = 0; index < copy.Length; index++)
            {                        
                int randomIndex = getRandomIndex();
                if (index != randomIndex)
                {
                    copy[randomIndex] = copy[index] + copy[randomIndex];
                    copy[index] = copy[randomIndex] - copy[index];
                    copy[randomIndex] = copy[randomIndex] - copy[index];
                }
            }            
        }      
    }    
}
