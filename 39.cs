class Program
    {
        static void Main(string[] args)
        {
            int[] candidates = {2,6, 3, 7 };
            int target = 7;
            var res = CombinationSum(candidates, target);
        }
        static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            Array.Sort(candidates);
            return Combinations(candidates, 0, target).Select(c => (IList<int>)c.ToList()).ToList();
        }
        static IEnumerable<IEnumerable<int>> Combinations(int[] candidates, int suffix, int target)
        {
            for (int i = suffix; i < candidates.Length; i++)
            {
                var c = candidates[i];

                if (target > c)
                {
                    foreach (var combination in Combinations(candidates, i, target - c))
                    {
                        yield return new[] { c }.Concat(combination);
                    }
                }
                else if (target == c)
                {
                    yield return new[] { c };
                }
            }
        }
    }
