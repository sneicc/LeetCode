namespace Maximum_Level_Sum_of_a_Binary_Tree
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
            TreeNode root = new TreeNode
            {
                val = -100,
                left = new TreeNode
                {
                    val = -200,
                    left = new TreeNode
                    {
                        val = -20,
                        left = null,
                        right = null
                    },
                    right = new TreeNode
                    {
                        val = -5,
                        left = null,
                        right = null
                    }
                },
                right = new TreeNode
                {
                    val = -300,
                    left = new TreeNode
                    {
                        val = -10,
                        left = null,
                        right = null
                    },
                    right = null
                }
            };

            Console.WriteLine(MaxLevelSum(root));

            Console.ReadLine();

        }

        public static int MaxLevelSum(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int ans = 1;
            int level = 1;
            int max = Int32.MinValue;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int acc = 0;
                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    var curr = queue.Dequeue();

                    if (curr.left is not null)
                    {
                        queue.Enqueue(curr.left);
                    }
                    if(curr.right is not null)
                    {
                        queue.Enqueue(curr.right);
                    }                   

                    acc += curr.val;
                }

                if(acc > max)
                {
                    max = acc;
                    ans = level;
                }
                level++;
            }

            return ans;
        }
    }
}
