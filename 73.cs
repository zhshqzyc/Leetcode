class Program
    {
        static void Main(string[] args)
        {
            int[][] grid = new int[3][];
            grid[0] = new int[3] { 1, 1, 1 };
            grid[1] = new int[3] { 1, 0, 1 };
            grid[2] = new int[3] { 1, 1, 1 };
            SetZeroes(grid);
        }

        static void SetZeroes(int[][] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix[0].Length;
            bool firstRowZero = false;
            bool firstColZero = false;
            for (int row = 0; row < rows; row++)
            {
                if (matrix[row][0] == 0)
                {
                    firstColZero = true;
                }
            }
            for (int col = 0; col < cols; col++)
            {
                if (matrix[0][col] == 0)
                {
                    firstRowZero = true;
                }
            }
            for (int row = 1; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if(matrix[row][col] == 0)
                    {
                        matrix[0][col] = 0;
                        matrix[row][0] = 0;
                    }
                }
            }
            for (int col = 1; col < cols; col++)
            {
                if(matrix[0][col] == 0)
                {
                    for (int row = 1; row < rows; row++)
                    {
                        matrix[row][col] = 0;
                    }
                }
            }
            for (int row = 1; row < rows; row++)
            {
                if(matrix[row][0] == 0)
                {
                    for (int col = 1; col < cols; col++)
                    {
                        matrix[row][col] = 0;
                    }
                }
            }
            if (firstRowZero)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[0][col] = 0;
                }
            }
            if(firstColZero)
                for (int row = 0; row < rows; row++)
                {
                    matrix[row][0] = 0;
                }
        }
    }
