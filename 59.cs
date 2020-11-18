class Program
    {
        static void Main(string[] args)
        {
            var result = GenerateMatrix(3);
        }
        static int[][] GenerateMatrix(int n)
        {
            int[][] output = new int[n][];

            if (n==0) return output;
            for (int i = 0; i < n; i++)
            {
                output[i] = new int[n];
            }
            int top = 0;
            int bottom = n - 1;
            int left = 0;
            int right = n - 1;
            int num = 1;
            while(top <= bottom && left<= right)
            {
                for (int j = left; j <= right; j++)
                {
                    output[top][j] = num++;
                }
                top++;
                for (int i = top; i <= bottom; i++)
                {
                    output[i][right] = num++;
                }
                right--;
                for (int j = right; j >= left; j--)
                {
                    output[bottom][j] = num++;
                }
                bottom--;
                for (int i = bottom; i >= top; i--)
                {
                    output[i][left] = num++;
                }
                left++;
            }
            return output;
        }
    }
