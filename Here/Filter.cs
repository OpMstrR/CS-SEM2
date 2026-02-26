using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    class Filter
    {
        public delegate bool FilterPredicate(int cyfra);


        internal static void FilterArray(int[] numbers, FilterPredicate predicate)
        {
            foreach (int x in numbers)
            {
                if (predicate(x))
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
