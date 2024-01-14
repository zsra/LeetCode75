using System.Xml.Linq;

namespace LeetCode75.Main.DFS;

public class LeafSimilarTrees
{
    public bool LeafSimilar(TreeNode root1, TreeNode root2)
    {
        List<int> first = [];
        List<int> second = [];

        getLeafNodes(root1, first);
        getLeafNodes(root2, second);

        return first.SequenceEqual(second);
    }

    static void getLeafNodes(TreeNode root, List<int> collection)
    {
        if (root == null)
        {
            return;
        }

        if (root.left == null && root.right == null)
        {
            collection.Add(root.val);
            return;
        }

        if (root.left != null)
        {
            getLeafNodes(root.left, collection);
        }

        if (root.right != null)
        {
            getLeafNodes(root.right, collection);
        }
    }
}
