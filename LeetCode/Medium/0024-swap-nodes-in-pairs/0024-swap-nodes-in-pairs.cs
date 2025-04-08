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
    public ListNode SwapPairs(ListNode head) {
        ListNode node = new ListNode();
        node.next = head;
        ListNode temp1 = node;
        ListNode temp2 = new ListNode();

        while(temp1.next != null && temp1.next.next != null){
            temp2 = temp1.next;
            temp1.next = temp2.next;
            temp2.next = temp1.next.next;
            temp1.next.next = temp2;

            temp1 = temp2;
        }

        return node.next;
    }
}