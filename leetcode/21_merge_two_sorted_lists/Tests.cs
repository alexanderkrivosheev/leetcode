using leetcode._205_reverse_linked_list;
using Xunit;

namespace leetcode._merge_two_sorted_lists
{
    public static class Tests
    {
        [Theory]

        [InlineData(1)]
        public static void Solution_Case_1(int l)
        {
            ListNode head1 = new ListNode() { val = 1 };
            var node = head1;

            head1.next = new ListNode() { val = 2 };
            node = head1.next;

            node.next = new ListNode() { val = 4 };
            node = node.next;

            ListNode head2 = new ListNode() { val = 1 };
            node = head2;

            head2.next = new ListNode() { val = 3 };
            node = head2.next;

            node.next = new ListNode() { val = 4 };
            node = node.next;


            var solution = new Solution1();


            var result = solution.MergeTwoLists(head1, head2);

        }
    }
}
  