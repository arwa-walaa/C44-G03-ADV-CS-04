using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedSession4
{
    public delegate TResult numberCheckFunDelegate<in T, out TResult>(T item);
    internal class CheckNumbersCondition
    {
       

        public static bool CheckOdd(int number)
        {
           
            return  number % 2 !=0 ;
        }
        public static bool CheckEven(int number)
        {

            return number % 2 == 0;
        }

        public static bool CheckOddDouble(double number)
        {

            return number % 2 != 0;
        }
        public static bool CheckEvenDouble(double number)
        {

            return number % 2 == 0;
        }
    }
}
