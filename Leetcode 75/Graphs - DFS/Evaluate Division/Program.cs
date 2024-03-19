using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Xml.Serialization;

namespace Evaluate_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalcEquation([["a", "b"], ["b", "c"]], [2.0, 3.0], [["a", "c"], ["b", "a"], ["a", "e"], ["a", "a"], ["x", "x"]]);
            Console.ReadLine();
        }

        public static double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
        {
            var adj = new Dictionary<string, List<(string connection, double weight)>>();
            var ans = new double[queries.Count];

            var len = equations.Count;
            for (int i = 0; i < len; i++)
            {
                string leftOperand = equations[i][0];
                string rightOperand = equations[i][1];

                adj[leftOperand] = adj.GetValueOrDefault(leftOperand, new List<(string connection, double weight)>());
                adj[leftOperand].Add((rightOperand, values[i]));

                adj[rightOperand] = adj.GetValueOrDefault(rightOperand, new List<(string connection, double weight)>());
                adj[rightOperand].Add((leftOperand, 1 / values[i]));
            }

            len = queries.Count;
            for (int i = 0; i < len; i++)
            {
                if (!adj.ContainsKey(queries[i][0]) || !adj.ContainsKey(queries[i][1]))
                {
                    ans[i] = -1;
                }
                else
                {
                    ans[i] = DFS(new HashSet<string>(), queries[i][0], queries[i][1]);
                }
            }

            return ans;

            double DFS(HashSet<string> visited, string current, string target, double ans = 1)
            {
                if (!visited.Add(current))
                {
                    return -1;
                }
                if (current == target)
                {
                    return ans;
                }

                foreach (var (connecton, weight) in adj[current])
                {
                    double dfsResult = DFS(visited, connecton, target, ans * weight);
                    if (dfsResult != -1)
                    {
                        return dfsResult;
                    }
                }

                return -1;
            }
        }
    }
}
