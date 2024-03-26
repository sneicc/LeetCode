namespace Koko_Eating_Bananas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MinEatingSpeed([3, 6, 7, 11], 8);
        }

        public static int MinEatingSpeed(int[] piles, int h)
        {
            int len = piles.Length;
            uint lowBound = 1;
            uint highBound = uint.MaxValue;       

            while (lowBound <= highBound)
            {
                uint mid = lowBound + (highBound - lowBound) / 2;
                int currentTime = 0;
                for (int i = 0; i < len; i++)
                {
                    currentTime += (int)Math.Ceiling((double)piles[i] / mid);
                }

                if(currentTime <= h) highBound = mid - 1; 
                else lowBound = mid + 1;
            }

            return (int)lowBound;
        }
    }
}
