using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal static class BubleSortDleget
    {
        public  static void Bublesort(int[] arr)
        {
            if (arr?.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - 1 - i; j++)
                    {
                        if (arr[j] > arr[j+1])
                            Swap( ref arr[j],ref  arr[j+1]);
                    }
                }
            }
        }


        private  static void Swap (ref int a, ref int b)
        {
            int  temp = a;
            a= b;
            b= temp;

           
        }
    }
}
