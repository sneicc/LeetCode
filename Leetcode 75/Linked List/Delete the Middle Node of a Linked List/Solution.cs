namespace Delete_the_Middle_Node_of_a_Linked_List
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

        public ListNode DeleteMiddle(ListNode head)
        {
            if(head.next == null)
            {
                return null;
            }

            ListNode prev;
            ListNode slow = head;
            ListNode fast = head;
       
            do
            {
                prev = slow;
                slow = slow.next;
                fast = fast.next.next;
            } while (fast != null && fast.next != null);

            prev.next = slow.next;

            return head;
        }

    }
}