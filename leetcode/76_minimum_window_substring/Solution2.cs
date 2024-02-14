namespace leetcode._minimum_window_substring
{
    public class Solution2
   {
        public string MinWindow(string s, string t)
        {
            var window = new Dictionary<char, int>();
            int need = t.Length;
            int have = 0;
            var conditions = new Dictionary<char, int>();
            string minSubstring = string.Empty;
            int l = 0;

            for (int i = 0; i < t.Length; i++)
            {
                if (!conditions.ContainsKey(t[i]))
                {
                    conditions.Add(t[i], 1);
                    window.Add(t[i], 0);
                }
                else
                {
                    conditions[t[i]]++;
                }
            }

            for (int r = 0; r < s.Length; r++)
            {
                if (conditions.ContainsKey(s[r]))
                {
                    window[s[r]]++;
                    if (window[s[r]] <= conditions[s[r]])
                    {
                        have++;
                    }
                }

                while (have == need)
                {
                    int length = r + 1 - l;
                    if (string.IsNullOrEmpty(minSubstring) || minSubstring.Length > length)
                    {
                        minSubstring = s.Substring(l, length);
                    }

                    if (conditions.ContainsKey(s[l])) 
                    {
                        window[s[l]]--;

                        if (window[s[l]] < conditions[s[l]])
                        {
                            have--;
                        }
                    }

                    l++;
                }
            }

            return minSubstring;
        }
    }
}