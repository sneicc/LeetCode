namespace Maximum_Subsequence_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxScore([1, 3, 3, 2], [2, 1, 3, 4], 3));          
            Console.ReadLine();
        }

        public static long MaxScore(int[] nums1, int[] nums2, int k)
        {
            int len = nums1.Length;
            long ans = 0;
            var priorityQueue = new PriorityQueue<int, int>();

            Array.Sort(nums2, nums1);

            long sum = 0;
            for (int i = len - 1; i >= 0; i--)
            {
                priorityQueue.Enqueue(nums1[i], nums1[i]);
                sum += nums1[i];

                if (priorityQueue.Count > k)
                {
                    sum -= priorityQueue.Dequeue();
                }

                if (priorityQueue.Count == k)
                {
                    ans = Math.Max(ans, sum * nums2[i]);
                }
            }

            return ans;
        }
    }
}
