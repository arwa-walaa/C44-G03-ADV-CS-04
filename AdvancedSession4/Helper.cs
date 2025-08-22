using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedSession4
{
    internal class Helper
    {

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static void BubbleSort(int[] arr , SortingTypesFunctionDelgate sortingTypesDelgate)
        {
            if (arr is not null)
            {
               
                for (int i = 0; i < arr.Length ; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (sortingTypesDelgate.Invoke(arr[j], arr[j + 1]))
                        {
                           
                           Swap(ref arr[j], ref arr[j + 1]);
                        }
                    }
                }
            }

        }
      
        //public static void BubbleSortDesc(int[] arr)
        //{
        //    if (arr is not null)
        //    {

        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            for (int j = 0; j < arr.Length - i - 1; j++)
        //            {
        //                if (arr[j] < arr[j + 1])
        //                {
        //                    // swap temp and arr[i]
        //                    Swap(ref arr[j], ref arr[j + 1]);
        //                }
        //            }
        //        }
        //    }

        //}
    }
}
