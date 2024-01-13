namespace LeetCode75.Main.LinkedList;

public class DeleteTheMiddleNodeOfALinkedList
{
    public ListNode DeleteMiddle(ListNode head)
    {
        int length = 0;

        ListNode current = head;
        while (current != null)
        {
            length++;
            current = current.next;
        }

        int middle = length / 2;

        ListNode middleNode = head;
        ListNode prev = null;

        for (int i = 0; i < middle; i++)
        {
            prev = middleNode;
            middleNode = middleNode.next;
        }

        if (prev == null)
        {
            return null;
        }

        prev.next = middleNode.next;
        return head;
    }
}
