class Program
    {
        static void Main(string[] args)
        {
            char[][] board = new char[3][];
            board[0] = new char[4] { 'A', 'B', 'C', 'E' };
            board[1] = new char[4] { 'S', 'F', 'C', 'S' };
            board[2] = new char[4] { 'A', 'D', 'E', 'E' };
            var result = Exist(board, "ABCCED");
        }
        static bool Exist(char[][] board, string word)
        {
            int m = board.GetLength(0);
            int n = board[0].Length;
         
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (board[i][j] == word[0])
                    {
                        if (Helper(0, i, j, board, word, new bool[m, n]))
                            return true;
                    }
                }
            }
            return false;
        }

        static bool Helper(int index, int row, int col, char[][] board, string word, bool[,] visited)
        {
            int m = board.GetLength(0);
            int n = board[0].Length;
            if (index == word.Length)
                return true;
            if (row < 0 || col < 0 || row > m - 1 || col > n - 1)
                return false;
            if (visited[row, col]) return false;
            if (board[row][col] != word[index]) return false;
            visited[row,col] = true;
            if (Helper(index + 1, row + 1, col, board, word, visited)
               || Helper(index + 1, row - 1, col, board, word, visited)
               || Helper(index + 1, row, col + 1, board, word, visited)
               || Helper(index + 1, row, col - 1, board, word, visited)) return true;
            visited[row, col] = false;
            return false;
        }
    }
