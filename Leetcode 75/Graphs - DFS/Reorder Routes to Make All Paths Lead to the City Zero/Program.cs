namespace Reorder_Routes_to_Make_All_Paths_Lead_to_the_City_Zero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        /*public static int MinReorder(int n, int[][] connections)
        {
            int len = connections.Length;
            int ans = 0;
            var visited = new bool[len];

            for (int i = 0; i < len; i++)
            {
                if (!visited[i] && (connections[i][0] == 0 || connections[i][1] == 0))
                {
                    DFS(connections, visited, i, 0, ref ans);
                }
            }

            return ans;
        }

        public static void DFS(int[][] connections, bool[] visited, int road, int city, ref int ans)
        {
            if (visited[road])
            {
                return;
            }

            visited[road] = true;
            int toGo;

            if (connections[road][1] == city)
            {
                toGo = connections[road][0];
            }
            else
            {
                ans++;
                toGo = connections[road][1];
            }

            for (int i = 0; i < connections.Length; i++)
            {
                if (!visited[i] && (connections[i][0] == toGo || connections[i][1] == toGo))
                {
                    DFS(connections, visited, i, toGo, ref ans);
                }
            }
        } */

        public int MinReorder(int n, int[][] connections)
        {
            int ans = 0;
            var graph = new Dictionary<int, List<(int, bool)>>();
            var visited = new HashSet<int>();

            foreach (var connection in connections)
            {
                var cityA = connection[0];
                var cityB = connection[1];

                graph[cityA] = graph.GetValueOrDefault(cityA, new List<(int, bool)>());
                graph[cityA].Add((cityB, true));

                graph[cityB] = graph.GetValueOrDefault(cityB, new List<(int, bool)>());
                graph[cityB].Add((cityA, false));
            }

            DFS(0, ref ans, visited, graph);

            return ans;
        }

        public void DFS(int city, ref int ans, HashSet<int> visited, Dictionary<int, List<(int, bool)>> graph)
        {
            visited.Add(city);

            foreach (var (node, direction) in graph[city])
            {
                if (visited.Contains(node))
                {
                    continue;
                }

                if (direction)
                {
                    ans++;
                }

                DFS(node, ref ans, visited, graph);
            }
        }
    }
}
