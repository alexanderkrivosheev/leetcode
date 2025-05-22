namespace leetcode.backtracking.combination_sum
{
    public class Solution
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {

            var result = new List<IList<int>>();
            CombinationSum(new List<int>(), 0, candidates, target, result);

            return result; ;
        }

        public void CombinationSum(List<int> combination, int currentIndex, int[] candidates, int target, IList<IList<int>> result)
        {        
            if (currentIndex >= candidates.Length)
            {
                return;
            }

            var total = combination.Sum(x => x);

            if (total > target)
            {
                return ;
            }

            if (total == target)
            {
                result.Add( new List<int>(combination));
                return;
            }
          
            combination.Add(candidates[currentIndex]);            

            CombinationSum(combination, currentIndex, candidates, target, result);

            combination.Remove(combination[combination.Count - 1]);

            CombinationSum(combination, currentIndex + 1, candidates, target, result);
        }
    }
}
