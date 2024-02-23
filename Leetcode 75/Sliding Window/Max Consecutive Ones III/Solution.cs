namespace Max_Consecutive_Ones_III
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestOnes([1, 0, 0, 1, 0, 0, 1, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 0, 1, 0, 1, 0, 0, 1, 0, 0, 1, 1], 9));

            Console.ReadLine();
        }

        public static int LongestOnes(int[] nums, int k)
        {
            int windowStart = 0;
            int count = 0;
            int max = 0;
            int currentK = k;
            bool kZeroCheck = k != 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    count++;
                }
                else if(kZeroCheck)
                {
                    if(currentK > 0)
                    {
                        currentK--;
                        count++;
                    }
                    else
                    {
                        if (nums[windowStart] == 0)
                        {
                            windowStart++;
                        }
                        else
                        {
                            max = Math.Max(max, count);

                            while (nums[windowStart] != 0)
                            {
                                windowStart++;
                                count--;
                            }
                            windowStart++;
                        }
                    }
                }
                else
                {
                    max = Math.Max(max, count);
                    count = 0;
                }
            }

            return Math.Max(max, count);
        }
    }
}
