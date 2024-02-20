namespace Product_of_Array_Except_Self
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            foreach (var item in ProductExceptSelf([1, 2, 3, 4]))
            {
                Console.Write(item + " ");                   
            }

            Console.ReadLine();
        }

        public static int[] ProductExceptSelf(int[] nums)
        {
            int len = nums.Length;
            var ans = new int[len];

            //var pref = new int[len];
            //var suff = new int[len];
            //pref[0] = 1;
            //suff[len - 1] = 1;

            //for (int i = 1; i < len; i++)
            //{
            //    pref[i] = pref[i - 1] * nums[i - 1];
            //}

            //for (int i = len - 2; i >= 0; i--)
            //{
            //    suff[i] = suff[i + 1] * nums[i + 1];
            //}

            //for (int i = 0; i < len; i++)
            //{
            //    ans[i] = pref[i] * suff[i];
            //}

            int temp = 1;
            for (int i = 0; i < len; i++)
            {
                ans[i] = 1;
                ans[i] *= temp;
                temp *= nums[i];
            }

            temp = 1;
            for (int i = len - 1; i >= 0; i--)
            {
                ans[i] *= temp;
                temp *= nums[i];
            }

            return ans;
        }
    }
}
