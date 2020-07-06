class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { "flower", "flow", "flight" };
            var result = LongestCommonPrefix(strs);
        }

        static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";
            string pre = strs[0];
            for (int i = 1; i < strs.Length; i++)
                while (strs[i].IndexOf(pre) != 0)
                    pre = pre.Substring(0, pre.Length - 1);
            return pre;
        }
    }
