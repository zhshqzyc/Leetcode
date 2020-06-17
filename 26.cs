        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0 || nums.Length == 1) return nums.Length;
            int i = 0, j = 1;
            while (j < nums.Length)
            {
                if (nums[i] == nums[j]) j++;
                else
                {
                    i++;
                    nums[i] = nums[j];
                    j++;
                }
            }
            return ++i;
        }
