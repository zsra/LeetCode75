
namespace LeetCode75.Main.DFS;

public class PathSum3
{
    public int PathSum(TreeNode root, int targetSum)
    {
        return root == null
            ? 0
            : DFS(root, targetSum)
            + PathSum(root.left, targetSum)
            + PathSum(root.right, targetSum);
    }

    private static int DFS(TreeNode root, long targetSum)
    {
        var s = root.val == targetSum ? 1 : 0;

        if (root.left != null)
        {
            s += DFS(root.left, targetSum - root.val);
        }

        if (root.right != null)
        {
            s += DFS(root.right, targetSum - root.val);
        }

        return s;
    }
}
