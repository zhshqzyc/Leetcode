class Program
    {
        static void Main(string[] args)
        {
            string haystack = "mississippi", needle = "issip";
            var result = StrStr(haystack, needle);
        }

        static int StrStr(string haystack, string needle)
        {
            int hLength = haystack.Length;
            int nLength = needle.Length;
            if (nLength == 0) return 0;
            if (hLength == 0) return -1; // empty string
            
            if (hLength < nLength) return -1; // needle's length is greater than haystack's length
            if (hLength == nLength && haystack[0] != needle[0]) return -1; // same length but the first char is not same, just stop
            else
            {
                for (int i = 0; i < hLength; i++)
                {
                    // no enough places for needle after i
                    if (i + nLength > hLength) break;

                    for (int j = 0; j < nLength; j++)
                    {
                        if (haystack[i + j] != needle[j])
                            break;
                        if (j == nLength - 1)
                            return i;
                    }
                }

                return -1;
            }
        }
    }
