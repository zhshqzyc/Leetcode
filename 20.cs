class Program
    {
        static void Main(string[] args)
        {
            var result = IsValid("()[]{}");
        }
        static bool IsValid(string s)
        {
            if (s.Length % 2 != 0) return false;
            var k = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(') { k.Push(')'); continue; }
                if (c == '{') { k.Push('}'); continue; }
                if (c == '[') { k.Push(']'); continue; }
                if (k.Count == 0 || c != k.Pop()) return false;
            }
            return k.Count == 0;
        }
    }
