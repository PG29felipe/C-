using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Structures.Linear.Nodes
{
    internal class DoubleLinkedListNode<T> : Node<T>
    {
        private Node<T> _previousNode;

        public DoubleLinkedListNode() { }
        public DoubleLinkedListNode(T value) : base(value) { }
        //{
        //    //this.setValue(value);
        //}

        public void SetPreviousNode(Node<T> previousNode)
        {
            _previousNode = previousNode;
        }

        public Node<T> getPreviousNode()
        {
            return _previousNode;
        }
    }
}
