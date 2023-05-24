//Given the head of a sorted linked list, delete all nodes that have duplicate numbers,

//leaving only distinct numbers from the original list. Return the linked list sorted as well.

using System.Collections.Generic;

namespace Algo
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class TwoPointers
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            // If the list is empty or has only one node, return it as is
            if (head == null || head.next == null)
            {
                return head;
            }

            // Create a dummy node to serve as the new head of the list
            ListNode dummy = new ListNode(0, head);

            // Create a pointer to the node before the first potential duplicate
            ListNode prev = dummy;

            // Create a pointer to the first node in a potential duplicate pair
            ListNode curr = head;

            while (curr != null)
            {
                // Check if the current node is a potential duplicate
                if (curr.next != null && curr.val == curr.next.val)
                {
                    // Move the pointer to the second node in the potential duplicate pair
                    ListNode next = curr.next;
                    while (next != null && next.val == curr.val)
                    {
                        // Skip over all nodes with the same value as the first node in the pair
                        next = next.next;
                    }
                    // Remove all nodes between the first and second nodes in the duplicate pair
                    prev.next = next;
                    curr = next;
                }
                else
                {
                    // Move to the next node
                    prev = curr;
                    curr = curr.next;
                }
            }

            // Return the new head of the list (after skipping over all duplicates)
            return dummy.next;
        }

        static public ListNode DeleteAllButOneDuplicate(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            var foundNumbers = new HashSet<int>();

            var resultList = new ListNode();
            var resultHead = new ListNode(0, resultList);

            while (head.next != null)
            {
                if (!foundNumbers.Contains(head.val))
                {
                    foundNumbers.Add(head.val);
                    resultList.val = head.val;
                    resultList.next = new ListNode();
                    resultList = resultList.next;
                }

                head = head.next;
            }

            return resultHead.next;
        }
    }
}
