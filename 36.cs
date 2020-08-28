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
            var res = IsValidSudoku(board);
        }
        static bool IsValidSudoku(char[][] board)
        {
            HashSet<string> set = new HashSet<string>();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    char val = board[i][j];
                    if (val != '.')
                    {
                        if (!set.Add(val + " row " + i) || !set.Add(val + " col " + j) || !set.Add(val + " sub box " + i / 3 + "-" + j/3))
                            return false;
                    }
                }
            }
            return true;
        }
    }
