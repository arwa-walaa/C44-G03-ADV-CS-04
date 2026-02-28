using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedSession4
{
    //public delegate bool SortingTypesFunctionDelgate(int a, int b);
    public delegate TResult SortingTypesFunctionDelgate<in T,out TResult>(T a, T b);
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

        //sort string
        public static bool SortStrAsc(string a, string b)
        {
            return a.Length > b.Length;
        }

        public static bool SortStrDesc(string a, string b)
        {
            return a.Length < b.Length;
        }
    }
}
