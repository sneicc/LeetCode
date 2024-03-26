namespace Successful_Pairs_of_Spells_and_Potions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SuccessfulPairs([40, 11, 24, 28, 40, 22, 26, 38, 28, 10, 31, 16, 10, 37, 13, 21, 9, 22, 21, 18, 34, 2, 40, 40, 6, 16, 9, 14, 14, 15, 37, 15, 32, 4, 27, 20, 24, 12, 26, 39, 32, 39, 20, 19, 22, 33, 2, 22, 9, 18, 12, 5],
                [31, 40, 29, 19, 27, 16, 25, 8, 33, 25, 36, 21, 7, 27, 40, 24, 18, 26, 32, 25, 22, 21, 38, 22, 37, 34, 15, 36, 21, 22, 37, 14, 31, 20, 36, 27, 28, 32, 21, 26, 33, 37, 27, 39, 19, 36, 20, 23, 25, 39, 40], 600);
        }

        public static int[] SuccessfulPairs(int[] spells, int[] potions, long success)
        {
            var res = new int[spells.Length];
            int potionsLen = potions.Length;

            Array.Sort(potions);

            for (int i = 0; i < spells.Length; i++)
            {
                int lowBound = 0;
                int highBound = potionsLen - 1;

                while (true)
                {
                    int mid = lowBound + (highBound - lowBound) / 2;
                    long product = (long)spells[i] * potions[mid];

                    if (product == success)
                    {
                        if (mid - 1 > 0 && potions[mid - 1] == potions[mid])
                        {
                            highBound = mid - 1;
                            continue;
                        }

                        res[i] = potionsLen - mid;
                        break;
                    }
                    else if (product > success)
                    {
                        highBound = mid - 1;
                    }
                    else
                    {
                        lowBound = mid + 1;
                    }

                    if (lowBound > highBound)
                    {
                        if (lowBound == potionsLen) res[i] = 0;
                        else res[i] = potionsLen - lowBound;
                        break;
                    }
                }
            }

            return res;
        }
    }
}

