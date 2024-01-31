namespace LeetCode75.Main.DFS;

public class LowestCommonAncestorOfABinaryTree
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        if ((root == null) || (root == p) || (root == q))
        {
            return root;
        }

        var leftLCA = LowestCommonAncestor(root.left, p, q);
        var rightLCA = LowestCommonAncestor(root.right, p, q);

        if (leftLCA == null)
        {
            return rightLCA;
        }
        else if (rightLCA == null)
        {
            return leftLCA;
        }
        else
        {
            return root;
        }
    }
}
