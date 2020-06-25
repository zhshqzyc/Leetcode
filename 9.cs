class Program
    {
        static void Main(string[] args)
        {
            var result = IsPalindrome(1234321);
        }

        public static bool IsPalindrome(int x)
        {
            if (x < 0 || (x != 0 && x % 10 == 0)) return false;

            int y = x;
            int res = 0;
            while (y != 0)
            {
                res = res * 10 + y % 10;
                y /= 10;
            }
            return x == res;
        }
    }
