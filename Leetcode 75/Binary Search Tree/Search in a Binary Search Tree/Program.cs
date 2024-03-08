namespace Search_in_a_Binary_Search_Tree
{
    internal class Program
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public TreeNode SearchBST(TreeNode root, int val)
        {
            TreeNode current = root;
            while (current != null)
            {
                if (val == current.val)
                {
                    return current;
                }

                current = val < current.val ? current.left : current.right;              
            }

            return null;
        }
    }
}
