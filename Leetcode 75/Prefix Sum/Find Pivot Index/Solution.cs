namespace Find_Pivot_Index
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PivotIndex([1, 7, 3, 6, 5, 6]));

            Console.WriteLine();
        }

        public static int PivotIndex(int[] nums)
        {
            int len = nums.Length;
            int[] leftSum = new int[nums.Length];
            int[] rightSum = new int[nums.Length];

            leftSum[0] = nums[0];
            for (int i = 1; i < len; i++)
            {
                leftSum[i] = leftSum[i - 1] + nums[i];
            }

            rightSum[len - 1] = nums[len - 1];
            for (int i = len - 2; i >= 0; i--)
            {
                rightSum[i] = rightSum[i + 1] + nums[i];
            }

            for (int i = 0; i < len; i++)
            {
                if (leftSum[i] == rightSum[i])
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
