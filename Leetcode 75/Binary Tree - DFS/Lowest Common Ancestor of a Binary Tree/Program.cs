namespace Lowest_Common_Ancestor_of_a_Binary_Tree
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

        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            TreeNode? ans = null;
            bool isSolve = false;

            solve(root, in p.val, in q.val, ref ans, ref isSolve);

            return ans;
        }

        public bool solve(TreeNode root, in int p, in int q, ref TreeNode ans, ref bool isSolve)
        {
            if (root == null)
            {
                return false;
            }

            bool current = root.val == p || root.val == q;
            bool leftResult = solve(root.left, p, q, ref ans, ref isSolve);
            bool rightResult = solve(root.right, p, q, ref ans, ref isSolve);

            if (!isSolve)
            {
                if (current && (leftResult || rightResult))
                {
                    isSolve = true;
                    ans = root;
                }
                else if (leftResult && rightResult)
                {
                    isSolve = true;
                    ans = root;
                }
            }

            return current || leftResult || rightResult;
        }
    }
}
