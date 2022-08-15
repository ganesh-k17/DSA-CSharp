using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSABeginner
{
    public class MergeTwoSortedArrays
    {
        /*
        1.  Merge two sorted arrays:

            Given two sorted arrays A[] and B[] of size N and M.
            The task is to merge both the arrays into a single arrray in non-decreasing order
            
            arr1 = [1, 2, 3, 4]
            arr2 = [6, 7, 8, 9, 10]
            
            o/p = [1, 2, 3, 4, 6, 7, 8, 9, 10]


            arr1[] = [1,4]
            arr2 = [2,3,9,10]
            o/p = [1,2,3,4,9,10]
        */
        public static int[] Merge(int[] input1, int[] input2)
        {
            //int[] output = new int[input1.Length + input2.Length];
            //for (int i = 0; i < input1.Length; i++)
            //{
            //    output[i] = input1[i];
            //}
            //int curr = input1.Length;
            //for (int i = 0; i < input2.Length; i++)
            //{
            //    output[curr] = input2[i];
            //    curr++;
            //}
            //return output;

            int N = input1.Length, M = input2.Length;
            int i = 0, j = 0, k = 0;
            int[] output = new int[N+M];

            while( i<N && j < M)
            {
                if(input1[i] < input2[i])
                {
                    output[k] = input1[i];
                    i++;
                    k++;
                }
                else
                {
                    output[k] = input2[j];
                    j++;
                    k++;
                }
            }

            while (i < N)
            {
                output[k] = input1[i];
                i++;
                k++;
            }

            while (j < M)
            {
                output[k] = input2[j];
                j++;
                k++;
            }

            return output;

        }
    }
}
