namespace AdvancedSession4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Delegate 

            #region Delegate Example 1

            //create function take sting and return number of uppercae letters
            StringFunctionDelegate refrence;
            refrence = new StringFunctionDelegate(StringFunction.CountUppercase);
            refrence = StringFunction.CountUppercase;

            refrence += StringFunction.CountLowercase;
            //refrence -= StringFunction.CountLowercase;

            int result = refrence.Invoke("Hello World");
            Console.WriteLine(result);

            #endregion


            #endregion
        }
    }
}
