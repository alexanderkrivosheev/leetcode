using leetcode._205_reverse_linked_list;
using System.Configuration;

namespace leetcode._205_reverse_linked_list
{
    public class Solution1
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode current = null;
            ListNode next = head;

            while (next != null)
            {
                current = next;

                next = current.next;

                current.next = prev;

                prev = current;
            };

            return current;
        }        
    }
}