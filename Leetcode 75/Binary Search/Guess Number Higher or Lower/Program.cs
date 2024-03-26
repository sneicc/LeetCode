namespace Guess_Number_Higher_or_Lower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int guess(int number)
        {
            return 0;
        }

        public int GuessNumber(int n)
        {
            long lowBound = 0;
            long highBound = n;

            while (lowBound <= highBound)
            {
                long myGuess = (lowBound + highBound) / 2; // lowBound + (highBound - lowBound) / 2;
                int guessRes = guess((int)myGuess);

                if (guessRes == 0) return (int)myGuess;
                else if (guessRes == 1) lowBound = myGuess + 1;
                else highBound = myGuess - 1;
            }

            return -1;
        }
    }
}
