namespace TestProject1
{
    class MaxOfNumber
    {
        public int Max(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            if (b > c && b > c)
            {
                return b;
            }
            return c;
        }
    }
}