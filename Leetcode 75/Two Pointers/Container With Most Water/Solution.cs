namespace Container_With_Most_Water
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxArea([1, 8, 6, 2, 5, 4, 8, 3, 7]));

            Console.ReadLine();
        }

        public static int MaxArea(int[] height)
        {
            int leftIndex = 0;
            int rightIndex = height.Length - 1;

            List<int> results = new List<int>();

            while(leftIndex != rightIndex)
            {
                int leftValue = height[leftIndex];
                int rightValue = height[rightIndex];
                int xSize = rightIndex - leftIndex;
                int area;

                if (leftValue < rightValue)
                {                  
                    area = leftValue * xSize;
                    leftIndex++;
                }
                else
                {
                    area = rightValue * xSize;
                    rightIndex--;
                }

                results.Add(area);
            }

            return results.Max();
        }
    }
}
