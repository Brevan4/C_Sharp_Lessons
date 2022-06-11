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
            // please implement your simple random functoin here

            int[] copy = new int[getSize()];
            bool[] used = new bool[getSize()];

            for(int i = 0; i < getArray().Length; i++)
            {
                int randomIndex;
                randomIndex = getRandomIndex();

                while (used[randomIndex] == true) //could use do/while loop instead
                {
                    randomIndex = getRandomIndex();
                }
                

                copy[i] = randomIndex;
                used[randomIndex] = true;
                i++;
            }

            foreach(int i in getArray())
            {
                getArray()[i] = copy[i];
            }


        }
    }        
}
