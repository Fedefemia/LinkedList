using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedArrayTiba
{
    internal class Node<T>
    {
        public T data;
        public Node<T> child;
        public Node(T elem) { 
         this.data = elem;
        }
    }
}
