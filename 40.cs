class Program
    {
        static void Main(string[] args)
        {
            int[] candidates = { 10, 1, 2, 7, 6, 1, 5 };
            int target = 8;
            var res = CombinationSum2(candidates, target);
        }
        static IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            var results = new List<IList<int>>();
            if (candidates == null || candidates.Length == 0) return results;
            Array.Sort(candidates);
            List<int> combination = new List<int>();
            ToFindCombinationsToTarget(candidates, results, combination, 0, target);
            return results;
        }

        private static void ToFindCombinationsToTarget(int[] candidates, List<IList<int>> results, List<int> combination, int startIndex, int target)
        {
            if (target == 0)
            {
                results.Add(new List<int>(combination));
                return;
            }
            for (int i = startIndex; i < candidates.Length; i++)
            {
                if (i != startIndex && candidates[i] == candidates[i - 1])
                    continue;
                if (candidates[i] > target)
                    break;
                combination.Add(candidates[i]);
                ToFindCombinationsToTarget(candidates, results, combination, i + 1, target - candidates[i]);
                combination.RemoveAt(combination.Count - 1);
            }
        }
    }
