using System.Collections.Generic;
using System.Xml.Linq;

namespace LinkedArrayTiba
{
    internal class CLinkedList<T>
    {
        private Node<T> Head;
        private Node<T> Last;

        private int Count = 0;
        public void AddAfter(Node<T> pos, Node<T> nuov)
        {
            Node<T> newNode = new Node<T>(nuov.Value);
            newNode.Previous = pos;

            newNode.Next = pos.Next;
            pos.Next = newNode;

            if (newNode.Next != null)
            {
                newNode.Next.Previous = newNode;
                Count++;
                return;
            }
            Last = newNode;
            Count++;
        }
        public void AddAfter(Node<T> pos, T data)
        {
            Node<T> newNode = new Node<T>(data);
            AddAfter(pos, newNode);
        }
        public void AddBefore(Node<T> pos, Node<T> nuov)
        {
            Node<T> newNode = new Node<T>(nuov.Value);
            if (pos == Head)
            {
                newNode.Next = Head;
                Head.Previous = newNode;
                Head = newNode;
                Count++;
                return;
            }
            newNode.Previous = pos.Previous;
            newNode.Next = pos;
            pos.Previous.Next = newNode;
            pos.Previous = newNode;
            Count++;
        }
        public void AddBefore(Node<T> pos, T data)
        {
            Node<T> newNode = new Node<T>(data);
            AddBefore(pos, newNode);
        }
        public void AddFirst(Node<T> nuov)
        {
            Node<T> newNode = new Node<T>(nuov.Value);
            if (Head == null)
            {
                Head = newNode;
                Last = newNode;
                Count++;
                return;
            }
            newNode.Next = Head;
            Head.Previous = newNode;
            Head = newNode;
            Count++;
        }
        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (Head == null)
            {
                Head = newNode;
                Last = newNode;
                Count++;
                return;
            }
            newNode.Next = Head;
            Head.Previous = newNode;
            Head = newNode;
            Count++;
        }
        public void AddLast(Node<T> nuov)
        {
            Node<T> newNode = new Node<T>(nuov.Value);
            if (Head == null)
            {
                Head = newNode;
                Last = newNode;
                Count++;
                return;
            }
            Last.Next = newNode;
            newNode.Previous = Last;
            Last = newNode;
            Count++;
        }
        public void AddLast(T data)
        {
            Node<T> node = new Node<T>(data);
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                Last.Next = node;
                node.Previous = Last;
            }
            Last = node;
            Count++;
        }

        public void Clear()
        {
            Node<T> node = Head;
            for (int i = 0; i < Count; i++)
            {
                Node<T> nextNode = node.Next;
                node.Next = null;
                node = nextNode;
            }

            Head = null;
            Last = null;
            Count = 0;
        }

        public bool Contains(T data)
        {
            Node<T> node = Head;
            for (int i = 0; i < Count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(node.Value, data)) return true;
                node = node.Next;
            }
            return false;
        }

        public Node<T> Find(T data)
        {
            Node<T> node = Head;
            for (int i = 0; i < Count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(node.Value, data)) return node;
                node = node.Next;
            }
            return null;
        }

        public Node<T> FindLast(T data)
        {
            Node<T> node = Head;
            Node<T> lastNode = null;
            for (int i = 0; i < Count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(node.Value, data)) lastNode = node;
                node = node.Next;
            }
            return lastNode;
        }

        public void Remove(Node<T> node)
        {
            if (node == null) return;

            if (node == Head)
            {
                Head = Head.Next;
                if (Head != null)
                {
                    Head.Previous = null;
                }
                else
                {
                    Last = null;
                }
            }
            else if (node == Last)
            {
                Last = Last.Previous;
                if (Last != null)
                {
                    Last.Next = null;
                }
            }
            else
            {
                if (node.Previous != null)
                {
                    node.Previous.Next = node.Next;
                }
                if (node.Next != null)
                {
                    node.Next.Previous = node.Previous;
                }
            }

            Count--;
        }

        public void Remove(T data)
        {
            Node<T> node = Find(data);
            if (node != null)
            {
                Remove(node);
            }
        }


        public void RemoveFirst()
        {
            if (Head == null) return;
            Head = Head.Next;
            Head.Previous = null;
            Count--;
        }

        public void RemoveLast()
        {
            if (Last == null) return;
            Last = Last.Previous;
            Last.Next = null;
            Count--;
        }

        public override string ToString()
        {
            string text = string.Empty;

            if (Head == null)
            {
                text = "No data";
            }
            else
            {
                Node<T> node = Head;
                for (int i = 0; i < Count; i++)
                {
                    text += node.Value.ToString() + " ";
                    node = node.Next;
                }
            }
            return text;
        }
    }
}
