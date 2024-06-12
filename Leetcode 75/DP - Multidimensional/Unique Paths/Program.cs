namespace Unique_Paths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int UniquePaths(int m, int n)
        {
            var memo = new Dictionary<(int, int), int>();
            return Solve(0, 0);

            int Solve(int x, int y)
            {
                if (x == m - 1 && y == n - 1) return 1;   
                if (x >= m || y >= n) return 0;
                if (memo.ContainsKey((x, y))) return memo[(x, y)];

                return memo[(x, y)] = Solve(x + 1, y) + Solve(x, y + 1);
            }
        }
    }
}
