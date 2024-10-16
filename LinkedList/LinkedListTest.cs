namespace AlgorithmPractice.LinkedList;

public class LinkedListTest
{
    private NodeTest? Head;
    private NodeTest? Tail;
    private static int _size;
    
    public void LinkedListDescription()
    {
        // Value/Address
        var link = new LinkedList<object>();
        var tt = link.AddFirst(3);
        var re = link.AddLast(7);
        link.AddAfter(tt, 4);
        link.Remove(re);
        var array = link.ToArray();
        var find = link.Find(4);
    }
    public void AddLast(object item)
    {
        var node = new NodeTest(item);
        if (Head == null)
        {
            Head = Tail = node;
            _size = 1;
        }
        else
        {
            Tail!.Next = node;
            Tail = node;
        }

        _size++;
    }
    public void AddFirst(object item)
    {
        var node = new NodeTest(item);
        if (Head == null)
            Head = Tail = node;
        else
        {
            node.Next = Head;
            Head = node;
        }

        _size++;
    }

    public void RemoveFirst()
    {
        if (Head == null)
            throw new Exception("list is empty");
        
        if (Head == Tail)
        {
            Head = Tail = null;
            _size = 0;
            return;
        }
            
        var second = Head!.Next;
        Head.Next = null;
        Head = second;

        _size--;
    }
    
    public void RemoveLast()
    {
        if (Head == null)
            throw new Exception("list is empty");
        
        if (Head == Tail)
        {
            Head = Tail = null;
            _size = 0;
            return;
        }
            
        var previous = GetPrevious(Tail!);

        previous.Next = null;
        Tail = previous;

        _size--;
    }

    private NodeTest GetPrevious(NodeTest node)
    {
        var checkedNode = Head;
        while (checkedNode!.Next != null)
        {
            if (checkedNode.Next == node)
            {
                return checkedNode;
            }

            checkedNode = checkedNode.Next;
        }

        return node;
    }

    public object[] ToArray()
    {
        var array = new object[_size];
        var current = Head;
        var index = 0;
        while (current != null)
        {
            array[index] = current.Value;
            current = current.Next;
            index++;
        }

        return array;

    }

    public void Reverse()
    {
        var current = Head!.Next;
        var previous = Head;
        while (current != null)
        {
            var next = current.Next;
            var curr = current;
            current.Next = previous;
            current = next;
            previous = curr;
        }

        Head.Next = null;
        (Head, Tail) = (Tail, Head);
    }

}