namespace LeetCode75.Main.LinkedList;

public class ReverseLinkedList
{
    public ListNode ReverseList(ListNode head)
    {
        if( head == null || head.next == null )
        {
            return head;
        }

        List<int> values = [];

        while (head != null)
        {
            values.Add(head.val);
            head = head.next;
        }

        ListNode current = new(values[values.Count - 1]);
        head = current;

        for (int i = values.Count - 2; i >= 0; i--)
        {
            current.next = new ListNode(values[i]);
            current = current.next;
        }

        return head;
    }
}
