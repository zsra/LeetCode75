namespace LeetCode75.Main.DFS;

public class CountGoodNodesInBinaryTree
{
    int goodNodes = 0;

    public void Find(TreeNode root, int high)
    {
        if (root == null)
        {
            return;
        }

        if (high <= root.val) {
            goodNodes++;
            high = root.val;
        }

        if (root.left != null)
        {
            Find(root.left, high);
        }

        if (root.right != null)
        {
            Find(root.right, high);
        }
    }

    public int GoodNodes(TreeNode root)
    {
        Find(root, int.MinValue);
        return goodNodes;
    }
}
