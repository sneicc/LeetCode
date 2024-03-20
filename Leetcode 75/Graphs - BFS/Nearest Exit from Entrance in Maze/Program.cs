namespace Nearest_Exit_from_Entrance_in_Maze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NearestExit(([
                ['.', '+']]), [0, 0]));
            Console.ReadLine();
        }

        public static int NearestExit(char[][] maze, int[] entrance)
        {
            var dir = new int[] {0, 1, 0, -1, 0};
            var queue = new Queue<(int, int, int)>();
            queue.Enqueue((entrance[0], entrance[1], 0));

            while(queue.Any())
            {
                var (i, j, dist) = queue.Dequeue();

                if (i < 0 || i == maze.Length) continue;
                if (j < 0 || j == maze[0].Length) continue;
                if (maze[i][j] != '.') continue;

                maze[i][j] = '_';

                if (dist > 0 && (i == 0 || i == maze.Length - 1)) return dist;
                if (dist > 0 && (j == 0 || j == maze[0].Length - 1)) return dist;

                for (int k = 0; k < dir.Length - 1; k++)
                {
                    queue.Enqueue((i + dir[k], j + dir[k + 1], dist + 1));
                }
            }

            return -1;
        }
    }

    /*
    ['+','.','+','+','+','+','+'],
    ['+','.','+','.','.','.','+'],
    ['+','.','+','.','+','.','+'],
    ['+','.','.','.','+','.','+'],
    ['+','+','+','+','+','.','+']
    
    ['+','.','+','+','+','+','+'],
    ['+','.','+','.','.','.','+'],
    ['+','.','+','.','+','.','+'],
    ['+','.','.','.','.','.','+'],
    ['+','+','+','+','.','+','.']
    */
}
