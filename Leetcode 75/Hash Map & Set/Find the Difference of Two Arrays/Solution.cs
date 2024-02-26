using System.Collections.Generic;

namespace Find_the_Difference_of_Two_Arrays
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            foreach (var item in FindDifference([1, 2, 3], [2, 4, 6]))
            {
                foreach (var item1 in item)
                {
                    Console.WriteLine(item1);
                }
                Console.WriteLine();
            }        

            Console.ReadLine();
        }

        public static IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {           
            //var answer = new List<IList<int>>();
            //nums1 = nums1.Distinct().ToArray();
            //nums2 = nums2.Distinct().ToArray();

            //var hashSet1 = CreateHashSet(nums1);
            //var hashSet2 = CreateHashSet(nums2);

            //answer.Add(GetUniqueValues(nums1, hashSet2));
            //answer.Add(GetUniqueValues(nums2, hashSet1));

            //return answer;

            var set1 = new HashSet<int>(nums1);
            var set2 = new HashSet<int>(nums2);

            set1.ExceptWith(nums2);
            set2.ExceptWith(nums1);            

            return new List<IList<int>> { set1.ToList(), set2.ToList() };
        }

        //public static HashSet<int> CreateHashSet(int[] nums)
        //{
        //    var hashSet = new HashSet<int>();
        //    foreach (int i in nums)
        //    {
        //        hashSet.Add(i);
        //    }
        //    return hashSet;
        //}

        //public static List<int> GetUniqueValues(int[] nums, HashSet<int> hashSet)
        //{
        //    var list = new List<int>();
        //    foreach (int i in nums)
        //    {
        //        if (!hashSet.Contains(i))
        //        {
        //            list.Add(i);
        //        }
        //    }
        //    return list;
        //}
    }
}
