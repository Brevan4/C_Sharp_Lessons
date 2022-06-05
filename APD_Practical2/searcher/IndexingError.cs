using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APD_Practical2.searcher
{
 /**
 * Use to report index out of bounds errors
 */
    public class IndexingError : Exception
    {
        public IndexingError() : base("Index k out of bounds") { }
    }
}
