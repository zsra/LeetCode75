namespace LeetCode75.Main.Heap;

internal class TotalCostToHireKWorkers
{
    public long TotalCost(int[] costs, int k, int candidates)
    {
        PriorityQueue<int, int> pq1 = new();
        PriorityQueue<int, int> pq2 = new();
        long total = 0;
        int i = 0; int j = costs.Length - 1;
        while (k > 0)
        {
            while (pq1.Count < candidates && i <= j)
            {
                pq1.Enqueue(costs[i], costs[i]);
                i++;
            }
            while (pq2.Count < candidates && j >= i)
            {
                pq2.Enqueue(costs[j], costs[j]);
                j--;
            }
            int p1 = pq1.Count > 0 ? pq1.Peek() : int.MaxValue;

            int p2 = pq2.Count > 0 ? pq2.Peek() : int.MaxValue;

            if (p1 <= p2)
            {
                total += p1;
                pq1.TryDequeue(out _, out _);
            }
            else
            {
                total += p2;
                pq2.TryDequeue(out _, out _);
            }
            k--;
        }
        return total;
    }
}
