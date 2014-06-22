using System.Collections;
using System.Collections.Generic;

namespace gonzo.DataStructures
{
    class StackLinkedList<T> : IEnumerable<T>
    {
        private class Node
        {
            public T Item { get; set; }
            public Node Next { get; set; }
            public Node(T item)
            {
                Item = item;
            }
        }

        private Node _first;

        public T First()
        {
            return _first.Item;
        }

        public void Push(T item)
        {
            var temp = _first;
            _first = new Node(item);
            _first.Next = temp;
        }

        public T Pop()
        {
            var temp = _first;
            _first = _first.Next;
            return temp.Item;
        }

        public StackLinkedList()
        {

        }

        public IEnumerator<T> GetEnumerator()
        {
            var node = _first;
            while (node != null)
            {
                yield return node.Item;
                node = node.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
