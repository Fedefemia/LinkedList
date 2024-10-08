using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedArrayTiba
{
    internal class Node<T>
    {
        public T Data;
        public Node<T> Child;
        public Node<T> Parent;

        public Node(T data)
        {
            Data = data;
        }
    }
}
