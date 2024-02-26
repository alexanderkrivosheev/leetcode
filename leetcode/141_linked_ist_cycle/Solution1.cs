using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._linked_ist_cycle
{
    public class Solution1
    {
        public bool HasCycle(ListNode head)
        {

            ListNode r1 = head;
            ListNode r2 = head;

            while (r2 != null && r2.next != null)
            {
                r1 = r1.next;
                r2 = r2.next.next;

                if (r1 == r2)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
