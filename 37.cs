class Program
    {
        static void Main(string[] args)
        {
            char[][] board =  {
                "53..7....".ToCharArray(),
                "6..195...".ToCharArray(),
                ".98....6.".ToCharArray(),
                "8...6...3".ToCharArray(),
                "4..8.3..1" .ToCharArray(),
                "7...2...6".ToCharArray(),
                ".6....28.".ToCharArray(),
                "...419..5".ToCharArray(),
                "....8..79".ToCharArray()
             };
        }
        static void SolveSudoku(char[][] board)
        {
            help(board);
        }

        private static bool help(char[][] board)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] == '.')
                    {
                        for (char num = '1'; num <= '9'; num++)
                        {
                            if (isValid(board, i, j, num))
                            {
                                board[i][j] = num;
                                if (help(board)) return true;
                                board[i][j] = '.';
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }

        private static bool isValid(char[][] board, int row, int col, char num)
        {
            for (int i = 0; i < 9; i++)
            {
                if (board[i][col] == num) return false;
                if (board[row][i] == num) return false;
                if (board[3 * (row / 3) + i / 3][3 * (col / 3) + i % 3] == num) return false;
            }
            return true;
        }
    }
