using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stateless
{
    /// <summary>
    /// Hopefully Nothing else is called Tuple
    /// </summary>
    /// <typeparam name="TAgo0"></typeparam>
    /// <typeparam name="TArg1"></typeparam>
    public class Tuple<TAgo0, TArg1>
    {
        /// <summary>
        /// 
        /// </summary>
        public TAgo0 Item1 { get; }

        /// <summary>
        /// 
        /// </summary>
        public TArg1 Item2 { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item1"></param>
        /// <param name="item2"></param>
        public Tuple(TAgo0 item1, TArg1 item2)
        {
            Item1 = item1;
            Item2 = item2;
        }
    }
}
