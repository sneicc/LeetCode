namespace Count_Good_Nodes_in_Binary_Tree
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

        public int GoodNodes(TreeNode root)
        {
           return CheckNode(root, root.val);
        }

        public int CheckNode(TreeNode node, int max)
        {
            if(node == null)
            {
                return 0;
            }

            int goodCount = 0;
            if(node.val >= max)
            {
                max = node.val;
                goodCount++;
            }

            goodCount += CheckNode(node.left, max);
            goodCount += CheckNode(node.right, max);

            return goodCount;
        }
    }
}
