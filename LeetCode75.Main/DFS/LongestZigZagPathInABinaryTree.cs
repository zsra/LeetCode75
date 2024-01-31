namespace LeetCode75.Main.DFS;

public class LongestZigZagPathInABinaryTree
{
    public int LongestZigZag(TreeNode root)
    {
        return Math.Max(DFS(root.left, true, 0), DFS(root.right, false, 0));
    }

    static int DFS(TreeNode node, bool isLeft, int count)
    {
        return node == null
            ? count
            : isLeft
            ? Math.Max(DFS(node.left, true, 0), DFS(node.right, false, count + 1))
            : Math.Max(DFS(node.left, true, count + 1), DFS(node.right, false, 0));
    }
}
