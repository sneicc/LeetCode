namespace Find_the_Highest_Altitude
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LargestAltitude([-5, 1, 5, 0, -7]));

            Console.WriteLine();
        }

        public static int LargestAltitude(int[] gain)
        {
            for (int i = 1; i < gain.Length; i++)
            {
                gain[i] += gain[i - 1];
            }

            return gain.Max() > 0 ? gain.Max() : 0; 
        }
    }
}
