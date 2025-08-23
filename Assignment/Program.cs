namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create sample books
            List<Book> books = new List<Book>
        {
            new Book("978-3-16-148410-0", "C# Programming",
                    new string[] {"John Doe", "Jane Smith"},
                    new DateTime(2023, 1, 15), 49.99m),
            new Book("978-1-23-456789-7", "Advanced C#",
                    new string[] {"Alice Johnson"},
                    new DateTime(2024, 3, 20), 79.99m)
        };
            #region Using User Defined Delegate

            //Console.WriteLine("=== Using User Defined Delegate ===");
            //LibraryEngine.ProcessBooks(books, BookFunctions.GetTitle);
            //LibraryEngine.ProcessBooks(books, BookFunctions.GetAuthors);
            //LibraryEngine.ProcessBooks(books, BookFunctions.GetPrice);
            #endregion


            #region Using Built-in Delegate
            //Console.WriteLine("\n=== Using Built-in Func Delegate ===");
            //LibraryEngine.ProcessBooks(books, BookFunctions.GetTitle);
            //LibraryEngine.ProcessBooks(books, BookFunctions.GetAuthors);
            //LibraryEngine.ProcessBooks(books, BookFunctions.GetPrice);
            #endregion

            #region Using Anonymous Methods
            Console.WriteLine("\n=== Using Anonymous Methods ===");
            LibraryEngine.ProcessBooks(books, delegate (Book B) { return B.ISBN; });
          
            #endregion
      


        }
    }
}
