﻿namespace LeetCode75.Main.Heap;

internal class MaximumSubsequenceScore
{
    public long MaxScore(int[] nums1, int[] nums2, int k)
    {
        List<(int, int)> lst = [];
        for (int i = 0; i < nums1.Length; i++)
        {
            lst.Add((nums1[i], nums2[i]));
        }

        PriorityQueue<int, int> pq = new();
        lst = [.. lst.OrderByDescending(x => x.Item2)];

        long sum = 0;
        int min = 0;
        for (int i = 0; i < k; i++)
        {
            pq.Enqueue(lst[i].Item1, lst[i].Item1);
            sum += lst[i].Item1;
            min = lst[i].Item2;
        }

        long res = sum * min;
        for (int i = k; i < lst.Count; i++)
        {
            sum += lst[i].Item1 - pq.Dequeue();
            pq.Enqueue(lst[i].Item1, lst[i].Item1);
            min = lst[i].Item2;
            res = Math.Max(res, sum * min);
        }

        return res;
    }
}
