using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace leetcode._36_valid_sudoku
{
    public static class Tests
    {
        [Fact]
        public static void Solution_Case_1()
        {
            char[][] input = new char[9][];
            input[0] = new char[] { '5', '3', '.',   '.', '7', '.',  '.', '.', '.' };
            input[1] = new char[] { '6', '.', '.',   '1', '9', '5',  '.', '.', '.' };
            input[2] = new char[] { '.', '9', '8',   '.', '.', '.',  '.', '6', '.' };
            
            input[3] = new char[] { '8', '.', '.',   '.', '6', '.',  '4', '.', '3' };
            input[4] = new char[] { '4', '.', '.',   '8', '.', '3',  '3', '.', '1' };            
            input[5] = new char[] { '7', '.', '.',   '.', '2', '.',  '.', '.', '6' };
            
            input[6] = new char[] { '.', '6', '.',   '.', '.', '.',  '2', '8', '.' };
            input[7] = new char[] { '.', '.', '.',   '4', '1', '9',  '.', '.', '5' };
            input[8] = new char[] { '.', '.', '.',   '.', '8', '.',  '.', '7', '9' };


            Solution2 solution = new Solution2();
            var result = solution.IsValidSudoku(input);
            Assert.Equal(result, false);
        }      
    }
}
  