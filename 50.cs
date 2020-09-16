class Program
    {
        static void Main(string[] args)
        {
            double x = 2.0;
            int n = 10;
            var result = MyPow(x, n);
        }
        static double MyPow(double num, int power)
        {
            if (power == 0 || num == 1) return 1;
            if (power == 1) return num;
            if (power < 0) return 1 / (num * MyPow(num, -(power + 1)));
            double res = 1;
            while (power > 1)
            {
                if (power % 2 == 1)
                {
                    res *= num;
                }
                num = num * num;
                power /= 2;
            }
            res *= num;
            return res;
        }
    }
