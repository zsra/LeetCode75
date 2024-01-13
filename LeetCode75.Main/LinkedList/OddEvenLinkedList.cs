namespace LeetCode75.Main.LinkedList;

public class OddEvenLinkedList
{
    public ListNode OddEvenList(ListNode head)
    {
        if (head == null || head.next == null) 
        { 
            return head; 
        }

        var oddTail = head;
        var evenHead = head.next;
        var evenTail = evenHead;

        while (oddTail != null && oddTail.next != null)
        {
            oddTail.next = oddTail.next.next;
            
            if (oddTail.next == null) 
            { 
                break; 
            }

            oddTail = oddTail.next;
            
            if (oddTail.next != null)
            {
                evenTail.next = oddTail.next;
                evenTail = evenTail.next;
            }
            else 
            { 
                evenTail.next = null; 
            }
        }

        oddTail.next = evenHead;
        return head;
    }
}
