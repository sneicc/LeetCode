namespace Dota2_Senate
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PredictPartyVictory("DDRRR"));

            Console.ReadLine();
        }

        public static string PredictPartyVictory(string senate)
        {
            Queue<char> queue = new Queue<char>(senate);
            bool isRemoved;
            int removeD = 0;
            int removeR = 0;

            do
            {
                isRemoved = false;
                int len = queue.Count;
                
                for (int i = 0; i < len; i++)
                {
                    char first = queue.Dequeue();

                    if (first == 'D' && removeD > 0)
                    {
                        removeD--;
                        isRemoved = true;
                        continue;
                    }
                    else if(first == 'R' && removeR > 0)
                    {
                        removeR--;
                        isRemoved = true;
                        continue;
                    }

                    if (first == 'D')
                    {
                        removeR++;
                    }
                    else
                    {
                        removeD++;
                    }

                    queue.Enqueue(first);
                }
            } while (isRemoved);

            return queue.Peek() == 'D' ? "Dire" : "Radiant";
        }
    }
}
