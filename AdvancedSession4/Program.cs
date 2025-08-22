using static AdvancedSession4.CheckNumbersCondition;

namespace AdvancedSession4
{
    internal class Program
    {
        //public static List<int> FindOddNumbers(List<int> numbers)
        //{
        //    List<int> Result = new List<int>();
        //    if (numbers is not  null )
        //    {


        //        foreach (var number in numbers)
        //        {
        //            if (number % 2 != 0)
        //            {
        //                Result.Add(number);
        //            }
        //        }

        //    }
        //    return Result;
        //}

        //public static List<int> FindEvenNumbers(List<int> numbers)
        //{
        //    List<int> Result = new List<int>();
        //    if (numbers is not null)
        //    {


        //        foreach (var number in numbers)
        //        {
        //            if (number % 2 == 0)
        //            {
        //                Result.Add(number);
        //            }
        //        }

        //    }
        //    return Result;
        //}
       

        static void Main(string[] args)
        {
            #region Delegate 

            #region Delegate Example 1

            ////create function take sting and return number of uppercae letters
            //StringFunctionDelegate refrence;
            //refrence = new StringFunctionDelegate(StringFunction.CountUppercase);
            //refrence = StringFunction.CountUppercase;

            //refrence += StringFunction.CountLowercase;
            ////refrence -= StringFunction.CountLowercase;

            //int result = refrence.Invoke("Hello World");
            //Console.WriteLine(result);

            #endregion

            #region Delegate Example 2
            //bubble sort using delegate
            //int[] numbers = { 5, 3, 8, 4, 2 };
            //Helper.BubbleSort(numbers, StortingTypes.CompareGreaterThan);
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("===================================");
            //Helper.BubbleSort(numbers, StortingTypes.CompareLessThan);
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Delegate Example 2 with Genaric
            //bubble sort string  using delegate
            //string [] names = { "Alice", "Bob", "Charlie", "David" };

            // SortingTypesFunctionDelgate<string,bool> sortStrAsc= StortingTypes.SortStrAsc;
            // SortingTypesFunctionDelgate<string, bool> sortStrDesc = StortingTypes.SortStrDesc;
            // Helper<string>.BubbleSort(names, sortStrDesc);
            // foreach (var item in names)
            // {
            //     Console.WriteLine(item);
            // }



            #endregion


            #region Delegate Example 3

            // List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // numberCheckFunDelegate oddFunction = CheckNumbersCondition.CheckOdd;

            // numberCheckFunDelegate evenFunction = CheckNumbersCondition.CheckEven;
            //List<int> Numbers= FindNumbers(numbers, evenFunction);

            // foreach (var item in Numbers)
            // {
            //     Console.WriteLine(item);
            // }

            #endregion

            #region Delegate Example 3 Genaric

            //List<double> numbers = new List<double> { 1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0, 10.0 };
            //numberCheckFunDelegate<double, bool> oddFunction = CheckNumbersCondition.CheckOddDouble;

            //numberCheckFunDelegate<double, bool> evenFunction = CheckNumbersCondition.CheckEvenDouble;
            //List<double> Numbers = CheckNumber<double>.FindNumbers(numbers, evenFunction);

            //foreach (double item in Numbers)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region built in Delegate
            #region built-in Examples

            #region Predicate

            //Predicate<int> predicate;
            //predicate = new Predicate<int>(CommonFunction.testNumber);
            //predicate = CommonFunction.testNumber;
            //Console.WriteLine(predicate.Invoke(5));

            #endregion

            #region FunC
            //Func<int,string> func=CommonFunction.Cast;
            //Console.WriteLine(func.Invoke(100));

            #endregion

            #region Action
            //Action action=CommonFunction.Print;
            //action();

            //Action<string> action1=CommonFunction.message;
            //action1.Invoke("Route");
            #endregion

            #endregion

            #endregion

            #endregion

            #region Anonymous Method
            //Predicate<int> predicate = delegate (int number) { return number > 0; };
            //Console.WriteLine(predicate.Invoke(5));

            //Func<int, string> func = delegate (int number) { return number.ToString(); };
            //Console.WriteLine(func.Invoke(100));

            //Action<string> action = delegate (string msg) { Console.WriteLine($"Hello {msg}"); };
            //action.Invoke("Route");
            //Action actionNonGeneric = delegate () { Console.WriteLine("Hello from Action Delegate"); };
            //actionNonGeneric();
            #endregion

            #region Lambda Expression

            Predicate<int> predicate = number => number > 0;
            Console.WriteLine(predicate.Invoke(5));
            Func<int, string> func = number => number.ToString();
            Console.WriteLine(func.Invoke(100));
            Action<string> action = msg => Console.WriteLine($"Hello {msg}");
            action.Invoke("Route");
          
            #endregion


        }
    }
}
