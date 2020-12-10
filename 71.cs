class Program
    {
        static void Main(string[] args)
        {
            var result = SimplifyPath("/home//foo/");
        }
        static string SimplifyPath(string path)
        {
            if (String.IsNullOrEmpty(path))
                return "";
            var strs = path.Split('/');
            Stack<string> s = new Stack<string>();
            foreach (var item in strs)
            {
                if (String.IsNullOrWhiteSpace(item) || item == ".")
                    continue;
                if (item == "..")
                {
                    if (s.Count > 0) s.Pop();
                }
                else
                    s.Push("/" + item);
            }
            string res = "";
            if (s.Count == 0) return "/";
            while (s.Count > 0)
            {
                res = s.Pop() + res;
            }
            return res;
        }
    }
