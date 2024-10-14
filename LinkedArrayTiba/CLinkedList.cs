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
            newNode.Parent = pos;

            newNode.Child = pos.Child;
            pos.Child = newNode;

            if (newNode.Child != null)
            {
                newNode.Child.Parent = newNode;
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
                newNode.Child = Head;
                Head.Parent = newNode;
                Head = newNode;
                Count++;
                return;
            }
            newNode.Parent = pos.Parent;
            newNode.Child = pos;
            pos.Parent.Child = newNode;
            pos.Parent = newNode;
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
            newNode.Child = Head;
            Head.Parent = newNode;
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
            newNode.Child = Head;
            Head.Parent = newNode;
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
            Last.Child = newNode;
            newNode.Parent = Last;
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
                Last.Child = node;
                node.Parent = Last;
            }
            Last = node;
            Count++;
        }

        public void Clear()
        {
            Node<T> node = Head;
            for (int i = 0; i < Count; i++)
            {
                Node<T> nextNode = node.Child;
                node.Child = null;
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
                node = node.Child;
            }
            return false;
        }

        public Node<T> Find(T data)
        {
            Node<T> node = Head;
            for (int i = 0; i < Count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(node.Value, data)) return node;
                node = node.Child;
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
                node = node.Child;
            }
            return lastNode;
        }

        public void Remove(Node<T> node)
        {
            if (node == null) return;

            if (node == Head)
            {
                Head = Head.Child;
                if (Head != null)
                {
                    Head.Parent = null;
                }
                else
                {
                    Last = null;
                }
            }
            else if (node == Last)
            {
                Last = Last.Parent;
                if (Last != null)
                {
                    Last.Child = null;
                }
            }
            else
            {
                if (node.Parent != null)
                {
                    node.Parent.Child = node.Child;
                }
                if (node.Child != null)
                {
                    node.Child.Parent = node.Parent;
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
            Head = Head.Child;
            Head.Parent = null;
            Count--;
        }

        public void RemoveLast()
        {
            if (Last == null) return;
            Last = Last.Parent;
            Last.Child = null;
            Count--;
        }

        public string ToString()
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
                    node = node.Child;
                }
            }
            return text;
        }
    }
}
