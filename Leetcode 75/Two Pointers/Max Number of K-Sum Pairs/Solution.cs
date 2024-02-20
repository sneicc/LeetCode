namespace Max_Number_of_K_Sum_Pairs
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxOperations([2, 5, 4, 4, 1, 3, 4, 4, 1, 4, 4, 1, 2, 1, 2, 2, 3, 2, 4, 2], 3));

            Console.ReadLine();
        }

        public static int MaxOperations(int[] nums, int k)
        {
            int opCount = 0;
            int leftIndex = 0;
            int rightIndex = nums.Length - 1;

            Array.Sort(nums);

            while (leftIndex < rightIndex)
            {
                if (nums[rightIndex] >= k)
                {
                    rightIndex--;
                    continue;
                }

                int sum = nums[leftIndex] + nums[rightIndex];
                if (sum == k) 
                {
                    leftIndex++;
                    rightIndex--;
                    opCount++;
                }
                else if(sum > k)
                {
                    rightIndex--;
                }
                else
                {
                    leftIndex++;
                }
            }

            return opCount;
        }
    }
}
