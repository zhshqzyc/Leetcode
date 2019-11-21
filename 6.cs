using System;
using System.Text;

namespace _6
{
    class ZigZag
    {
        static void Main(string[] args)
        {
            var result = Convert("PAYPALISHIRING", 3);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static string Convert(string s, int nRows)
        {
            char[] c = s.ToCharArray();
            int len = c.Length;
            StringBuilder[] sb = new StringBuilder[nRows];
            for (int j = 0; j < sb.Length; j++)
            {
                sb[j] = new StringBuilder();
            }
            int i = 0;
            while (i < len)
            {
                for (int idx = 0; idx < nRows && i < len; idx++)
                {
                    sb[idx].Append(c[i++]); //  vertically down
                }
                for (int idx = nRows - 2; idx >= 1 && i < len; idx--)
                {
                    sb[idx].Append(c[i++]);
                }
            }
            for (int idx = 1; idx < sb.Length; idx++)
            {
                sb[0].Append(sb[idx]);
            }
            return sb[0].ToString();
        }
    }
}
