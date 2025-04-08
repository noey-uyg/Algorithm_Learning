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
    public ListNode RemoveElements(ListNode head, int val) {
        ListNode temp = new ListNode(-1, head);
        
        head = temp;

        while(head.next != null){
            if(head.next.val == val){
                head.next = head.next.next;
            }
            else{
                head = head.next;
            }
        }
        return temp.next;
    }
}