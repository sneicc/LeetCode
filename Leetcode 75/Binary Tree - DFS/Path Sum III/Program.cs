namespace Path_Sum_III
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

        public int PathSum(TreeNode root, int targetSum)
        {
            int ans = 0;
            CheckSum(root, in targetSum, 0, ref ans, true);
            return ans;
        }

        public void CheckSum(TreeNode node, in int targetSum, long sum, ref int ans, bool isRoot) 
        {
            if (node == null)
            {
                return;
            }

            sum += node.val;
            if(sum == targetSum)
            {
                ans++;
            }          

            CheckSum(node.left, in targetSum, sum, ref ans, isRoot);
            CheckSum(node.right, in targetSum, sum, ref ans, isRoot);

            if (isRoot)
            {
                CheckSum(node.left, in targetSum, 0, ref ans, false);
                CheckSum(node.right, in targetSum, 0, ref ans, false);
            }           
        }
    }
}
