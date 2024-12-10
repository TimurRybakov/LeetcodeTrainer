namespace LeetcodeTrainer.Common;

public static class ListNodeExtensions
{
    public static T[] ToArray<T>(this ListNode<T>? node)
    {
        var result = new List<T>();

        while (node is not null)
        {
            result.Add(node.val);
            node = node.next;
        }

        return result.ToArray();
    }

    public static ListNode<T>? ToListNode<T>(this T[] array)
    {
        ListNode<T>? result = null;

        for (int i = array.Length - 1; i >= 0; i--)
        {
            result = new ListNode<T>(array[i], result);
        }

        return result;
    }

    public static ListNode? ToListNode(this int[] array)
    {
        ListNode? result = null;

        for (int i = array.Length - 1; i >= 0; i--)
        {
            result = new ListNode(array[i], result);
        }

        return result;
    }
}
