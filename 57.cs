class Program
    {
        static void Main(string[] args)
        {
            int[][] intervals = new int[5][];
            intervals[0] = new int[2] { 1, 2 };
            intervals[1] = new int[2] { 3, 5 };
            intervals[2] = new int[2] { 6, 7 };
            intervals[3] = new int[2] { 8, 10 };
            intervals[4] = new int[2] { 12, 16 };
            int[] newInterval = new int[2] {4, 8 };
            var result = Insert(intervals, newInterval);
        }

        static int[][] Insert(int[][] intervals, int[] newInterval)
        {
            List<int[]> output = new List<int[]>();
            for (int i = 0; i < intervals.Length; i++)
            {
                var curr = intervals[i];
                if (newInterval == null || curr[curr.Length - 1] < newInterval[0])
                    output.Add(curr);
                else if (newInterval[newInterval.Length-1] < curr[0])
                {
                    output.Add(newInterval);
                    newInterval = null;
                    output.Add(curr);
                }
                else
                {
                    newInterval[0] = Math.Min(newInterval[0], curr[0]);
                    newInterval[newInterval.Length - 1] = Math.Max(newInterval[newInterval.Length - 1], curr[curr.Length - 1]);
                }
            }
            if (newInterval == null) return output.ToArray();
            else
                output.Add(newInterval);
            return output.ToArray();
        }
    }
