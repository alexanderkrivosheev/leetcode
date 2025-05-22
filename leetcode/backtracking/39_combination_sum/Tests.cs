using Xunit;

namespace leetcode.backtracking.combination_sum
{
    public static class Tests
    {
        [Theory]
        [InlineData(new int[] { 2, 3, 6, 7 }, 7)]
        [InlineData(new int[] { 2, 3, 5 }, 8)]
        public static void Solution_Case_1(int[] candidates, int target)
        {
            Solution solution = new Solution();
            var result = solution.CombinationSum(candidates, target);
        }
    }
}
  