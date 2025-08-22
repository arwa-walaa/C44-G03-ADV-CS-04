using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedSession4
{
    internal class Helper<T>
    {

        private static void Swap(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        public static void BubbleSort(T[] arr , SortingTypesFunctionDelgate<T,bool> sortingTypesDelgate)
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
