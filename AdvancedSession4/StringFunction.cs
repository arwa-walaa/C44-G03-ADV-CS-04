using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedSession4
{
    //Declaere delegate
    public delegate int StringFunctionDelegate(string str);
    //new Delegate =>new class
    internal class StringFunction
    {
        public static int CountUppercase(string name)
        {
           int count = 0;
            if(name is not null)
            {
                foreach (var item in name)
                {
                    if(char.IsUpper(item))
                    {
                        count++;
                    }
                }
                
            }
            return count;
        }
        public static int CountLowercase(string name)
        {
            int count = 0;
            if (name is not null)
            {
                foreach (var item in name)
                {
                    if (char.IsLower(item))
                    {
                        count++;
                    }
                }

            }
            return count;
        }
    }
}
