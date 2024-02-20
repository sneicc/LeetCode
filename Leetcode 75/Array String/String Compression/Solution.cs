namespace String_Compression
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Compress(['a', 'b', 'c']));

            Console.ReadLine();
        }

        public static int Compress(char[] chars)
        {
            int len = chars.Length;
            char group = chars[0];
            int groupCount = 0;
            int compressedIndex = 0;    
          
            for (int i = 0; i < len; i++)
            {                
                if (chars[i] != group) 
                {
                    chars[compressedIndex++] = group;
                    if(groupCount > 1)
                    {
                        foreach (char c in groupCount.ToString()) 
                        {
                            chars[compressedIndex++] = c;
                        }
                    }

                    groupCount = 0;
                    group = chars[i];
                }

                groupCount++;
            }

            chars[compressedIndex++] = group;
            if (groupCount > 1)
            {
                foreach (char c in groupCount.ToString())
                {
                    chars[compressedIndex++] = c;
                }
            }

            return compressedIndex;
        }
    }
}
