using System.Collections;
using System.Diagnostics.Contracts;
using System.Numerics;

namespace Equal_Row_and_Column_Pairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EqualPairs([[3, 2, 1], [1, 7, 6], [2, 7, 7]]));

            Console.ReadLine();
        }

        public static int EqualPairs(int[][] grid)
        {
            int ans = 0;
            int len = grid.Length;
            var horizontalLines = new int[len];
            var verticalLines = new int[len];

            int[] horizontal = new int[len];
            int[] vertical = new int[len];
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    horizontal[j] = grid[i][j];
                    vertical[j] = grid[j][i];
                }

                int arrayHash = MyArrayHash(horizontal);//((IStructuralEquatable)horizontal).GetHashCode(EqualityComparer<int>.Default);
                horizontalLines[i] = arrayHash;

                arrayHash = MyArrayHash(vertical);//((IStructuralEquatable)vertical).GetHashCode(EqualityComparer<int>.Default);
                verticalLines[i] = arrayHash;
            }

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    if (horizontalLines[i] == verticalLines[j])
                    {
                        ans++;
                    }
                }
            }

            return ans;
        }

        //public static int MyArrayHash(int[] arr)
        //{
        //    int hash = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //        hash ^= arr[i].GetHashCode();
        //    return hash;
        //}

        public static int CombineHashCodes(int h1, int h2)
        {
            return (((h1 << 5) + h1) ^ h2);
        }

        public static int MyArrayHash(int[] arr)
        {
            int ret = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                ret = CombineHashCodes(ret, arr[i].GetHashCode());
            }

            return ret;
        }
    }
}
