using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedSession4
{
    public delegate bool SortingTypesFunctionDelgate(int a, int b);
    internal class StortingTypes
    {
        public static bool CompareGreaterThan(int a, int b)
        {
            return a > b;
        }

        public static bool CompareLessThan(int a, int b)
        {
            return a < b;
        }
    }
}
