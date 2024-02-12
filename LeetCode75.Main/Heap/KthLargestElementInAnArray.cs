namespace LeetCode75.Main.Heap;

public class KthLargestElementInAnArray
{
    public int FindKthLargest(int[] nums, int k)
    {
        PriorityQueue<int, int> priorityQueue = new(Comparer<int>.Create((a, b) => b.CompareTo(a)));

        for (int i = 0; i < nums.Length; i++)
        {
            priorityQueue.Enqueue(nums[i], nums[i]);
        }

        int result = 0;

        for (int i = 0; i < k; i++) 
        {
            result = priorityQueue.Dequeue();
        }

        return result;
    }
}
