class Program
    {
        static void Main(string[] args)
        {
            /*There are two sorted arrays nums1 and nums2 of size m and n respectively.
            Find the median of the two sorted arrays. The overall run time complexity should be O(log (m+n)).
            You may assume nums1 and nums2 cannot be both empty.

            Example 1:
            nums1 = [1, 3]
            nums2 = [2]
            The median is 2.0

            Example 2:
            nums1 = [1, 2]
            nums2 = [3, 4]
            The median is (2 + 3) / 2 = 2.5
            */
            int[] nums1 = { 1, 3 };
            int[] nums2 = { 2 };
            var result = FindMedianSortedArrays(nums1, nums2);
        }
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length)
                return FindMedianSortedArrays(nums2, nums1);
            var x = nums1.Length;
            var y = nums2.Length;
            int low = 0;
            int high = x;
            while (low <= high)
            {
                int partitionX = (low + high) / 2;
                int partitionY = (x + y + 1) / 2 - partitionX;
                int maxLeftX = (partitionX == 0) ? int.MinValue : nums1[partitionX - 1];
                int minRightX = (partitionX == x) ? int.MaxValue : nums1[partitionX];

                int maxLeftY = (partitionY == 0) ? int.MinValue : nums2[partitionY - 1];
                int minRightY = (partitionY == y) ? int.MaxValue : nums2[partitionY];
                if (maxLeftX <= minRightY && maxLeftY <= minRightX)
                {
                    //We have partitioned array at correct place
                    // Now get max of left elements and min of right elements to get the median in case of even length combined array size
                    // or get max of left for odd length combined array size.
                    if ((x + y) % 2 == 0)
                    {
                        return ((double)Math.Max(maxLeftX, maxLeftY) + Math.Min(minRightX, minRightY)) / 2;
                    }
                    else
                    {
                        return (double)Math.Max(maxLeftX, maxLeftY);
                    }
                }
                else if (maxLeftX > minRightY)
                { //we are too far on right side for partitionX. Go on left side.
                    high = partitionX - 1;
                }
                else
                { //we are too far on left side for partitionX. Go on right side.
                    low = partitionX + 1;
                }
            }
            return 0; // this line is never executed, just for the C# syntax
        }
    }
