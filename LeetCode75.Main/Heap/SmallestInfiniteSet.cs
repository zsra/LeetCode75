﻿namespace LeetCode75.Main.Heap;

internal class SmallestInfiniteSet
{
    private readonly PriorityQueue<int, int> pq;

    public SmallestInfiniteSet()
    {
        pq = new PriorityQueue<int, int>(Enumerable.Range(1, 1000).Select(x => (x, x)));
    }

    public int PopSmallest()
    {
        int smallest = pq.Dequeue();
        
        while (pq.Count > 0 && pq.Peek() == smallest)
        {
            pq.Dequeue();
        }

        return smallest;
    }

    public void AddBack(int num)
    {
        pq.Enqueue(num, num);
    }
}
