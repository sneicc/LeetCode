using System.Numerics;
using System.Runtime.InteropServices.Marshalling;

namespace Decode_String
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DecodeString("100[leetcode]"));

            Console.ReadLine();
        }

        public static string DecodeString(string s)
        {
            var stack = new Stack<char>();

            int i = 0;
            while (i < s.Length)
            {
                bool flag = true;
                while (i < s.Length)
                {
                    char c = s[i];
                    i++;

                    if (c == ']')
                    {
                        flag = false;
                        break;
                    }
                    else
                    {
                        stack.Push(c);                        
                    }                
                }

                if (i >= s.Length && flag)
                {
                    break;
                }

                string seq = String.Empty;
                char ch;
                while ((ch = stack.Pop()) != '[')
                {
                    seq += ch;
                }

                int reps = 0;
                int rank = 1;
                while(stack.Count > 0 && Char.IsDigit(stack.Peek())) 
                {
                    reps += (stack.Pop() - '0') * rank;
                    rank *= 10;
                }
                    
                seq = String.Concat(Enumerable.Repeat(seq, reps));
                for (int j = seq.Length - 1; j >= 0; j--)
                {
                    stack.Push(seq[j]);
                }                        
            }

            return String.Concat(stack.Reverse());
        }
    }
}
