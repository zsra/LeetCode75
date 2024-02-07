namespace LeetCode75.Main.BFS;

internal class BinaryTreeRightSideView
{
    public IList<int> RightSideView(TreeNode root)
    {
        var result = new List<int>();
        if (root == null) return result;

        Queue<TreeNode> queue = new();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            int level = 0;
            Queue<TreeNode> nextLevelQueue = new();

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                if (node.left != null) nextLevelQueue.Enqueue(node.left);
                if (node.right != null) nextLevelQueue.Enqueue(node.right);
                level = node.val;
            }

            result.Add(level);
            queue = nextLevelQueue;
        }

        return result;
    }
}
