class Program
    {
        static void Main(string[] args)
        {
            int[] height = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            var result = Trap(height);
        }
        static int Trap(int[] height)
        {
            int peak_index = 0;
            for (int i = 0; i < height.Length; i++)
            {
                if(height[i] > height[peak_index])
                {
                    peak_index = i;
                }
            }
            int leftMostBar = 0;
            int water = 0;
            for (int i = 0; i < peak_index; i++)
            {
                if(height[i] > leftMostBar)
                {
                    leftMostBar = height[i];
                }
                else
                {
                    water += leftMostBar - height[i];
                }
            }
            int rightMostBar = 0;
            for (int i = height.Length - 1; i > peak_index; i--)
            {
                if(height[i] > rightMostBar)
                {
                    rightMostBar = height[i];
                }
                else
                {
                    water += rightMostBar - height[i];
                }
            }
            return water;
        }
    }
