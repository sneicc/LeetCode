namespace Delete_Node_in_a_BST
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
            var t = new TreeNode 
            {
                val = 5,
                left = new TreeNode 
                {
                    val = 3,
                    left = new TreeNode
                    {
                        val = 2,
                    },
                    right = new TreeNode
                    {
                        val = 4
                    }
                },
            };

            DeleteNode(t, 3);
        }

        public static TreeNode DeleteNode(TreeNode root, int key)
        {
            if(root is null)
            {
                return null;
            }

            if (key < root.val)
            {
                root.left = DeleteNode(root.left, key);
            }
            else if(key > root.val)
            {
                root.right = DeleteNode(root.right, key);
            }
            else
            {
                if(root.left is null)
                {
                    return root.right;
                }
                if(root.right is null)
                {
                    return root.left;
                }

                TreeNode node = root.right;
                while (node.left != null)
                {
                    node = node.left;
                }
                root.val = node.val;
                root.right = DeleteNode(root.right, node.val);
            }           

            return root;
        }
    }
}
