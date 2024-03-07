namespace Leaf_Similar_Trees
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

        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            var firstTreeLeafs = new List<int>();
            var secondTreeLeafs = new List<int>();

            GetLeafs(root1, firstTreeLeafs);
            GetLeafs(root2 , secondTreeLeafs);

            if (firstTreeLeafs.Count != secondTreeLeafs.Count)
            {
                return false;
            }
            for (int i = 0; i < firstTreeLeafs.Count; i++)
            {
                if (firstTreeLeafs[i] != secondTreeLeafs[i])
                {
                    return false;
                }
            }

            return true;
        }

        public void GetLeafs(TreeNode node, List<int> leafs)
        {
            bool isLeftNodeExist = true;
            bool isRightNodeExist = true;

            if (node.left != null)
            {
                GetLeafs(node.left, leafs);
            }
            else
            {
                isLeftNodeExist = false;
            }

            if (node.right != null)
            {
                GetLeafs(node.right, leafs);
            }
            else
            {
                isRightNodeExist = false;
            }

            if (!isLeftNodeExist && !isRightNodeExist)
            {
                leafs.Add(node.val);
            }
        }
    }
}
