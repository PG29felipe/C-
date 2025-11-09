using DataStructures.Structures.Linear.Nodes;
using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class SingleLinkedList<T>
    {
        private Node<T> _head;
        private Node<T> _tail;
        private int _size;

        // Constructor
        public SingleLinkedList() 
        {
            _head = null;
            _tail = _head;
            _size = 1;
        }

        // Constructor that populates the list with the contesnt of an array
        public SingleLinkedList(T[] arrayCopy) 
        {
            //if ()
            //{

            //}
            for (int i = 0; i < arrayCopy.Length; i++)
            {
                Append(arrayCopy[i]);
            }
        }

        //Validates if the linked list is empty
        public bool IsEmpty() => _head == null;

        // Appends entry to end of list.
        public void Append(T entry) 
        {
            Node<T> newNode = new Node<T>(entry);
            _size++;

            if (IsEmpty())
            {
                _head = _tail = newNode;
                return;
            }

            _tail.SetNextNode(newNode);
            _tail = newNode;
        }

        // Insert entry at supplied index
        public void Insert(T entry, int index) {}

        // Remove entry at supplied index
        public void Remove(int index) {}

        // Set entry to list entry at supplied index
        public void Replace(T entry, int index) {}

        // Returns the data contained at the provided index
        public T Get(int index) { return (T)Activator.CreateInstance(typeof(T)); }

        // Return index of first instance of supplied entry or -1 if not found.
        public int Find(T entry) { return -1; }

        // Return current size of list.
        public int Size() { return -1; }

        // Prints all elements of the list to the screen
        public void Print() { }
    }
}
