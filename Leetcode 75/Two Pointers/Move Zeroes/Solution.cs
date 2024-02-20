namespace Move_Zeroes
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            MoveZeroes([0, 1, 0, 3, 12]);

            Console.ReadLine();
        }

        public static void MoveZeroes(int[] nums)
        {
            //int len = nums.Length;
            //int lastZeroIndex = -1;
            //int currentZeroIndex = -1;

            //for (int i = len - 1; i >= 0; i--)
            //{
            //    if (nums[i] == 0)
            //    {
            //        for (int j = i; j < len - 1 && lastZeroIndex != j + 1; j++)
            //        {
            //            nums[j] = nums[j + 1];
            //            nums[j + 1] = 0;
            //            currentZeroIndex = j + 1;
            //        }
            //        lastZeroIndex = currentZeroIndex;
            //    }
            //}
            //
            int index = 0;
            
            foreach (int num in nums)
            {
                if(num != 0)
                {
                    nums[index] = num;
                    index++;
                }
            }

            while (index < nums.Length)
            {
                nums[index++] = 0;
            }
        }
    }
}
