using DSABeginner.Assessment;
using System;

namespace DSABeginner
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] find2MaxResult = Find2Max.Calculate(new int[] { 1, 21, 31, 45, 12, 2, 87, 87, 32 });

            // PrintTriangleNumber.Print();
           //  PrintNumberTable.Print(5, 10);
            int[] result = ReverseIntegerArray.Calculate(new int[] { 3, 2, 1, 8, 9 });
           

            //int sum = Assessment.Assessment1.SumOfIntegers(new int[] { 1, 2, 3, 4, 5 });
            //int numberAt = Assessment.Assessment1.NumberAt(2, new int[] { 10, 20, 30, 40, 50 });
            //int countLessThan = Assessment.Assessment1.CountNumbersLessThan(2, new int[] { 1, 2, 2, 2, 5, 7, 9 });
            //string alternateOrdered = Assessment1.PrintMeAlternateOrder(new int[] {1,2,3,4,5});
            //int numberAsIndex = Assessment1.FindNumberAsIndex(new int[] { 15, 2, 45, 12, 7 });
            //string isPerfectByReverse = Assessment1.IsPerfectArrayByReverse(new int[] { 1, 2, 3, 2, 1 });
            //int RemainingNumberAfterMaxMinRemoval = Assessment1.RemainingNumberAfterMaxMinRemoval(new int[] { 7, 8, 3, 4, 2, 9, 5 });

            // int[] output = MergeTwoSortedArrays.Merge(new int[] {2,20}, new int[] {1,3,5,7,8,9,11});
            string[] output = PrintFizzBuzzByDivBy3or5.Print(15);

            ReverseVowels.Reverse("LEET CODE");

            Console.Read();
        }
    }
}
