class Program
    {
        static void Main(string[] args)
        {
            int[][] intervals = new int[4][];
            intervals[0] = new int[2] { 1, 3 };
            intervals[1] = new int[2] { 2, 6 };
            intervals[2] = new int[2] { 8, 10 };
            intervals[3] = new int[2] { 15, 18 };
            var res = Merge(intervals);
        }
        static int[][] Merge(int[][] intervals)
        {
            if (intervals.GetLength(0) <= 1)
                return intervals;
            //First sort the intervals based on start time.
            Array.Sort(intervals, (i, j) => i[0].CompareTo(j[0]));
            List<int[]> output = new List<int[]>();
            var current_interval = intervals[0];
            output.Add(current_interval);
            for (int i = 1; i < intervals.GetLength(0); i++)
            {
                var current_begin = current_interval[0];
                var current_end = current_interval[1];
                var next_begin = intervals[i][0];
                var next_end = intervals[i][1];
                if(current_end >= next_begin)
                {
                    current_interval[1] = Math.Max(current_end, next_end);
                }
                else
                {
                    current_interval = intervals[i];
                    output.Add(current_interval);
                }
               
            }
            return output.ToArray();
        }
    }
