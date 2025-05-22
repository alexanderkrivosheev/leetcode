namespace leetcode.backtracking.word_search
{
    public class Solution
    {
        public bool Exist(char[][] board, string word)
        {
            List<(int, int)> sequence = new List<(int, int)>();

            for (int row = 0; row < board.Length; row++)
            {
                for (int col = 0; col < board[row].Length; col++)
                {
                    if (FindNext(row, col, sequence, board, word))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool FindNext(int row,int col, List<(int, int)> sequence, char[][] board, string word)
        { 
            if(sequence.Count >= word.Length)
            {
                return true;
            }

            if(sequence.Any(s=>s.Item1 == row && s.Item2 == col))
            {
                return false;
            }

            if (row < 0 || row >= board.Length)
            {
                return false;
            }

            if (col<0 || col >= board[row].Length)
            {
                return false;
            }

            char targetSymbol = word[sequence.Count];
            char currentSymbol = board[row][col];

            sequence.Add((row, col));

            if (currentSymbol == targetSymbol)
            {
                if (FindNext(row, col - 1, sequence, board, word) ||
                       FindNext(row, col + 1, sequence, board, word) ||
                       FindNext(row - 1, col, sequence, board, word) ||
                       FindNext(row + 1, col, sequence, board, word)
                    )
                {
                    return true;
                }
            }

            sequence.RemoveAt(sequence.Count - 1);

            return false;
        }
    }
}
