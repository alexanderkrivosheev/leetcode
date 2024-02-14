namespace leetcode._longest_repeating
{
    public class Solution1
    {
        public int CharacterReplacement(string s, int k)
        {
            Dictionary<char, int> set = new Dictionary<char, int>();

            int longestSubstring = 0;
            int l = 0;
            for (int r = 0; r < s.Length; r++)
            {
                var currentSymbol = s[r];

                if (!set.ContainsKey(currentSymbol))
                {
                    set.Add(currentSymbol, 1);
                }
                else
                {
                    set[currentSymbol]++;
                }

                char? maxRepeatingSymbole = null;

                foreach (var item in set)
                {
                    if (!maxRepeatingSymbole.HasValue)
                    {
                        maxRepeatingSymbole = item.Key;
                    }
                    else if (set[maxRepeatingSymbole.Value] < item.Value)
                    {
                        maxRepeatingSymbole = item.Key;
                    }
                }
                int currentLength = (r - l) + 1;
                bool isValid = maxRepeatingSymbole.HasValue? (currentLength - set[maxRepeatingSymbole.Value]) <= k: false;

                if (isValid)
                {
                    if(longestSubstring < currentLength)
                    {
                        longestSubstring = currentLength;
                    }
                }
                else
                {
                    set[s[l]]--;
                    l++;
                }
            }

            return longestSubstring;
        }
    }
}
