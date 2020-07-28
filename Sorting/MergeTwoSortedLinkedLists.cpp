/*

Merge Two Sorted Lists
Problem Description

Merge two sorted linked lists A and B and return it as a new list.

The new list should be made by splicing together the nodes of the first two lists, and should also be sorted.

*/

/**
 * Definition for singly-linked list.
 * class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {this.val = x; this.next = null;}
 * }
 */
class Solution {
    public ListNode mergeTwoLists(ListNode A, ListNode B) {
            if (A == null) return B;
            if (B == null) return A;

            ListNode head = null;

            if(A.val < B.val)
            {
                head = A;
                A = A.next;
            }
            else
            {
                head = B;
                B = B.next;
            }

            ListNode P = head;

            while(A != null && B != null)
            {
                if(A.val < B.val)
                {
                    P.next = A;
                    A = A.next;
                }
                else
                {
                    P.next = B;
                    B = B.next;
                }
                P = P.next;
            }

            if(A != null)
            {
                P.next = A;
            }
            else
            {
                P.next = B;
            }

            return head;
    }
}