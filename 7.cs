class Program
    {
        static void Main(string[] args)
        {
            var result = Reverse(321);
        }

        static int Reverse(int x)
        {
            bool negative = false;
            if(x<0)
            {
                negative = true;
                x = x * (-1);
            }
            long reversed = 0;
            while (x > 0)
            {
                reversed = (reversed * 10) + x % 10;
                x /= 10;
            }
            if (reversed > int.MaxValue)
                return 0;
            return negative ? (int)(-1 * reversed) : (int)reversed;
        }
    }
