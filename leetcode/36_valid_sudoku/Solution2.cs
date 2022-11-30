using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._36_valid_sudoku
{
    public class Solution2
    {
        public bool IsValidSudoku(char[][] board)
        {
            HashSet<string> set = new HashSet<string>();
            char value;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    value = board[i][j];

                    if (value == '.')
                    {
                        continue;
                    }

                    if (!IsValidNumberRange(value))
                    {
                        return false;
                    }

                    var rowKey = $"{value}row{i}";
                    var columnKey = $"{value}column{j}";
                    var cellKey = $"{value}cell{i / 3}{j / 3}";

                    if (set.Contains(rowKey))
                    {
                        return false;
                    }
                    else
                    {
                        set.Add(rowKey);
                    }

                    if (set.Contains(columnKey))
                    {
                        return false;
                    }
                    else
                    {
                        set.Add(columnKey);
                    }

                    if (set.Contains(cellKey))
                    {
                        return false;
                    }
                    else
                    {
                        set.Add(cellKey);
                    }
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
