namespace Determine_if_Two_Strings_Are_Close
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CloseStrings("cabbba", "abbccc"));
        }

        public static bool CloseStrings(string word1, string word2)
        {
            if(word1.Length != word2.Length) 
            {
                return false;
            }

            var pairs1 = new Dictionary<char, int>();
            var pairs2 = new Dictionary<char, int>();

            for (int i = 0; i < word1.Length; i++)
            {
                if (!pairs1.TryAdd(word1[i], 1))
                {
                    pairs1[word1[i]]++;
                }

                if (!pairs2.TryAdd(word2[i], 1))
                {
                    pairs2[word2[i]]++;
                }
            }

            //char[] letters = pairs1.Keys.ToArray();
            //for (int i = 0; i < letters.Length; i++)
            //{
            //    if (!(pairs1.TryGetValue(letters[i], out int value1) && 
            //        pairs2.TryGetValue(letters[i], out int value2))) 
            //    {
            //        return false;
            //    }

            //    if (value1 == value2)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        int j = i + 1;
            //        int count = value2;
            //        bool isReplaced = false;
            //        while (j < letters.Length)
            //        {
            //            if(pairs1[letters[j]] == count)
            //            {
            //                pairs1[letters[j]] = pairs1[letters[i]];
            //                pairs1[letters[i]] = count;
            //                isReplaced = true;
            //            }
            //            j++;
            //        }
            //        if (!isReplaced)
            //        {
            //            return false;
            //        }
            //    }
            //}

            //return true;

            char[] letters = pairs1.Keys.ToArray();
            foreach (char letter in letters)
            {
                if (!pairs2.TryGetValue(letter, out _))
                {
                    return false;
                }
            }

            var values1 = pairs1.Values.ToArray();
            var values2 = pairs2.Values.ToArray();

            Array.Sort(values1);
            Array.Sort(values2);

            for (int i = 0; i < values1.Length; i++)
            {
                if (values1[i] != values2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
