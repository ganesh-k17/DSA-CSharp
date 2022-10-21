using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSABeginner.OnClass.Class_LinkedList
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public static class LinkedListProblems
    {
        /*
         * 
         https://leetcode.com/problems/delete-node-in-a-linked-list/
         * 
        There is a singly-linked list head and we want to delete a node node in it.

        You are given the node to be deleted node.You will not be given access to the first node of head.
        
        All the values of the linked list are unique, and it is guaranteed that the given node node is not the last node in the linked list.
        
        Delete the given node. Note that by deleting the node, we do not mean removing it from memory. We mean:
        
        
        The value of the given node should not exist in the linked list.
        The number of nodes in the linked list should decrease by one.
        All the values before node should be in the same order.
        All the values after node should be in the same order.
        Custom testing:
        
        
        For the input, you should provide the entire linked list head and the node to be given node.node should not be the last node of the list and should be an actual node in the list.
        We will build the linked list and pass the node to your function.
        The output will be the entire list after calling your function.
        
        
        Example 1:
        
        
        
        Input: head = [4, 5, 1, 9], node = 5
        Output: [4,1,9]
        Explanation: You are given the second node with value 5, the linked list should become 4 -> 1 -> 9 after calling your function.
        Example 2:
        
        
        
        Input: head = [4, 5, 1, 9], node = 1
        Output: [4,5,9]
        Explanation: You are given the third node with value 1, the linked list should become 4 -> 5 -> 9 after calling your function.
        
        
        
        Constraints:
        
        The number of the nodes in the given list is in the range [2, 1000].
        -1000 <= Node.val <= 1000
        The value of each node in the list is unique.
        The node to be deleted is in the list and is not a tail node.
        */

        /*
         Here we have to just reset the current node with the next node!
         */
        public static void DeleteNode(ListNode node)
        {
            // ListNode nextNode = node.Next;
            node.val = node.next.val;
            node.next = node.next.next;
        }

        /*
         https://leetcode.com/problems/odd-even-linked-list/

        Given the head of a singly linked list, group all the nodes with odd indices together followed by the nodes with even indices, and return the reordered list.

        The first node is considered odd, and the second node is even, and so on.
        
        Note that the relative order inside both the even and odd groups should remain as it was in the input.
        
        You must solve the problem in O(1) extra space complexity and O(n) time complexity.
        
        Example 1:
        
        Input: head = [1,2,3,4,5]
        Output: [1,3,5,2,4]
        Example 2:
        
        Input: head = [2,1,3,5,6,4,7]
        Output: [2,3,6,7,1,5,4]
         
        Constraints:
        
        The number of nodes in the linked list is in the range [0, 104].
        -106 <= Node.val <= 106
        */
        /**
        * Definition for singly-linked list.
        * public class ListNode {
        *     public int val;
        *     public ListNode next;
        *     public ListNode(int val=0, ListNode next=null) {
        *         this.val = val;
        *         this.next = next;
        *     }
        * }
        */
        public static ListNode OddEvenList(ListNode head)
        {
            return null;
        }


        /*
        https://leetcode.com/problems/remove-duplicates-from-sorted-list/


        */
        public static ListNode DeleteDuplicates(ListNode head)
        {
            return null;
        }

        /*
        https://leetcode.com/problems/remove-duplicates-from-sorted-list-ii/

        */
        public static ListNode DeleteDuplicatesII(ListNode head)
        {
            return null;
        }

        /*
        https://leetcode.com/problems/intersection-of-two-linked-lists/

        */
        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            ListNode curra = headA; 
            ListNode currb = headB;
            while(curra != null)
            {
               while(currb != null)
                {
                    if (curra == currb)
                        return curra;
                    currb = currb.next;
                }
                curra = curra.next;
                currb = headB;
            }
            return null;
        }

        /*
        https://leetcode.com/problems/add-two-numbers/
        https://leetcode.com/problems/add-two-numbers-ii/
        https://leetcode.ca/2016-12-03-369-Plus-One-Linked-List/   (https://leetcode.com/problems/plus-one-linked-list/)
        https://leetcode.com/problems/merge-two-sorted-lists/
        https://leetcode.com/problems/swap-nodes-in-pairs/

        https://www.geeksforgeeks.org/must-do-coding-questions-for-companies-like-amazon-microsoft-adobe/#LinkedList
        https://leetcode.com/discuss/general-discussion/460599/blind-75-leetcode-questions
        https://leetcode.com/problems/reorder-list/

        tail recursion vs loop recursion
        */

        /*
         Swap in pairs
        https://leetcode.com/problems/swap-nodes-in-pairs/
         */
        public static ListNode SwapPairs(ListNode head)
        {
            if(head == null || head.next == null)
            {
                return head;
            }
            //at least 2 nodes
            ListNode pNext = head.next.next;
            ListNode newHead = head.next;

            head.next.next = head;
            head.next = SwapPairs(pNext);
            return newHead;
        }

    }
}
