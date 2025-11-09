namespace DataStructures.Structures.Linear.Nodes
{
    internal class Node<T>
    {
        //public T Value { get; private set; }
        private T _value;
        //public Node<T> NextNode { get; private set; }
        private Node<T> _nextNode;

        public Node(){ }

        public Node(T value)
        {
            this._value = value;
        }

        public void SetNextNode(Node<T> nextNode)
        {
            _nextNode = nextNode;
        }

        public void setValue(T value)
        {
            _value = value;
        }

        public T getValue()
        {
            return _value;
        }

        public Node<T> getNextNode()
        {
            return _nextNode;
        }

    }
}
