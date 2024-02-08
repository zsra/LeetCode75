namespace LeetCode75.Main.BinarySearchTree;

internal class DeleteNodeInABST
{
    public TreeNode DeleteNode(TreeNode root, int key)
    {
        if (root == null)
            return root;

        if (key < root.val)
        {
            root.left = DeleteNode(root.left, key);
        }
        else if (key > root.val)
        {
            root.right = DeleteNode(root.right, key);
        }
        else
        {
            if (root.left == null && root.right == null)
            {
                root = null;
            }
            else if (root.left == null || root.right == null)
            {
                root = root.left != null ? root.left : root.right;
            }
            else
            {
                TreeNode tmp = root.right;
                while (tmp.left != null)
                {
                    tmp = tmp.left;
                }
                root.val = tmp.val;
                root.right = DeleteNode(root.right, tmp.val);
            }
        }

        return root;
    }
}
