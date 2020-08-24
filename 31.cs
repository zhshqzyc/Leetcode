class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 4, 7, 5 };
            NextPermutation(nums);
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }
        static void NextPermutation(int[] nums)
        {
            //   STEP 1: From Right to Left, find the PEAK
            //                  4,7,5 —> 7 is the PEAK
            //   STEP 2: Replace the number before PEAK(i - 1) with minimum larger number on the right of the PEAK
            //                  4,7,5 —> 5,7,4
            //   STEP 3: Reverse the numbers starting at the PEAK and going back to the end of the array
            //    5,7,4 —> 5,4,7
            int PEAK = nums.Length - 1;

            // STEP 1: Find  PEAK
            while (PEAK > 0 && nums[PEAK] <= nums[PEAK - 1]) PEAK--;


            // STEP 2: Replace
            if (PEAK <= 0)
            { //first element is the PEAK
              // do nothing.
            }
            else
            {
                int i = nums.Length - 1;
                while (i >= 0 && nums[i] <= nums[PEAK - 1]) i--;
                if (i >= 0)
                {
                    Swap(nums, i, PEAK - 1);
                }
            }

            // STEP 3: reverse
            int l = PEAK;
            int r = nums.Length - 1;
            while (l < r)
            {
                Swap(nums, l++, r--);
            }
        }

        static void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
