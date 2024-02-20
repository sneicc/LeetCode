using System.Text;

namespace Reverse_Words_in_a_String
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseWords("the sky   is blue"));

            Console.ReadLine();
        }

        public static string ReverseWords(string s)
        {
            //var sb = new StringBuilder();

            var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            words = words.Reverse().ToArray();

            return String.Join(" ", words);

            //foreach (var word in words)
            //{
            //    sb.Insert(0, word);
            //    sb.Insert(0, ' ');             
            //}

            //sb.Remove(0, 1);

            //return sb.ToString();
        }
    }
}
