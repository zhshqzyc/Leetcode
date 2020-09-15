class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
            var result = GroupAnagrams(strs);
        }
        static List<IList<string>> GroupAnagrams(string[] strs)
        {
            List<IList<string>> retList = new List<IList<string>>();
            if (strs == null || strs.Length == 0) return retList;

            var dict = new Dictionary<string, IList<string>>();
       
            for (int i = 0; i < strs.Length; i++)
            {
                var array = strs[i].ToCharArray();
                Array.Sort(array);
                var temp = new string(array);
                if (dict.ContainsKey(temp))
                    dict[temp].Add(strs[i]);
                else
                    dict.Add(temp, new List<string> { strs[i] });
            }
            return dict.Values.ToList();
        }
    }
