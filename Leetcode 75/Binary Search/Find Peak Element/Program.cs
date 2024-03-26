namespace Find_Peak_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int FindPeakElement(int[] nums)
        {
            int len = nums.Length;
            int lowIndex = 1;
            int highIndex = len - 2;

            if (len == 1) return 0;

            if (nums[0] > nums[1]) return 0;
            if (nums[len - 1] > nums[len - 2]) return len - 1;

            while (lowIndex <= highIndex)
            {
                int midIndex = lowIndex + (highIndex - lowIndex) / 2;
                if (nums[midIndex - 1] < nums[midIndex] && nums[midIndex] > nums[midIndex + 1]) return midIndex;
                else if (nums[midIndex] < nums[midIndex - 1]) highIndex = midIndex - 1;
                else lowIndex = midIndex + 1;
            }

            return -1;
        }
    }
}
