using leetcode._205_reverse_linked_list;
using System.Configuration;

namespace leetcode._merge_k_sorted_lists
{
    public class Solution1
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            ListNode dummy = new ListNode();
            ListNode lastNode = dummy;
            int minNodeIndex = 0;

            if (lists.Length == 0)
            {
                return dummy.next;
            }

            while (true)
            {
                for (int i = 0; i < lists.Length; i++)
                {
                    if (lists[i] == null)
                    {
                        continue;
                    }

                    if (lists[minNodeIndex] == null || lists[minNodeIndex].val >= lists[i].val)
                    {
                        minNodeIndex = i;
                    }
                }

                if (lists[minNodeIndex] == null)
                {
                    break;
                }

                lastNode.next = lists[minNodeIndex];

                lastNode = lists[minNodeIndex];

                lists[minNodeIndex] = lists[minNodeIndex].next;

            }
            return dummy.next;
        }
    }
}