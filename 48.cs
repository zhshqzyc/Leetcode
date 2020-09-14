class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[3][];
            matrix[0] = new int[3] { 1, 2, 3 };
            matrix[1] = new int[3] { 4, 5, 6 };
            matrix[2] = new int[3] { 7, 8, 9 };
            Rotate(matrix);
        }
        static void Rotate(int[][] matrix)
        {
            int N = matrix.Length;
            for (int i = 0; i < N; i++)
            {
                for (int j = i; j < N; j++)
                {
                    if (i != j)
                    {
                        int temp = matrix[i][j];
                        matrix[i][j] = matrix[j][i];
                        matrix[j][i] = temp;
                    }
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N / 2; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[i][N - 1 - j];
                    matrix[i][N - 1 - j] = temp;
                }
            }
        }
    }
