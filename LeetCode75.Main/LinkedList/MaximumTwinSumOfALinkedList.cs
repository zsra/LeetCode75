namespace LeetCode75.Main.LinkedList;

public class MaximumTwinSumOfALinkedList
{
    public int PairSum(ListNode head)
    {
        List<int> datas = new();
        
        while (head != null)
        {
            datas.Add(head.val);
            head = head.next;
        }
        
        int sum = 0;
        for (int i = 0; i < datas.Count / 2; i++)
        {
            if (datas[i] + datas[datas.Count - i - 1] > sum)
            {
                sum = datas[i] + datas[datas.Count - i - 1];
            }
        }

        return sum;
    }
}
