using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public delegate string BookFunctionDelegate(Book B);


    public class LibraryEngine
    {
        // Using User Defined Delegate
        public static void ProcessBooks(List<Book> blist, BookFunctionDelegate fPtr)
        {
            foreach (Book B in blist)
            {
                Console.WriteLine(fPtr.Invoke(B));
            }
        }

        // Using  Func Delegate 
        public static void ProcessBooksBCL(List<Book> blist, Func<Book, string> fPtr)
        {
            foreach (Book B in blist)
            {
                Console.WriteLine(fPtr.Invoke(B));
            }
        }
    }
}
