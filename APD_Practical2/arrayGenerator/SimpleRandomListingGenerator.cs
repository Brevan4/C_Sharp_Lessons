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

            int[] Copy;
            bool[] Used;

            for(int i = 0; i < getArray().Length; i++)
            {
                int RandomIndex;

            }


        }
    }        
}
