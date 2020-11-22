class Program
    {
        static void Main(string[] args)
        {
            int[][] obstacleGrid = new int[5][];
            obstacleGrid[0] = new int[3] { 0, 0, 0 };
            obstacleGrid[1] = new int[3] { 0, 0, 0 };
            obstacleGrid[2] = new int[3] { 0, 1, 0 };
            obstacleGrid[3] = new int[3] { 0, 0, 0 };
            obstacleGrid[4] = new int[3] { 0, 0, 0 };

            var result = UniquePathsWithObstacles(obstacleGrid);
        }
        static int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            int m = obstacleGrid.GetLength(0);
            int n = obstacleGrid[0].Length;
            int[][] paths = new int[m][];
            for (int i = 0; i < m; i++)
            {
                paths[i] = new int[n];
            }
            // first column
            for (int i = 0; i < m; i++)
            {
                if (obstacleGrid[i][0] != 1)
                {
                    paths[i][0] = 1;
                }
                else
                {
                    break;
                }
            }

            // first row
            for (int j = 0; j < n; j++)
            {
                if (obstacleGrid[0][j] != 1)
                {
                    paths[0][j] = 1;
                }
                else
                {
                    break;
                }
            }
            // for spaces not at first row or first column
            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (obstacleGrid[i][j] != 1)
                    {
                        paths[i][j] = paths[i - 1][j] + paths[i][j - 1];
                    }
                }
            }

            return paths[m - 1][n - 1];
        }
    }
