namespace Increasing_Triplet_Subsequence
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IncreasingTriplet([20, 100, 10, 101, 5, 102]));

            Console.ReadLine();
        }

        public static bool IncreasingTriplet(int[] nums)
        {
            if(nums.Length < 3)
                return false;

            int min1 = Int32.MaxValue;
            int min2 = Int32.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] <= min1)
                {
                    min1 = nums[i];
                }
                else if (nums[i] <= min2)
                {
                    min2 = nums[i];
                }
                else
                {
                    return true;
                }
            }

            return false;
        }


    }
}
