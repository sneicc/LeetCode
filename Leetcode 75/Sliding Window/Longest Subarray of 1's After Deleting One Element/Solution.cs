namespace Longest_Subarray_of_1_s_After_Deleting_One_Element
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestSubarray([0, 1, 1, 1, 0, 1, 1, 0, 1]));

            Console.ReadLine();
        }

        public static int LongestSubarray(int[] nums)
        {
            int leftCount = 0;
            int rightCount = 0;
            int max = 0;
            bool isZeroDeleted = false;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    isZeroDeleted = true;

                    max = Math.Max(max, leftCount + rightCount);
                    leftCount = rightCount;
                    rightCount = 0;
                }
                else
                {
                    rightCount++;
                }
            }

            max = Math.Max(max, leftCount + rightCount);
            return isZeroDeleted ? max : max - 1;
        }
    }
}
