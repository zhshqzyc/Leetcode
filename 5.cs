class Program
    {
       
        static void Main(string[] args)
        {
            string s = "babad";
            var result = LongestPalindrome(s);
        }
        public static string LongestPalindrome(string s)
        {
            int maxLength = 0, startIndex = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int start = i, end = i;
                while (end < s.Length - 1 && s[start] == s[end + 1])
                    end++;

                while (end < s.Length - 1 && start > 0 && s[start - 1] == s[end + 1])
                {
                    start--;
                    end++;
                }
                if (maxLength < end - start + 1)
                {
                    maxLength = end - start + 1;
                    startIndex = start;
                }
            }
            return s.Substring(startIndex, maxLength);

        }
        private static int findLengthOfPalindromic(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[right] == s[left])
            {
                left--;
                right++;
            }
            return right - left - 1;
        }
    }
