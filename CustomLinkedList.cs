public class CustomLinkedList<T>
{
    public class Node
    {
        public Node(T initMyProperty)
        {
            MyProperty = initMyProperty;
            Previous = null;
            Next = null;
        }

        public T MyProperty { get; set; }
        internal Node Previous { get; set; }
        internal Node Next { get; set; }
    }

    private Node _head;

    public Node First => _head;
    public Node Last
    {
        get => GetLastNode();
    }

    public Node Next => _head.Next;
    public Node Previous => _head.Previous;

    private int _count;
    public int Count
    {
        get => _count < 0 ? 0 : 1;
        private set => _count = value;
    }


    #region == Methods ==

    private Node GetLastNode()
    {
        Node nodeLast = _head;

        while (nodeLast.Next is not null)
        {
            nodeLast = nodeLast.Next;
        }

        return nodeLast;
    }

    public void AddFirst(T data)
    {
        Node newNode = new(data);
        Count++;

        if (_head is not null)
        {
            newNode.Next = _head;
            _head.Previous = newNode;
        }

        _head = newNode;
    }

    public void AddLast(T data)
    {
        Node newNode = new(data);
        Count++;

        if (_head is null)
        {
            _head = newNode;
            return;
        }

        Node lastNode = GetLastNode();

        lastNode.Next = newNode;
        newNode.Previous = lastNode;
    }

    #endregion
}