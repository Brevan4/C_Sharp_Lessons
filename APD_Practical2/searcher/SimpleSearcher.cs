using System;
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
            // implement find element
            throw new IndexingError();
        }
    }
}
