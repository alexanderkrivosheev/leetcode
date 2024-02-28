using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace leetcode._merge_k_sorted_lists
{
    public static class Tests
    {
        [Theory]


        [InlineData(1)]
        public static void Solution_Case_1(int l)
        {
            ListNode head1 = new ListNode() { val = 1 };
            var node = head1;

            head1.next = new ListNode() { val = 4 };
            node = head1.next;

            node.next = new ListNode() { val =5 };
            node = node.next;


            ListNode head2 = new ListNode() { val = 1 };
            var node2 = head2;

            head2.next = new ListNode() { val = 3 };
            node2 = head2.next;

            node2.next = new ListNode() { val = 4 };
            node2 = node2.next;


            ListNode head3 = new ListNode() { val = 2 };
            var node3 = head2;

            head3.next = new ListNode() { val = 6 };
            node3 = head3.next;

            var lists = new ListNode[] { head1, head2, head3 };

            var solution = new Solution2();
            var result = solution.MergeKLists(lists);            
        }
    }
}
  