namespace Letter_Combinations_of_a_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public IList<string> LetterCombinations(string digits)
        {         
            int len = digits.Length;
            var ans = new List<string>();
            if (len == 0)
            {
                return ans;
            }

            var letters = new Dictionary<int, char[]>
            {
                { 2, ['a', 'b', 'c'] },
                { 3, ['d', 'e', 'f'] },
                { 4, ['g', 'h', 'i'] },
                { 5, ['j', 'k', 'l'] },
                { 6, ['m', 'n', 'o'] },
                { 7, ['p', 'q', 'r', 's'] },
                { 8, ['t', 'u', 'v'] },
                { 9, ['w', 'x', 'y', 'z'] }
            };

            var digitsArr = new int[len];
            for (int i = 0; i < len; i++)
            {
                digitsArr[i] = digits[i] - '0';
            }

            CreateCombinations();

            return ans;

            void CreateCombinations(string combination = "", int depth = 0)
            {
                if(depth >= len)
                {
                    ans.Add(combination);
                    return;
                }

                char[] currentLetters = letters[digitsArr[depth]];
                for (int i = 0; i < currentLetters.Length; i++)
                {
                    CreateCombinations(combination + currentLetters[i], depth + 1);
                }
            }
        }
    }
}
