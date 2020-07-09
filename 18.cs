class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 0, -1, 0, -2, 2 };
            var result = FourSum(nums, 0);
        }
        static IList<IList<int>> FourSum(int[] nums, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 3; i++)
            {
                if (nums[i] + nums[i + 1] + nums[i + 2] + nums[i + 3] > target)
                { 
                    break;
                }
                if (nums[i] + nums[nums.Length - 1] + nums[nums.Length - 2] + nums[nums.Length - 3] < target)
                {
                    continue; 
                }
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue; // avoid duplicated value.
                }
                for (int j = i + 1; j < nums.Length - 2; j++)
                {
                    if (nums[i] + nums[j] + nums[j + 1] + nums[j + 2] > target)
                    {
                        break; 
                    }
                    if (nums[i] + nums[j] + nums[nums.Length - 1] + nums[nums.Length - 2] < target)
                    { 
                        //j is too small
                        continue;
                    }
                    if (j > i + 1 && nums[j] == nums[j - 1])
                    { 
                        //here should be j > i + 1, because j can be equal to i at j = i + 1
                        continue;  // this value is already visited, skip to avoid duplicated value.
                    }
                    //Two pointer.
                    int start = j + 1;
                    int end = nums.Length - 1;

                    while (start < end)
                    {
                        int sum = nums[i] + nums[j] + nums[start] + nums[end];

                        if (sum == target)
                        {
                            var temp = new List<int>();
                            temp.Add(nums[i]);
                            temp.Add(nums[j]);
                            temp.Add(nums[start]);
                            temp.Add(nums[end]);
                            result.Add(temp);

                            while (start < end && nums[start] == nums[start + 1])
                            {
                                start++; // skip duplicated value.
                            }
                            while (start < end && nums[end] == nums[end - 1])
                            {
                                end--;
                            }
                            start++;
                            end--;
                        }
                        else if (sum < target)
                        {
                            start++;
                        }
                        else
                        {
                            end--;
                        }
                    }
                }
            }
            return result;
        }
    }
