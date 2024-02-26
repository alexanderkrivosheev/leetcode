using Iced.Intel;
using leetcode._205_reverse_linked_list;
using System.Configuration;

namespace leetcode._reorder_list
{
    public class Solution1
    {
        private ListNode ReverseList(ListNode prev, ListNode current)
        {
            ListNode next = current.next;
            current.next = prev;

            if (next != null)
            {
                return ReverseList(current, next);
            }

            return current;
        }

        public void ReorderList(ListNode head)
        {
            if(head==null || head.next == null)
            {
                return;
            }

            ListNode next1 = head;
            ListNode current = null;
            ListNode oldNext = null;
            ListNode newNext = null;

            ListNode slow = head;
            ListNode fast = head.next;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            
            ListNode head2 = ReverseList(null, slow.next);
            slow.next = null;
            ListNode next2 = head2;

            while (next2 != null)
            {
                current = next1;

                next1 = next1.next;

                oldNext = current.next;

                newNext = next2;
                next2 = next2.next;

                current.next = newNext;
                newNext.next = oldNext;
            }
        }
    }
}