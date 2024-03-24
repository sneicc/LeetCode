namespace Total_Cost_to_Hire_K_Workers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TotalCost([1, 2, 4, 1], 3, 3));
            Console.ReadLine();
        }

        public static long TotalCost(int[] costs, int k, int candidates)
        {
            int len = costs.Length;
            var firstPQ = new PriorityQueue<int, int>();
            var secondPQ = new PriorityQueue<int, int>();
            long ans = 0;
            int j = 0;
            int l = len - 1;

            for (int i = 0; i < k; i++)
            {
                while (firstPQ.Count < candidates && j <= l)
                {
                    firstPQ.Enqueue(costs[j], costs[j]);
                    j++;
                }
                while (secondPQ.Count < candidates && l >= j)
                {
                    secondPQ.Enqueue(costs[l], costs[l]);
                    l--;
                }

                int first = firstPQ.Count > 0 ? firstPQ.Peek() : Int32.MaxValue;
                int second = secondPQ.Count > 0 ? secondPQ.Peek() : Int32.MaxValue;

                if (first <= second)
                {
                    ans += first;
                    firstPQ.Dequeue();
                }
                else
                {
                    ans += second;
                    secondPQ.Dequeue();
                }
            }

            return ans;
        }
    }
}
