using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedSession4
{
    internal class CheckNumbersCondition
    {
        public delegate bool numberCheckFunDelegate (int item);

        public static bool CheckOdd(int number)
        {
           
            return  number % 2 !=0 ;
        }
        public static bool CheckEven(int number)
        {

            return number % 2 == 0;
        }
    }
}
