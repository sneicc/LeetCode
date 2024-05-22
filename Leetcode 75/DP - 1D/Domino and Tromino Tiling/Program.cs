namespace Domino_and_Tromino_Tiling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int NumTilings(int n)
        {
            int mod = (int)(1e9 + 7);
            var dict = new Dictionary<(int, bool), long>();
            return (int)Solve(0, false);

            long Solve(int i, bool gap) 
            {
                if (i > n) return 0;
                if (i == n) return gap ? 0 : 1;
                if (dict.ContainsKey((i, gap))) return dict[(i, gap)];
                if (gap) return dict[(i, gap)] = (Solve(i + 1, false) + Solve(i + 1, true)) % mod;

                return dict[(i, gap)] = (Solve(i + 1, false) + Solve(i + 2, false) + 2L * Solve(i + 2, true)) % mod;                
            }
        }
    }
}
