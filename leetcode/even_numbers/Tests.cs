using Xunit;

namespace leetcode.even_numbers
{
    public static class Tests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 1, 1, 1, 1, 1, 1 }, 2)]
        public static void Solution_Case_1(int[] nums, int expected)
        { 
            Solution1 solution = new Solution1();
            var result = solution.TotalAllEvenNumbers(nums);
            Assert.Equal(expected, result);
        }      
    }
}
  