namespace Reverse_Linked_List
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

        public ListNode ReverseList(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            var forwardNode = head.next;
            var reversNode = new ListNode(head.val);

            while(forwardNode != null)
            {
                var node = new ListNode(forwardNode.val, reversNode);
                reversNode = node;
                forwardNode = forwardNode.next;
            }

            return reversNode;
        }
    }
}
