using leetcode._205_reverse_linked_list;

namespace leetcode._merge_two_sorted_lists
{
    public class Solution1
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode next1 = list1;
            ListNode next2 = list2;
            ListNode result = null;
            ListNode current = null;

            while ((next1 != null) || (next2 != null))
            {
                if (next1 == null)
                {
                    current = next2;
                    next2 = next2.next;
                }
                else if (next2 == null)
                {
                    current = next1;
                    next1 = next1.next;
                }
                else
                {
                    if (next1.val <= next2.val)
                    {
                        current = next1;
                        next1 = next1.next;
                    }
                    else
                    {
                        current = next2;
                        next2 = next2.next;
                    }
                }

                if (result == null)
                {
                    result = current;
                }
                else
                {
                    result.next = current;
                }
            }


            return result;
        }
    }

}