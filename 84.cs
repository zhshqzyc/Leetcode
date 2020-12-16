class Program
    {
        static void Main(string[] args)
        {
            int[] heights = new int[] { 2, 1, 5, 6, 2, 3 };
            var result = LargestRectangleArea(heights);
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
