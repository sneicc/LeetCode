namespace Smallest_Number_in_Infinite_Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sis = new SmallestInfiniteSet();
            Console.WriteLine(sis.PopSmallest());
            Console.ReadLine();
        }
    }

    class SmallestInfiniteSet
    {       
        private HashSet<int> _presentedNumbers;
        private PriorityQueue<int, int> _addedNumbers;
        private int _lastPoppedFromInf;

        public SmallestInfiniteSet()
        {
            var ss = new SortedSet<int>();
            _presentedNumbers = new HashSet<int>();
            _addedNumbers = new PriorityQueue<int, int>();
            _lastPoppedFromInf = 0;
        }

        public int PopSmallest()
        {
            if (_addedNumbers.TryPeek(out int peek, out _))
            {
                _presentedNumbers.Remove(peek);
                return _addedNumbers.Dequeue();
            }

            return ++_lastPoppedFromInf;
        }

        public void AddBack(int num)
        {
            if (num > _lastPoppedFromInf) return;

            if (_presentedNumbers.Add(num))
            {
                _addedNumbers.Enqueue(num, num);
            }
        }
    }
}
