class Program
    {
        static void Main(string[] args)
        {
            string digits = "23";
            var result = LetterCombinations(digits);
        }
        static IList<string> LetterCombinations(string digits)
        {
            List<string> result = new List<string>();
            if (digits == null || digits.Length == 0) return result;
            string[] mapping = { "0", "1", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            Combine("", digits.ToCharArray(), 0, mapping, result);
            return result;
        }
        static void Combine(string prefix, char[] digits, int start, string[] mapping, List<string> result)
        {
            if (start == digits.Length)
            { 
                result.Add(prefix);
                return;
            }
            string letters = mapping[digits[start] - '0']; 
            foreach (char letter in letters.ToCharArray())
            {
                Combine(prefix + letter, digits, start + 1, mapping, result); // add letter to prefix
            }
        }
    }
