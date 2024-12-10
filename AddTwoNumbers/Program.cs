/*
2. Add Two Numbers

You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

Example 1:
Input: l1 = [2,4,3], l2 = [5,6,4]
Output: [7,0,8]
Explanation: 342 + 465 = 807.
Example 2:

Input: l1 = [0], l2 = [0]
Output: [0]
Example 3:

Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
Output: [8,9,9,9,0,0,0,1]

 */
using LeetcodeTrainer.Common;

namespace AddTwoNumbers;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] l1 = [9, 9, 9, 9, 9, 9, 9];
        int[] l2 = [9, 9, 9, 9];

        var result = Problem.AddTwoNumbers(l1.ToListNode(), l2.ToListNode());

        Console.Write(result.ToString());

        Console.ReadLine();
    }
}

public static class Problem
{
    public static ListNode AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        ListNode? _l1 = l1;
        ListNode? _l2 = l2;

        Queue<int> queue1 = new(100);
        Queue<int> queue2 = new(100);

        if (_l1 is not null)
            queue1.Enqueue(_l1.val);

        if (_l2 is not null)
            queue2.Enqueue(_l2.val);

        while (_l1?.next is not null || _l2?.next is not null)
        {
            if (_l1?.next is not null)
            {
                _l1 = _l1.next;
                queue1.Enqueue(_l1.val);
            }

            if (_l2?.next is not null)
            {
                _l2 = _l2.next;
                queue2.Enqueue(_l2.val);
            }
        }

        var longestQueue = queue1.Count > queue2.Count ? queue1 : queue2;

        ListNode result = new ListNode();
        int digitAddition = 0;
        int sum = 0;

        ListNode node = result;

        while (longestQueue.Count > 0 || digitAddition > 0)
        {
            if (queue1.Count > 0 && queue2.Count > 0)
            {
                var v1 = queue1.Dequeue();
                var v2 = queue2.Dequeue();
                sum = v1 + v2 + digitAddition;
            }
            else if (longestQueue.Count > 0)
            {
                var v = longestQueue.Dequeue();
                sum = v + digitAddition;
            }
            else
            {
                sum = digitAddition;
            }

            node.val = sum > 9 ? sum - 10 : sum;
            digitAddition = sum > 9 ? 1 : 0;

            if (longestQueue.Count > 0 || digitAddition > 0)
            {
                node.next = new ListNode();
                node = node.next;
            }
        }

        return result;
    }
}
