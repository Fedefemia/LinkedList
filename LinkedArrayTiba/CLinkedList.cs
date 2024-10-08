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
        private Node<T> Previous;
        private bool ein = false;
        private int leng = 0;

        public void Add(T elem)
        {
            Node<T> nodon = new Node<T>(elem);
            if (!ein)
            {
                Head = nodon;
                Previous = nodon;
            }
            else
            {
                Previous.child = nodon;
                Previous = nodon;
            }
            ein = true;
            Last = nodon;
            leng++;
        }
        public void Print()
        {
            if (!ein)
            {
                Console.WriteLine("No data");
            }
            else
            {
                Node<T> selectednode = Head;
                Console.WriteLine(selectednode.data.ToString());
                for (int i = 0; i < leng - 1; i++)
                {
                    selectednode = selectednode.child;
                    Console.WriteLine(selectednode.data.ToString());

                }
            }
        }
    }
}
