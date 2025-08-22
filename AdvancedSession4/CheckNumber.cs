using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedSession4
{
    internal class CheckNumber<T>
    {
        public static List<T> FindNumbers(List<T> numbers, numberCheckFunDelegate<T, bool> numberCheck)
        {
            List<T> Result = new List<T>();
            if (numbers is not null)
            {


                foreach (T number in numbers)
                {
                    if (numberCheck.Invoke(number))
                    {
                        Result.Add(number);
                    }
                }

            }
            return Result;
        }
    }
}
