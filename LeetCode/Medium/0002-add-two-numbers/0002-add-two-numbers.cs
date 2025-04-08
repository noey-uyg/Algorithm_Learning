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
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {

        return AddNode(l1,l2,0);
    }

    public ListNode AddNode(ListNode l1, ListNode l2, int remain){
        if(l1 == null && l2 == null && remain == 0) return null;

        int sum = (l1?.val ?? 0) + (l2?.val ?? 0) + remain;

        return new ListNode(sum%10, AddNode(l1?.next,l2?.next,sum/10));
    }
}