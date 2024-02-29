namespace Maximum_Twin_Sum_of_a_Linked_List
{
    internal class Solution
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int PairSum(ListNode head)
        {
            int max = Int32.MinValue;
            var values = new List<int>();

            while (head != null)
            {
                values.Add(head.val);
                head = head.next;
            }

            for (int i = 0, j = values.Count - 1; i < values.Count / 2; i++, j--)
            {
                max = Math.Max(max, values[i] + values[j]);
            }

            return max;
        }
    }
}
