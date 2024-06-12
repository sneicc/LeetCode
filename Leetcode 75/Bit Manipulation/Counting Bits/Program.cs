namespace Counting_Bits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int[] CountBits(int n)
        {
            var ans = new int[n + 1];

            for (int i = 0; i <= n; i++)
            {
                int tmp = i;
                int ones = 0;
                while (tmp / 2 != 0)
                {
                    ones += tmp % 2;
                    tmp = tmp / 2;
                }
                if (tmp == 1) ones++;

                ans[i] = ones;
            }

            return ans;
        }
    }
}
