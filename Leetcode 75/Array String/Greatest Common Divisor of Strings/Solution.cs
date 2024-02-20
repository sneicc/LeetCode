using System;
using System.Text;

namespace Greatest_Common_Divisor_of_Strings
{
    public class Solution
    {
        public static void Main()
        {
            Console.WriteLine(GcdOfStrings("ABCABC", "ABC"));

            Console.ReadLine();
        }

        //public static string GcdOfStrings(string str1, string str2)
        //{
        //    string biggerString = str1.Length > str2.Length ? str1 : str2;
        //    string smallerString = str2.Length < str1.Length ? str2 : str1;

        //    int maxLen = biggerString.Length;
        //    int i = 0;
        //    int j = 0;

        //    string ans = smallerString;           
        //    while (ans.Length > 0)
        //    {               
        //        while (i < maxLen)
        //        {
        //            if (biggerString[i++] != ans[j++])
        //                break;

        //            if (i >= maxLen && j >= ans.Length && (smallerString.Length % ans.Length == 0))
        //            {
        //                int l = 0;
        //                for (int k = 0; k < smallerString.Length; k++)
        //                {
        //                    if (smallerString[k] != ans[l++])
        //                        return String.Empty;

        //                    if (l >= ans.Length)
        //                        l = 0;
        //                }
        //                return ans;
        //            }

        //            if (j >= ans.Length)
        //                j = 0;                 
        //        }

        //        i = 0;
        //        j = 0;
        //        ans = ans.Remove(ans.Length - 1, 1);
        //    }
        //    return String.Empty;
        //}

        public static string GcdOfStrings(string str1, string str2)
        {
            if (str1 + str2 != str2 + str1)
                return String.Empty;

            int gcd = GCD(str1.Length, str2.Length);

            return str1.Substring(0, gcd);
        }

        public static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }
    }
}
