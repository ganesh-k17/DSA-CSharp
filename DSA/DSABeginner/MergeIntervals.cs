using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSABeginner
{
    /*
    Given an array of intervals where intervals[i] = [starti, endi], merge all overlapping intervals, and return an array of the non-overlapping intervals that cover all the intervals in the input.
    
    Example 1:
    
    Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
    Output: [[1,6],[8,10],[15,18]]
    Explanation: Since intervals [1,3] and [2,6] overlap, merge them into [1,6].
    Example 2:
    
    Input: intervals = [[1,4],[4,5]]
    Output: [[1,5]]
    Explanation: Intervals [1,4] and [4,5] are considered overlapping.
         
    Constraints:
    
    1 <= intervals.length <= 104
    intervals[i].length == 2
    0 <= starti <= endi <= 104 
    */
    public static class MergeIntervals
    {
        public static int[][] Merge(int[][] intervals)
        {
            MultiArraySort multiArraySort = new();
            Array.Sort(intervals, multiArraySort);
            List<int[]> results = new List<int[]>();

            for (int i = 0; i < intervals.Length-1; i++)
            {
                int[] firstItem = intervals[i];
                int[] secondItem = intervals[i+1];
                if (firstItem[1] > secondItem[0])
                {
                    results.Add(new int[] { intervals[i][0], intervals[i + 1][1] });
                    i++;
                }
                else
                {
                    results.Add(firstItem);
                    results.Add(secondItem);
                }
            }

            return results.ToArray();
        }
    }

    public class MultiArraySort : IComparer
    {
        public int Compare(object x, object y)
        {
            int[] firstArray = x as int[];
            int[] secondArray = y as int[];
            return firstArray[0].CompareTo(secondArray[0]);
        }
    }
}
