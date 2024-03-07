namespace Binary_Tree_Right_Side_View
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

        public IList<int> RightSideView(TreeNode root)
        {
            var levels = new List<Stack<int>>();
            var ans = new List<int>();

            solve(root, 0, levels);

            foreach(var level in levels)
            {
                ans.Add(level.Pop());
            }

            return ans;
        }

        public void solve(TreeNode root, int level, List<Stack<int>> levels)
        {
            if (root == null)
            {
                return;
            }

            if (level >= levels.Count)
            {
                levels.Add(new Stack<int>());
            }

            levels[level].Push(root.val);

            level++;
            solve(root.left, level, levels);
            solve(root.right, level, levels);
        }
    }
}
