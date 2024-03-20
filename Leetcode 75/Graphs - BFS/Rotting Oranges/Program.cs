namespace Rotting_Oranges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrangesRotting([[2, 1, 1], [1, 1, 0], [0, 1, 1]]);
        }

        public static int OrangesRotting(int[][] grid)
        {
            var direction = new int[] { 0, 1, 0, -1, 0 };
            int minutes = 0;
            int oranges = 0;

            var queue = new Queue<(int, int)>();

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 2)
                    {
                        for (int k = 0; k < direction.Length - 1; k++)
                        {
                            queue.Enqueue((i + direction[k], j + direction[k + 1]));
                        }
                    }
                    if (grid[i][j] == 1) oranges++;
                }
            }

            while(true)
            {
                int queueLen = queue.Count;
                for (int l = 0; l < queueLen; l++)
                {
                    var (i, j) = queue.Dequeue();

                    if (i < 0 || i >= grid.Length) continue;
                    if (j < 0 || j >= grid[0].Length) continue;
                    if (grid[i][j] != 1) continue;

                    grid[i][j] = 2;
                    oranges--;
                    

                    for (int k = 0; k < direction.Length - 1; k++)
                    {
                        queue.Enqueue((i + direction[k], j + direction[k + 1]));
                    }
                }

                if (!queue.Any()) break;

                minutes++;
            }

            return oranges == 0 ? minutes : -1;
        }
    }
}
