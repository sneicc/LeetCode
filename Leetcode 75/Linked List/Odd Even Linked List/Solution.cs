namespace Odd_Even_Linked_List
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

        public ListNode? OddEvenList(ListNode head)
        {
            if(head == null)
            {
                return null;
            }

            var odd = head;
            var even = head.next;
            var firstEven = even;

            while(even != null && even.next != null)
            {
                odd.next = even.next;
                even.next = odd.next.next;
                odd.next.next = firstEven;

                odd = odd.next;
                even = even.next;
            }

            return head;
        }
    }
}
