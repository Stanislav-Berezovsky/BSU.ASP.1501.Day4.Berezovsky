using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public interface IArrayCompare
    {
        bool Compare(int[] a,int[] b);
        bool IsPositive { get; set; }
    }
    public static class JaggedArraySort
    {

        public static void Sort(int[][] array,IArrayCompare comparator)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (comparator.Compare(array[j], array[j + 1]))
                    {
                          SwapArray(ref array[j], ref array[j+1]);
                    }
                }
            }
        }


        
        private static void SwapArray(ref int[] a, ref int[] b)
        {
            var swapArray = a;
            a = b;
            b = swapArray;
        }

    }


}
