using leetcode._205_reverse_linked_list;
using System.Configuration;

namespace leetcode._remove_nth_nod
{
    public class Solution1
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var dummy = new ListNode(0, head);
            var left = dummy;
            var right = head;

            while (n > 0)
            {
                right = right.next;
                n--;
            }

            while (right != null)
            {
                left = left.next;
                right = right.next;
            }

            // delete
            left.next = left.next.next;
            return dummy.next;

        }
    }
}