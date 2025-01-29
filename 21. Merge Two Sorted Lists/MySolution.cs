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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if(list1 == null) return list2;
        if(list2 == null) return list1;
        return list1.val < list2.val 
            ? new ListNode(list1.val, MergeTwoLists(list1.next, list2))
            : new ListNode(list2.val, MergeTwoLists(list1, list2.next));
    }
}