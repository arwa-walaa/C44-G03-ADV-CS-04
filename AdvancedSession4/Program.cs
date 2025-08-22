namespace AdvancedSession4
{
    internal class Program
    {
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
            int[] numbers = { 5, 3, 8, 4, 2 };
            Helper.BubbleSort(numbers, StortingTypes.CompareGreaterThan);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("===================================");
            Helper.BubbleSort(numbers, StortingTypes.CompareLessThan);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }


            #endregion


            #endregion
        }
    }
}
