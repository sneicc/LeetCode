namespace Can_Place_Flowers
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CanPlaceFlowers([1, 0, 0, 0, 0], 3));

            Console.ReadLine();
        }

        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int len = flowerbed.Length;
            int emptySpots = 0;

            for (int i = 0; i < len; i++) 
            {
                if (flowerbed[i] == 1)
                {
                    i++;
                    n -= emptySpots / 2;
                    emptySpots = 0;
                }
                else
                {
                    emptySpots++;
                }                
            }

            emptySpots++;
            n -= emptySpots / 2;

            return n <= 0;
        }
    }
}
