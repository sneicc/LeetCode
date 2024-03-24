namespace Kth_Largest_Element_in_an_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static int FindKthLargest(int[] nums, int k)
        {
            var pq = new PriorityQueue<int, int>();
            int toRemove = nums.Length - k;

            for (int i = 0; i < nums.Length; i++)
            {
                pq.Enqueue(nums[i], nums[i]);
            }

            for(int i = 0; i < toRemove; i++)
            {
                pq.Dequeue();
            }

            return pq.Dequeue();
        }
    }
}
