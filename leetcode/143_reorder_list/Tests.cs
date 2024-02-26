using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace leetcode._reorder_list
{
    public static class Tests
    {
        [Theory]


        [InlineData(1)]
        public static void Solution_Case_1(int l)
        {
            ListNode head = new ListNode() { val = 1 };
            var node = head;

            head.next = new ListNode() { val = 2 };
            node = head.next;

            node.next = new ListNode() { val = 3 };
            node = node.next;
            
            node.next = new ListNode() { val = 4 };
            node = node.next;

            node.next = new ListNode() { val = 5 };

            var solution = new Solution1();
            solution.ReorderList(head);
            
        }
    }
}
  