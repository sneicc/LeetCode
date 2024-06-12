namespace Minimum_Flips_to_Make_a_OR_b_Equal_to_c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int MinFlips(int a, int b, int c)
        {
            int ans = 0;
            while(a != 0 || b != 0 || c != 0)
            {
                int aBit = a % 2;
                int bBit = b % 2;
                int cBit = c % 2;
                
                if (cBit == 0)
                {
                    if ((aBit & bBit) == 1) ans += 2;
                    else if ((aBit | bBit) == 1) ans += 1;
                }
                else 
                {
                    if ((aBit | bBit) == 0) ans += 1;
                }

                a /= 2;
                b /= 2;
                c /= 2;
            }

            return ans;
        }
    }
}
