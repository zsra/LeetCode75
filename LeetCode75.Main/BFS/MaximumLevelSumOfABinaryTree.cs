namespace LeetCode75.Main.BFS;

internal class MaximumLevelSumOfABinaryTree
{
    public int MaxLevelSum(TreeNode root)
    {
        var traverse = new Queue<TreeNode>();
        traverse.Enqueue(root);

        var maxLevel = 1;
        var maxLevelSum = root.val;
        var currentLevel = 0;

        while (traverse.Count != 0)
        {
            currentLevel++;
            var levelCount = traverse.Count;
            var currentLevelSum = 0;

            for (int i = 0; i < levelCount; i++)
            {
                var node = traverse.Dequeue();

                if (node.left != null) traverse.Enqueue(node.left);
                if (node.right != null) traverse.Enqueue(node.right);

                currentLevelSum += node.val;
            }

            if (maxLevelSum < currentLevelSum)
            {
                maxLevelSum = currentLevelSum;
                maxLevel = currentLevel;
            }
        }

        return maxLevel;
    }
}
