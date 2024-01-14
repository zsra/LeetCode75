namespace LeetCode75.Main.DFS;

public class MaximumDepthOfBinaryTree
{
    public int MaxDepth(TreeNode root)
    {
        return root == null ? 0 : Math.Max(MaxDepth(root.left) + 1, MaxDepth(root.right) + 1);
    }
}
