using System.Text;

namespace LeetcodeTrainer.Common;

public record ListNode<T>
{
    public T val;

    public ListNode<T>? next;

    public ListNode(T? val = default, ListNode<T>? next = null)
    {
        this.val = val ?? throw new ArgumentNullException(nameof(val));
        this.next = next;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        var set = new HashSet<ListNode<T>>();

        sb.Append('[');
        ListNode<T>? node = this;
        while (node is not null)
        {
            if (!set.Add(node))
            {
                sb.Append($"circular link on node with value {node.val}");
                break;
            }

            if (node != this)
                sb.Append(',');

            sb.Append(node.val?.ToString() ?? "null");

            node = node.next;
        }
        sb.Append(']');

        return sb.ToString();
    }
}

public record ListNode : ListNode<int>
{
    public new ListNode? next
    {
        get => base.next as ListNode;
        set => base.next = value;
    }

    public ListNode(int val = default, ListNode? next = null) : base(val, next) { }

    public override string ToString()
    {
        return base.ToString();
    }
}
