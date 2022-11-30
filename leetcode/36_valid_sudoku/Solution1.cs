using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._36_valid_sudoku
{
    public class Solution1
    {
        public bool IsValidSudoku(char[][] board)
        { 
            HashSet<char> horizont = new HashSet<char>();
            HashSet<char> vertical = new HashSet<char>();
            char value;
            for (int i = 0; i < 9; i++)
            {
                horizont.Clear();
                vertical.Clear();

                for (int j = 0; j < 9; j++)
                {
                    value = board[i][j];
                    if (value != '.')
                    {
                        if (!IsValidNumberRange(value) || horizont.Contains(value))
                        {
                            return false;
                        }
                        else
                        {
                            horizont.Add(value);
                        }
                    }

                    value = board[j][i];
                    if (value != '.')
                    {
                        if (!IsValidNumberRange(value) || vertical.Contains(value))
                        {
                            return false;
                        }
                        else
                        {
                            vertical.Add(value);
                        }
                    }
                }
            }

            int iStart = 0;
            int jStart = 0;
            int iEnd = 3;
            int jEnd = 3;
            HashSet<char> cell = new HashSet<char>();

            while (iEnd <= 9 && jEnd <= 9)
            {
                cell.Clear();

                for (int i = iStart; i < iEnd; i++)
                {
                    for (int j = jStart; j < jEnd; j++)
                    {
                        value = board[i][j];
                        if (value != '.')
                          {
                              if (!IsValidNumberRange(value) || cell.Contains(value))
                            {
                                return false;
                            }
                            else
                            { 
                                cell.Add(value);
                            }
                        }
                    }
                }

                if (jEnd < 9)
                {
                    jStart = jEnd;
                    jEnd += 3;
                }
                else if (iEnd < 9)
                {
                    jStart = 0;
                    jEnd = 3;
                    iStart = iEnd;
                    iEnd += 3;
                }


            }

            return true;
        }

        private bool IsValidNumberRange(char value)
        {
            return (1 <= (int)value) && (9 <= (int)value);
        }
    }
}
