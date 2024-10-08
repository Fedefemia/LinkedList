using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LinkedArrayTiba
{
    internal class CLinkedList<T>
    {
        private Node<T> Head;
        private Node<T> Last;
        private int Count = 0;

        public void Add(T data)
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

        public void Clear() // -tibaldo
        {
            Head = null;
            Last = null;
            Count = 0;
        }

        public bool Contains(T data) // -tibaldo
        {
            Node<T> node = Head;
            for (int i = 0; i < Count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(node.Data, data)) return true;
                node = node.Child;
            }
            return false;
        }

        public Node<T> Find(T data) // -tibaldo
        {
            Node<T> node = Head;
            for (int i = 0; i < Count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(node.Data, data)) return node;
                node = node.Child;
            }
            return null;
        }

        public Node<T> FindLast(T data) // -tibaldo
        {
            Node<T> node = Head;
            Node<T> lastNode = null;
            for (int i = 0; i < Count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(node.Data, data)) lastNode = node;
                node = node.Child;
            }
            return lastNode;
        }

        public void Remove(Node<T> node) // -tibaldo
        {
            Node<T> currentNode = Head;
            for (int i = 0; i < Count; i++)
            {
                if (currentNode == node)
                {
                    if (currentNode == Head) Head = currentNode.Child;
                    else if (currentNode == Last) Last = currentNode.Parent;
                    else currentNode.Parent.Child = currentNode.Child;
                    Count--;
                }
                currentNode = currentNode.Child;
            }
        }

        public void Remove(T data) // -tibaldo
        {
            Node<T> node = Head;
            for (int i = 0; i < Count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(node.Data, data))
                {
                    Remove(node);
                    return;
                }
                node = node.Child;
            }
        }

        public void RemoveFirst() // -tibaldo
        {
            if (Head == null) return;
            Head = Head.Child;
            Count--;
        }

        public void RemoveLast() // -tibaldo
        {
            if (Last == null) return;
            Last = Last.Parent;
            Count--;
        }

        public string ToString() // -tibaldo
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
                    text += node.Data.ToString() + " ";
                    node = node.Child;
                }
            }
            return text;
        }
    }
}
