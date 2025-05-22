using Xunit;

namespace leetcode.backtracking.word_search
{
    public static class Tests
    {
        [Fact]
        public static void Solution_Case_1()
        {
           var board =  new char[][] {
    new char[] { 'A','B','C','E' },
    new char[] { 'S','F','C','S' },
    new char[] { 'A','D','E','E' }
           };
            Solution solution = new Solution();
            var result = solution.Exist(board, "SEE");
        }
    }
}
  