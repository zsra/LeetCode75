namespace LeetCode75.Main.BinarySearchTree;

internal class SearchInABinarySearchTree
{
    public TreeNode SearchBST(TreeNode root, int val)
    {
        while (root != null)
        {
            if (root.val == val)
            {
                return root;
            }

            else if (val < root.val)
            {
                root = root.left;
            }

            else
            {
                root = root.right;
            }
        }

        return null;
    }
}
