class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] {5, 1 ,3 };
            int target = 3;
            var res = Search(nums, target);
        }
        static bool Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target) return true;
                while (left < mid && nums[left] == nums[mid]) left = left + 1;
                while (mid < right && nums[right] == nums[mid]) right -= 1;
                if(nums[left] <= nums[mid])
                {
                    if (nums[left] <= target && target < nums[mid]) right = mid - 1;
                    else left = mid + 1;
                }
                else
                {
                    if (nums[mid] < target && target <= nums[right]) left = mid + 1;
                    else right = mid - 1;
                }
            }
            return false;
        }
    }
