using System;

namespace _11
{
    class ContainerWithMostWater
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            var area = MaxArea(input);
            Console.WriteLine(area);
        }

        static int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int max = 0;
            while(left < right)
            {
                int area = (right - left) * (height[right] > height[left] ? height[left] : height[right]);
                max = Math.Max(max, area);
                if (height[left] < height[right])
                    left++;
                else
                    right--;
            }
            return max;
        }
    }
}
