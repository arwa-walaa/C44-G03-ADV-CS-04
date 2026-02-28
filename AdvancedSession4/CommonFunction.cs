using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedSession4
{
    internal class CommonFunction
    {
        #region Predicate
        //public static bool testNumber(int number){return number > 0;}


        #endregion

        #region FunC
        //public static string Cast(int number)
        //{
        //    return number.ToString();
        //}


        #endregion

        #region Action
        //nonGearic Action
        public static void Print()
        {
            Console.WriteLine("Hello from Action Delegate");
        }

        //Gereic Action
        public static void message(string msg)
        {
            Console.WriteLine($"Hello {msg}");
        }


        #endregion
    }

}
