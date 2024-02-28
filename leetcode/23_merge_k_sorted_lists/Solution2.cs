using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._merge_k_sorted_lists
{
    public class Solution2
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            ListNode dummy = new ListNode();
            ListNode lastNode = dummy;

            while (lists.Length > 1)
            {
                var mergedLists = new ListNode[(lists.Length + 1) / 2];
                for (int i = 0, j = 0; i < lists.Length; i += 2, j++)
                {
                    mergedLists[j] = MergeLists( lists[i], (( i + 1) <= lists.Length -1) ?lists[i+1] :null );                    
                }

                lists = mergedLists;
            }
            return lists[0];
        }

        private ListNode MergeLists(ListNode list1, ListNode list2)
        {
            ListNode dummy = new ListNode();
            ListNode tail = dummy;

            while (list1 != null || list2 != null)
            {
                if (list1 == null)
                {
                    tail.next = list2;
                    break;
                }

                if (list2 == null)
                {
                    tail.next = list1;
                    break;
                }

                if (list1.val >= list2.val)
                {
                    tail.next = list2;
                    list2 = list2.next;
                }
                else
                {
                    tail.next = list1;
                    list1 = list1.next;
                }

                tail = tail.next;
            }
            return dummy.next;
        }

    }
}