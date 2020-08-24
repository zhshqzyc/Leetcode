class Program
    {
        static void Main(string[] args)
        {
            var num1 = "123";
            var num2 = "456";
            var output = Multiply(num1, num2);
        }
        static string Multiply(string num1, string num2)
        {
            if (num1.Length == 0 || num2.Length == 0) return "0";
            var len1 = num1.Length;
            var len2 = num2.Length;
            int[] result = new int[len1 + len2];
            for(int i=len1-1;i>=0;i--)
            {
                for(int j = len2 - 1; j >= 0; j--)
                {
                    int mul = (num1[i] - '0') * (num2[j] - '0');
                    int posLow = i + j + 1;
                    int posHigh = i + j;
                    mul += result[posLow];
                    result[posLow] = mul % 10;
                    result[posHigh] += mul / 10;
                }
            }
            StringBuilder sb = new StringBuilder();
            foreach (var res in result)
            {
                if (!(sb.Length == 0 && res == 0)) sb.Append(res);
            }
            return (sb.Length == 0) ? "0" : sb.ToString();
        }
    }
