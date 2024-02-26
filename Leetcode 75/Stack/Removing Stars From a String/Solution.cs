namespace Removing_Stars_From_a_String
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveStars("leet**cod*e"));

            Console.ReadLine();
        }

        public static string RemoveStars(string s)
        {
            var stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != '*')
                {
                    stack.Push(s[i]);
                }
                else
                {
                    stack.Pop();
                }               
            }

            return new String(stack.Reverse().ToArray());
        }
    }
}
