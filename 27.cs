class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
            var result = RemoveElement(nums, 2);
        }
        static int RemoveElement(int[] A, int elem)
        {
            int m = 0;
            for (int i = 0; i < A.Length; i++)
            {

                if (A[i] != elem)
                {
                    A[m] = A[i];
                    m++;
                }
            }

            return m;
        }
    }
