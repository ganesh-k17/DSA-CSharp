using DSABeginner.Assessment;
using DSABeginner.Assessments;
using DSABeginner.Assessments.Assessment3;
using DSABeginner.Assessments.Assessment5;
using DSABeginner.OnClass.Class_LinkedList;
using DSABeginner.OnClass.Class10_stack;
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
            //int[] numbers = Assessment1.NumbersExpectTheLast2MaxNumbers(new int[] { 2, 8, 7, 1, 5  });
            //int[] numbers1 = Assessment1.NumbersExpectTheLast2MaxNumbers(new int[] {  7, -2, 3, 4, 9, -1 });

            //int RemainingNumberAfterMaxMinRemoval = Assessment1.RemainingNumberAfterMaxMinRemoval(new int[] { 101 });

            //int myNumber = Assessment1.SumOfIndividualNumbers(1);
            //int myNumber1 = Assessment1.SumOfIndividualNumbers(5);

            //string facinatedText = Assessment1.IsFacinatingNumber(192);
            //string facinatedText1 = Assessment1.IsFacinatingNumber(853);

            //int num1 = Assessment1.NumberToMakeThisBalanced(new int[] { 1, 2, 1, 2, 1, 3 });
            //int num2 = Assessment1.NumberToMakeThisBalanced(new int[] { 1, 5, 3, 2 });

            // int[] output = MergeTwoSortedArrays.Merge(new int[] {2,20}, new int[] {1,3,5,7,8,9,11});
            // string[] output = PrintFizzBuzzByDivBy3or5.Print(15);

            // string myText = ReverseVowels.Reverse("LEET CODE");

            //int value = Assesments2.WealthiestMansAmount(new int[,] { { 2, 8, 7 },{ 7, 1, 3 },{ 1, 9, 5 } });

            //int[] number = Assesments2.SumOf1DArray(new int[] { 1, 2, 3, 4 });
            //int[] number1 = Assesments2.SumOf1DArray(new int[] { 3, 1, 2, 10, 1 });

            //int sum =  Assesments2.NumJewelsInStones("aA", "aAAbbbb");
            //int sum1 = Assesments2.NumJewelsInStones("z", "ZZ");

            // int[][] number = Assesments2.PairsWithMinDifferenceInAscOrder(new int[] { 3, 8, -10, 23, 19, -4, -14, 27 });

            // int[][] result1 = Assesments2.Transpose(new int[][] { new int[] { 1,2,3}, new int[] {4,5,6 }});
            //int result1 = Assesments2.MajorityElement(new int[] {3,3,4 });

            //int[] result1 = Assesments2.MoveZeroes(new int[] { 0, 0, 1 });
            //int[] result2 = Assesments2.MoveZeroes(new int[] { 0, 1, 0, 3, 12 });

            // bool result1 = Assessment3.IsHappyNumber(19);
            // bool result2 = Assessment3.IsHappyNumber(2);

            // string reversed = Assessment3.xorIt("hello", "ganesh");
            // char myText = Assessment3.FindTheDifference("ae", "aea");


            // int s = Assessment3.addDigits(38);

            // int s = Assessment3.GetLucky("leetcode", 2);

            // string s = ContinuousDuplicateRemovalInText.RemoveDuplicatesOfGivenNumberOfTimes("abcd", 3);

            //bool istrue = ValidParanthesis.Validate("()");



            //string s = "raja";
            //int t = s.GetHashCode();
            //t = s.GetHashCode();

            //var myNode = new ListNode()
            //{
            //    next = new ListNode()
            //    {
            //        next = new ListNode()
            //        {
            //            next = new ListNode()
            //            {

            //            }
            //        }
            //    }
            //};

            //LinkedListProblems.GetIntersectionNode(
            //    new ListNode()
            //    {
            //        next = new ListNode()
            //        {
            //            next = new ListNode()
            //            {
            //                next = new ListNode()
            //                {
            //                    next = myNode
            //                }
            //            }
            //        }
            //    },
            //    new ListNode()
            //    {
            //        next = new ListNode()
            //        {
            //            next = new ListNode()
            //            {
            //                next = myNode
            //            }
            //        }
            //    });

            // Assessment5.MajorityElementII(new int[] { 4, 2, 1,1 });

            // Assessment5.findMissingRanges(new int[] { 0, 1, 3, 50, 75 }, 0, 99);

            // bool isPalindrome = PalindromeByResursion.Validate("malayalam");

            // MergeIntervals.Merge(new int[][] { new int[] { 1, 3 }, new int[] { 2, 6 }, new int[] { 8, 10 }, new int[] { 15, 18 } });

            //Assessment5.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });
            int res = Assessment5.Find3SumSmaller(new int[] { -2, 0, 1, 3 }, 2);

            Console.Read();
        }
    }
}










