class Program
    {
        static void Main(string[] args)
        {
            int[][] grid = new int[3][];
            grid[0] = new int[3] { 1, 3, 1 };
            grid[1] = new int[3] { 1, 5, 1 };
            grid[2] = new int[3] { 4, 2, 1 };
            
            var result = MinPathSum(grid);
        }
        static int MinPathSum(int[][] grid)
        {
            int x = grid.GetLength(0);
            if (x == 0) return 0;
            int y = grid[0].Length;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (j == 0 && i > 0) grid[i][j] += grid[i - 1][j];
                    else if (i == 0 && j > 0) grid[i][j] += grid[i][j - 1];
                    else if (i > 0 && j > 0) grid[i][j] += Math.Min(grid[i - 1][j], grid[i][j - 1]);
                }
            }
            return grid[x - 1][y - 1];
        }
    }
