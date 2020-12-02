class Program
    {
        static void Main(string[] args)
        {
            //int[][] matrix = new int[3][];
            //matrix[0] = new int[4] { 1, 3, 5, 7 };
            //matrix[1] = new int[4] { 10, 11, 16, 20 };
            //matrix[2] = new int[4] { 23, 30, 34, 60 };
            //int target = 3;
            int[][] matrix = new int[1][];
            matrix[0] = new int[3] { 1, 3, 5 };
            int target = 1;
           
            var result = SearchMatrix(matrix, target);
        }
        static bool SearchMatrix(int[][] matrix, int target)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0) return false;
            int endRow = matrix.GetLength(0) - 1;
            int endCol = matrix[0].Length - 1;
            for (int row = 0; row <= endRow; row++)
            {
                int lastElement = matrix[row][endCol];
                if (target > lastElement && endRow >= 1)
                    continue; // next row
                if (target == lastElement) return true;
                int start = 0;
                int end = endCol;
                while (start < end)
                {
                    int mid = start + (end - start) / 2;
                    if (matrix[row][mid] == target) return true;
                    else if (matrix[row][mid] < target) start = mid + 1;
                    else end = mid - 1;
                }
                if (start == end && matrix[row][start] == target) return true;
            }

            return false;
        }
    }
