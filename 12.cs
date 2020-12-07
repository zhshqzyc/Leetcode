class Program
    {
        static void Main(string[] args)
        {
            var r = IntToRoman(1994);
        }
        static string IntToRoman(int num)
        {
            StringBuilder sb = new StringBuilder();
            var keys = new int[] { 1000, 900, 500, 400,
                                   100,  90,  50,  40,
                                   10,   9,   5,   4,
                                   1};
            var values = new string[] {"M", "CM", "D", "CD",
                                       "C", "XC", "L", "XL",
                                       "X", "IX", "V", "IV",
                                       "I"};
            for (int i = 0; i < keys.Length; i++)
            {
                while(num >= keys[i])
                {
                    num -= keys[i];
                    sb.Append(values[i]);
                }
            }
            return sb.ToString();
        }
    }
