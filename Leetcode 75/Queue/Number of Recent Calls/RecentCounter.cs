namespace Number_of_Recent_Calls
{
    internal class RecentCounter
    {
        private Queue<int> _requestsQueue;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public RecentCounter()
        {
            _requestsQueue = new Queue<int>();
        }

        public int Ping(int t)
        {
            _requestsQueue.Enqueue(t);

            while (true)
            {
                int request = _requestsQueue.Peek();

                if(request >= t - 3000 && request <= t)
                {
                    break;
                }
                else
                {
                    _requestsQueue.Dequeue();
                }
            }

            return _requestsQueue.Count;
        }
    }
}
