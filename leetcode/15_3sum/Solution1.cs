namespace leetcode._15_3sum
{
    public class Solution1
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>();
            Array.Sort(nums);

            HashSet<int> processedValues = new HashSet<int>();
            int pointL = 0;
            int pointR = 0;
            int sum = 0;
            int target = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (processedValues.Contains(nums[i]))
                {
                    continue;
                }
                else
                {
                    processedValues.Add(nums[i]);
                }

                List<int> numsList = new List<int>(nums.Skip(i + 1));

                if (numsList.Count() < 2)
                {
                    continue;
                }
                
                target = 0 - nums[i];
                pointL = 0;
                pointR = numsList.Count() - 1;

                do
                {
                    sum = numsList[pointL] + numsList[pointR];
                    if (sum > target)
                    {
                        pointR--;
                    }

                    if (sum < target)
                    {
                        pointL++;
                    }

                    if (sum == target)
                    {
                        var newTriplet = new List<int>() { nums[i], numsList[pointL], numsList[pointR] };
                        result.Add(newTriplet);
                        numsList.RemoveAll(num => num == newTriplet[1]);
                        numsList.RemoveAll(num => num == newTriplet[2]);

                        pointL = 0;
                        pointR = numsList.Count() - 1;
                    }
                }
                while (pointR > pointL); 
            }

            return result;
        }
    }
}
