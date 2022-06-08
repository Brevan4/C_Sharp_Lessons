using System;
using APD_Practical2.searcher;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APD_Practical2.searcher
{
    public class SimpleSearcher : Searcher
    {   
        
        public SimpleSearcher(int[] array, int K): base(array, K) { }
        public override int findElement()
        {
            int[] tempArray = getArray();
            Array.Copy(array, tempArray, getArray().Length);
            Array.Sort(tempArray);
            Array.Reverse(tempArray);

            // implement find element
            return tempArray[K - 1];
        }
    }
}
