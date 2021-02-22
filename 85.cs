using System;

namespace _85
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] matrix = new char[4][];
            matrix[0] = new char[5] { '1', '0', '1', '0', '0' };
            matrix[1] = new char[5] { '1', '0', '1', '1', '1' };
            matrix[2] = new char[5] { '1', '1', '1', '1', '1' };
            matrix[3] = new char[5] { '1', '0', '0', '1', '0' };
            //char[][] matrix = new char[2][];
            //matrix[0] = new char[2] { '0', '1' };
            //matrix[1] = new char[2] { '1', '0' };
            var result = MaximalRectangle(matrix);
        }

        static int MaximalRectangle(char[][] matrix)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0) return 0;
            int rowCount = matrix.Length;
            int colCount = matrix[0].Length;
            int[] heights = new int[colCount];
            int max = 0;
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    if (matrix[i][j] == '1')
                    {
                        heights[j]++;
                    }
                    else
                    {
                        heights[j] = 0;
                    }

                }
                int area = LargestRectangleArea(heights);
                max = Math.Max(max, area);
            }

            return max;
        }
        static int LargestRectangleArea(int[] heights)
        {
            if (heights.Length == 0) return 0;
            if (heights.Length == 1) return heights[0];
            var area = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                if (i == heights.Length - 1 || heights[i] > heights[i + 1])
                {
                    int minHeight = heights[i];
                    area = Math.Max(area, minHeight);
                    for (int j = i - 1; j >= 0; j--)
                    {
                        minHeight = Math.Min(minHeight, heights[j]);
                        area = Math.Max(area, minHeight * (i - j + 1));
                    }
                }
            }
            return area;
        }
    }
}
