using System.Xml.Linq;

namespace Longest_ZigZag_Path_in_a_Binary_Tree
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

        public int LongestZigZag(TreeNode root)
        {
            int max = 0;
            ZigZag(root.left, 0, ref max, true);
            ZigZag(root.right, 0, ref max, false);

            return max;
        }

        public void ZigZag(TreeNode node, int depth, ref int max, bool isLeft)
        {
            if (node == null)
            {
                max = Math.Max(max, depth);
                return;
            }

            depth++;
            if (isLeft)
            {
                ZigZag(node.right, depth, ref max, false);
                ZigZag(node.left, 0, ref max, true);
            }
            else
            {
                ZigZag(node.left, depth, ref max, true);
                ZigZag(node.right, 0, ref max, false);
            }          

            return;
        }
    }
}
