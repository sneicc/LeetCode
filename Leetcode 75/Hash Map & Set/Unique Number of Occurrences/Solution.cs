namespace Unique_Number_of_Occurrences
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine(UniqueOccurrences([1, 2, 2, 1, 1, 3]));
        }

        public static bool UniqueOccurrences(int[] arr)
        {
            var dict = new Dictionary<int, int>();
            foreach (int i in arr)
            {
                if(!dict.TryAdd(i, 1))
                {
                    dict[i] = dict[i] + 1;
                }
            }

            var hashSet = new HashSet<int>();
            foreach (var item in dict.Values)
            {
                if (!hashSet.Add(item))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
