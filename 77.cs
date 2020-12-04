class Program
    {
        static void Main(string[] args)
        {
            var result = Combine(4,2);
        }
        static IList<IList<int>> Combine(int n, int k)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (n <= 0 || k <= 0 || k > n)
                return result;
            List<int> list = new List<int>();
            help(1, n, k, list, result);
            return result;
        }

        private static void help(int start, int n, int k, List<int> list, IList<IList<int>> result)
        {
            if (k == 0)
            {
                result.Add(new List<int>(list));
                return;
            }
            for (int i = start; i <= n; i++)
            {
                list.Add(i);
                help(i + 1, n, k - 1, list, result);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
