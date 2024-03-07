namespace Maximum_Depth_of_Binary_Tree
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

        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int depth = 1;
            int max = 1;

            EnterNode(root, ref depth, ref max);

            return max;
        }

        public void EnterNode(TreeNode node, ref int currentDepth, ref int maxDepth)
        {
            maxDepth = Math.Max(maxDepth, currentDepth);

            if (node.left != null)
            {
                currentDepth++;
                EnterNode(node.left, ref currentDepth, ref maxDepth);
                currentDepth--;
            }

            if(node.right != null)
            {
                currentDepth++;
                EnterNode(node.right, ref currentDepth, ref maxDepth);
                currentDepth--;
            }
        }
    }
}
