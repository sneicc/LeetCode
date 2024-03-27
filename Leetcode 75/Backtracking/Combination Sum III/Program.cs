namespace Combination_Sum_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public IList<IList<int>> CombinationSum3(int k, int n)
        {
            var ans = new List<IList<int>>();
            var linkedList = new LinkedList<int>();

            CreateCombinations(0, 1, 0);

            return ans;

            void CreateCombinations(int depth, int firstValue, int sum)
            {
                if (sum > n) return;
                if (depth >= k)
                {
                    if(sum == n) ans.Add(new List<int>(linkedList));
                    return;
                }

                for (int i = firstValue; i < 10; i++)
                {
                    linkedList.AddLast(i);
                    CreateCombinations(depth + 1, i + 1, sum + i);
                    linkedList.RemoveLast();
                }
            }
        }
    }
}
