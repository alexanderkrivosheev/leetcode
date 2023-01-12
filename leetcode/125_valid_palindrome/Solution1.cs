using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._125_valid_palindrome
{
    public class Solution1
    {
            public bool IsPalindrome(string s)
            {
                int indexPoint1 = 0;
                int indexPoint2 = s.Length - 1;

                do
                {
                    if (IsValid(s[indexPoint1]) && IsValid(s[indexPoint2]))
                    {                        
                        if (ToLowerCase(s[indexPoint1]) - ToLowerCase(s[indexPoint2]) != 0)
                        {
                            return false;
                        }

                        indexPoint1++;
                        indexPoint2--;

                        continue;
                    }

                    if (!IsValid(s[indexPoint1]))
                    {
                        indexPoint1++;
                    }

                    if (!IsValid(s[indexPoint2]))
                    {
                        indexPoint2--;
                    }

                }
                while (indexPoint2 > indexPoint1);

                return true;
            }


        private bool IsValid(char value)
        {
            int code = (int)value;

            return (65 <= code && code <= 90) || (97 <= code && code <= 122) || (47 <= code && code<= 57 );
        }

        private int ToLowerCase(char value)
        {
            int code = (int)value;

            if(97 <= code && code <= 122)
            {
                return code - 32;
            }

            return code;
        }
    }
}
